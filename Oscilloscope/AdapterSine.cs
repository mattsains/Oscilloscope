using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
namespace Oscilloscope
{
    class AdapterSine
    {
        Thread t;
        DataCollector d;

        public AdapterSine(DataCollector d)
        {
            t = new Thread(Generate);
            this.d = d;
            t.Start();
        }
        public void Generate()
        {
            for(;;)
            for (double i=0; i<int.MaxValue; i+=0.1)
            {
                Thread.Sleep(1);
                lock (d)
                    d.NewPoint((int)(Math.Sin(i) * 500) + 512);
            }
        }
        ~AdapterSine()
        {
            t.Abort();
        }
    }
}
