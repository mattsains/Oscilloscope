using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace Oscilliscope
{
    public partial class Form1 : Form
    {
        public int MaxPoints = 150;
        private AdapterSine s;

        public Form1()
        {
            InitializeComponent();
            UpdateScale();
            
        }
        public Series AddSeries(string name)
        {
            Series s = Display.Series.Add(name);
            s.ChartType = SeriesChartType.Line;
            return s;
        }
        public void RemoveSeries(Series s)
        {
            Display.Series.Remove(s);
        }

        public int pos = 0;
        delegate void AddPointCallback(Series s, int value);
        public void AddPoint(Series s, int value)
        {
            if (this.Display.InvokeRequired)
            {
                AddPointCallback d = new AddPointCallback(AddPoint);
                this.Invoke(d, new object[] { s, value });
            }
            else
            {
                if (pos >= s.Points.Count)
                    s.Points.AddXY(pos++, value);
                else
                    s.Points[pos++].YValues[0] = value;
                Display.Invalidate();
            }
        }
        delegate void ClearPointsCallback(Series s);
        public void ClearPoints(Series s)
        {
            if (this.Display.InvokeRequired)
            {
                ClearPointsCallback d = new ClearPointsCallback(ClearPoints);
                this.Invoke(d, new object[] { s });
            }
            else
            {
                pos = 0;
            }
        }

        int Ycenter = 512;
        int Ydiv = 103;
        
        int Xdiv = 10;
        int Xcenter = 0;

        
        private void UpdateScale()
        {
            Axis XAxis=Display.ChartAreas[0].AxisX;
            Axis YAxis=Display.ChartAreas[0].AxisY;
            XAxis.MajorGrid.Interval = Xdiv;
            YAxis.MajorGrid.Interval = Ydiv;

            XAxis.Minimum = (double)(Xcenter - Xdiv *5);
            XAxis.Maximum = (double)(Xcenter + Xdiv*5);
            YAxis.Minimum = (double)(Ycenter - Ydiv*5);
            YAxis.Maximum = (double)(Ycenter + Ydiv*5);

            //clamping
            if (YAxis.Minimum < 0)
                YAxis.Minimum = 0;
            if (YAxis.Minimum > YAxis.Maximum)
                YAxis.Maximum = YAxis.Minimum + 2;
            if (XAxis.Minimum < 0)
                XAxis.Minimum = 0;
            if (XAxis.Minimum > XAxis.Maximum)
                XAxis.Maximum = XAxis.Minimum + 2;

            //Trigger
            triggerLevel.Points.AddXY(XAxis.Minimum, triggerVal);
            triggerLevel.Points.AddXY(XAxis.Maximum, triggerVal);

            //Cycle mode
            if (cycle)
                MaxPoints = (int)Display.ChartAreas[0].AxisX.Maximum;
            else
                MaxPoints = int.MaxValue;
        }

        private void numYDiv_Scroll(object sender, EventArgs e)
        {
            Ydiv = numYDiv.Value;
            UpdateScale();
        }

        private void numYOffset_Scroll(object sender, EventArgs e)
        {
            Ycenter = numYOffset.Maximum - numYOffset.Value;
            UpdateScale();
        }

        private void numXDivLog_Scroll(object sender, EventArgs e)
        {
            Xdiv = (int)Math.Pow(10, numXDivLog.Value / 100.0) /*+ numXDivLog.Value*/;
            UpdateScale();
        }

        private void numXOffset_Scroll(object sender, EventArgs e)
        {
            Xcenter = numXOffset.Value;
            UpdateScale();
        }

        public bool triggering = false;
        public int triggerVal = 512;
        Series triggerLevel = new Series("Trigger Level");

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            triggerLevel.ChartType = SeriesChartType.FastLine;

            if (triggering)
            {
                btnTrigger.BackColor = SystemColors.Control;
                btnTrigger.ForeColor = SystemColors.ControlText;

                Display.Series.Remove(triggerLevel);
            }
            else
            {
                btnTrigger.BackColor = Color.Green;
                btnTrigger.ForeColor = Color.White;
                
                Display.Series.Add(triggerLevel);

            }
            triggering = !triggering;
            numTrigger.Enabled = triggering;
        }

        private void numTrigger_Scroll(object sender, EventArgs e)
        {
            triggerVal = numTrigger.Value;
            triggerLevel.Points.Clear();
            UpdateScale();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = new AdapterSine(new DataCollector());
        }

        bool cycle = false;
        private void rdFree_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFree.Checked)
            {
                cycle = false;
                numXOffset.Enabled = true;
                UpdateScale();
            }
        }

        private void rdCycle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCycle.Checked)
            {
                cycle = true;
                numXOffset.Value = 0;
                Xcenter = 0;
                numXOffset.Enabled = false;
                UpdateScale();
            }
        }


    }
}
