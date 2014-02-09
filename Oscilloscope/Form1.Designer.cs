namespace Oscilloscope
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numYDiv = new System.Windows.Forms.TrackBar();
            this.numYOffset = new System.Windows.Forms.TrackBar();
            this.numXDivLog = new System.Windows.Forms.TrackBar();
            this.numXOffset = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.numTrigger = new System.Windows.Forms.TrackBar();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnCOM3 = new System.Windows.Forms.Button();
            this.rdFree = new System.Windows.Forms.RadioButton();
            this.rdCycle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXDivLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrigger)).BeginInit();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.Display.ChartAreas.Add(chartArea1);
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(845, 538);
            this.Display.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y div";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y offset";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(863, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X div";
            // 
            // numYDiv
            // 
            this.numYDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numYDiv.LargeChange = 10;
            this.numYDiv.Location = new System.Drawing.Point(863, 30);
            this.numYDiv.Maximum = 103;
            this.numYDiv.Minimum = 1;
            this.numYDiv.Name = "numYDiv";
            this.numYDiv.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.numYDiv.Size = new System.Drawing.Size(45, 204);
            this.numYDiv.TabIndex = 7;
            this.numYDiv.TickFrequency = 5;
            this.numYDiv.Value = 103;
            this.numYDiv.Scroll += new System.EventHandler(this.numYDiv_Scroll);
            // 
            // numYOffset
            // 
            this.numYOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numYOffset.LargeChange = 10;
            this.numYOffset.Location = new System.Drawing.Point(907, 30);
            this.numYOffset.Maximum = 1023;
            this.numYOffset.Name = "numYOffset";
            this.numYOffset.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.numYOffset.Size = new System.Drawing.Size(45, 204);
            this.numYOffset.TabIndex = 8;
            this.numYOffset.TickFrequency = 50;
            this.numYOffset.Value = 512;
            this.numYOffset.Scroll += new System.EventHandler(this.numYOffset_Scroll);
            // 
            // numXDivLog
            // 
            this.numXDivLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numXDivLog.Location = new System.Drawing.Point(863, 253);
            this.numXDivLog.Maximum = 933;
            this.numXDivLog.Minimum = 1;
            this.numXDivLog.Name = "numXDivLog";
            this.numXDivLog.Size = new System.Drawing.Size(210, 45);
            this.numXDivLog.TabIndex = 9;
            this.numXDivLog.TickFrequency = 50;
            this.numXDivLog.Value = 1;
            this.numXDivLog.Scroll += new System.EventHandler(this.numXDivLog_Scroll);
            // 
            // numXOffset
            // 
            this.numXOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numXOffset.Location = new System.Drawing.Point(866, 304);
            this.numXOffset.Maximum = 1000;
            this.numXOffset.Name = "numXOffset";
            this.numXOffset.Size = new System.Drawing.Size(210, 45);
            this.numXOffset.TabIndex = 11;
            this.numXOffset.TickFrequency = 50;
            this.numXOffset.Scroll += new System.EventHandler(this.numXOffset_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(866, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X offset";
            // 
            // numTrigger
            // 
            this.numTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTrigger.Enabled = false;
            this.numTrigger.LargeChange = 10;
            this.numTrigger.Location = new System.Drawing.Point(958, 30);
            this.numTrigger.Maximum = 1023;
            this.numTrigger.Name = "numTrigger";
            this.numTrigger.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.numTrigger.Size = new System.Drawing.Size(45, 204);
            this.numTrigger.TabIndex = 13;
            this.numTrigger.TickFrequency = 50;
            this.numTrigger.Value = 512;
            this.numTrigger.Scroll += new System.EventHandler(this.numTrigger_Scroll);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrigger.Location = new System.Drawing.Point(958, 9);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(42, 23);
            this.btnTrigger.TabIndex = 14;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnCOM3
            // 
            this.btnCOM3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOM3.Location = new System.Drawing.Point(1001, 341);
            this.btnCOM3.Name = "btnCOM3";
            this.btnCOM3.Size = new System.Drawing.Size(72, 32);
            this.btnCOM3.TabIndex = 15;
            this.btnCOM3.Text = "COM3";
            this.btnCOM3.UseVisualStyleBackColor = true;
            this.btnCOM3.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdFree
            // 
            this.rdFree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdFree.AutoSize = true;
            this.rdFree.Checked = true;
            this.rdFree.Location = new System.Drawing.Point(993, 153);
            this.rdFree.Name = "rdFree";
            this.rdFree.Size = new System.Drawing.Size(46, 17);
            this.rdFree.TabIndex = 16;
            this.rdFree.TabStop = true;
            this.rdFree.Text = "Free";
            this.rdFree.UseVisualStyleBackColor = true;
            this.rdFree.CheckedChanged += new System.EventHandler(this.rdFree_CheckedChanged);
            // 
            // rdCycle
            // 
            this.rdCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdCycle.AutoSize = true;
            this.rdCycle.Location = new System.Drawing.Point(993, 176);
            this.rdCycle.Name = "rdCycle";
            this.rdCycle.Size = new System.Drawing.Size(51, 17);
            this.rdCycle.TabIndex = 17;
            this.rdCycle.TabStop = true;
            this.rdCycle.Text = "Cycle";
            this.rdCycle.UseVisualStyleBackColor = true;
            this.rdCycle.CheckedChanged += new System.EventHandler(this.rdCycle_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 562);
            this.Controls.Add(this.rdCycle);
            this.Controls.Add(this.rdFree);
            this.Controls.Add(this.btnCOM3);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.numTrigger);
            this.Controls.Add(this.numXOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numXDivLog);
            this.Controls.Add(this.numYOffset);
            this.Controls.Add(this.numYDiv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXDivLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrigger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar numYDiv;
        private System.Windows.Forms.TrackBar numYOffset;
        private System.Windows.Forms.TrackBar numXDivLog;
        private System.Windows.Forms.TrackBar numXOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar numTrigger;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnCOM3;
        private System.Windows.Forms.RadioButton rdFree;
        private System.Windows.Forms.RadioButton rdCycle;
    }
}

