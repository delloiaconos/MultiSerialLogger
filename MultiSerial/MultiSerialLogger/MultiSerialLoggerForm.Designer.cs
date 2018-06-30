﻿namespace MultiSerialLogger
{
    partial class MultiSerialLoggerForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSerial1 = new System.Windows.Forms.GroupBox();
            this.clbPortsList = new System.Windows.Forms.CheckedListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblEnablePorts = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tpagTest = new System.Windows.Forms.TabPage();
            this.serialPortControl1 = new MultiSerialLogger.SerialPortControl();
            this.grbSerial1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.tpagTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSerial1
            // 
            this.grbSerial1.Controls.Add(this.serialPortControl1);
            this.grbSerial1.Location = new System.Drawing.Point(6, 6);
            this.grbSerial1.Name = "grbSerial1";
            this.grbSerial1.Size = new System.Drawing.Size(169, 193);
            this.grbSerial1.TabIndex = 1;
            this.grbSerial1.TabStop = false;
            this.grbSerial1.Text = "Serial Port 1";
            // 
            // clbPortsList
            // 
            this.clbPortsList.CheckOnClick = true;
            this.clbPortsList.FormattingEnabled = true;
            this.clbPortsList.Location = new System.Drawing.Point(6, 38);
            this.clbPortsList.Name = "clbPortsList";
            this.clbPortsList.Size = new System.Drawing.Size(379, 379);
            this.clbPortsList.TabIndex = 2;
            this.clbPortsList.SelectedIndexChanged += new System.EventHandler(this.clbPortsList_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConfiguration);
            this.tabControl.Controls.Add(this.tpagTest);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(506, 449);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.btnStop);
            this.tabPageConfiguration.Controls.Add(this.lblEnablePorts);
            this.tabPageConfiguration.Controls.Add(this.btnStart);
            this.tabPageConfiguration.Controls.Add(this.clbPortsList);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(498, 423);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(391, 379);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 38);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblEnablePorts
            // 
            this.lblEnablePorts.AutoSize = true;
            this.lblEnablePorts.Location = new System.Drawing.Point(6, 20);
            this.lblEnablePorts.Name = "lblEnablePorts";
            this.lblEnablePorts.Size = new System.Drawing.Size(78, 13);
            this.lblEnablePorts.TabIndex = 4;
            this.lblEnablePorts.Text = "Ports Selection";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(391, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 37);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tpagTest
            // 
            this.tpagTest.Controls.Add(this.grbSerial1);
            this.tpagTest.Location = new System.Drawing.Point(4, 22);
            this.tpagTest.Name = "tpagTest";
            this.tpagTest.Padding = new System.Windows.Forms.Padding(3);
            this.tpagTest.Size = new System.Drawing.Size(498, 423);
            this.tpagTest.TabIndex = 1;
            this.tpagTest.Text = "Test Page";
            this.tpagTest.UseVisualStyleBackColor = true;
            // 
            // serialPortControl1
            // 
            this.serialPortControl1.Location = new System.Drawing.Point(6, 19);
            this.serialPortControl1.Name = "serialPortControl1";
            this.serialPortControl1.Size = new System.Drawing.Size(152, 171);
            this.serialPortControl1.TabIndex = 0;
            // 
            // MultiSerialLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 473);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "MultiSerialLoggerForm";
            this.Text = "Multi Serial Logger by SDI";
            this.Load += new System.EventHandler(this.MultiSerialLogger_Load);
            this.grbSerial1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.tpagTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SerialPortControl serialPortControl1;
        private System.Windows.Forms.GroupBox grbSerial1;
        private System.Windows.Forms.CheckedListBox clbPortsList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tpagTest;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblEnablePorts;
        private System.Windows.Forms.Button btnStop;
    }
}

