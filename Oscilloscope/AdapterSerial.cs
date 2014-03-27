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
        string port;
        public AdapterSerial(DataCollector d, string port)
        {
            this.port = port;
            t = new Thread(Generate);
            this.d = d;
            t.IsBackground = true;
            t.Start();
        }
        public void Generate()
        {
            SerialPort sp = new SerialPort(port,115200);
            sp.Open();

            for (; ; )
            {
                int value;
                    if (int.TryParse(sp.ReadLine(), out value))
                        lock (d)
                            d.NewPoint(value);
            }
        }
        ~AdapterSerial()
        {
            t.Abort();
        }
    }
}
