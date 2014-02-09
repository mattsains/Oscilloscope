using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace Oscilloscope
{
    class AdapterSerial:IAdapter
    {
        Thread t;
        DataCollector d;
        
        public AdapterSerial(DataCollector d)
        {
            t = new Thread(Generate);
            this.d = d;
            t.Start();
        }
        public void Generate()
        {
            SerialPort sp = new SerialPort("COM3",115200);
            sp.Open();

            for (; ; )
            {
                int value;
                if (int.TryParse(sp.ReadLine(), out value))
                    lock (d)
                        d.NewPoint(value);
                if (sp.BytesToRead<100)
                    sp.WriteLine("k");
            }
        }
        ~AdapterSerial()
        {
            t.Abort();
        }
    }
}
