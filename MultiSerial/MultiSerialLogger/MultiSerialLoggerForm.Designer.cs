namespace MultiSerialLogger
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
            this.serialPortControl1 = new MultiSerialLogger.SerialPortControl( "" );
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clbPortsList = new System.Windows.Forms.CheckedListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.lblEnablePorts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbSerial1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // serialPortControl1
            // 
            this.serialPortControl1.Location = new System.Drawing.Point(6, 19);
            this.serialPortControl1.Name = "serialPortControl1";
            this.serialPortControl1.Size = new System.Drawing.Size(152, 171);
            this.serialPortControl1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clbPortsList
            // 
            this.clbPortsList.CheckOnClick = true;
            this.clbPortsList.FormattingEnabled = true;
            this.clbPortsList.Location = new System.Drawing.Point(6, 38);
            this.clbPortsList.Name = "clbPortsList";
            this.clbPortsList.Size = new System.Drawing.Size(405, 379);
            this.clbPortsList.TabIndex = 2;
            this.clbPortsList.SelectedIndexChanged += new System.EventHandler(this.clbPortsList_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageConfiguration);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(506, 449);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.lblEnablePorts);
            this.tabPageConfiguration.Controls.Add(this.button1);
            this.tabPageConfiguration.Controls.Add(this.clbPortsList);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(498, 423);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.grbSerial1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MultiSerialLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 473);
            this.Controls.Add(this.tabControl);
            this.Name = "MultiSerialLoggerForm";
            this.Text = "Multi Serial Logger by SDI";
            this.Load += new System.EventHandler(this.MultiSerialLogger_Load);
            this.grbSerial1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SerialPortControl serialPortControl1;
        private System.Windows.Forms.GroupBox grbSerial1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox clbPortsList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEnablePorts;
    }
}

