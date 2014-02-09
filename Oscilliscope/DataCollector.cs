using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
namespace Oscilliscope
{
    class DataCollector
    {
        Series channel = Program.form1.AddSeries("Channel 1");
        int lastPoint = 0; //needed for triggering

        public void NewPoint(int value)
        {
            //this needs to be asynchronous
            lock (channel)
            {
                if (Program.form1.pos >= Program.form1.MaxPoints || Program.form1.pos == 0)
                {
                    if (Program.form1.triggering)
                    {
                        if (lastPoint <= Program.form1.triggerVal && Program.form1.triggerVal <= value)
                        {
                            Program.form1.ClearPoints(channel);
                            Program.form1.AddPoint(channel, value);
                        }
                    }
                    else
                    {
                        Program.form1.ClearPoints(channel);
                        Program.form1.AddPoint(channel, value);
                    }
                }
                else
                {
                    Program.form1.AddPoint(channel, value);
                }
            }
            lastPoint = value;
        }

    }
}
