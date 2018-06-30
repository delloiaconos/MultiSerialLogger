namespace MultiSerialLogger
{
    partial class SerialPortControl
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataSize = new System.Windows.Forms.Label();
            this.cmbDataSize = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.gboxSerialConfig = new System.Windows.Forms.GroupBox();
            this.gboxLogConfig = new System.Windows.Forms.GroupBox();
            this.cboxEnableLog = new System.Windows.Forms.CheckBox();
            this.cboxDateTime = new System.Windows.Forms.CheckBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblPostfix = new System.Windows.Forms.Label();
            this.txxPostfix = new System.Windows.Forms.TextBox();
            this.gboxSerialConfig.SuspendLayout();
            this.gboxLogConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(19, 43);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(140, 21);
            this.cmbSerialPort.TabIndex = 0;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(19, 83);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(140, 21);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(16, 27);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(57, 13);
            this.lblSerialPort.TabIndex = 2;
            this.lblSerialPort.Text = "Port Name";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(16, 67);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(16, 107);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(53, 13);
            this.lblDataSize.TabIndex = 5;
            this.lblDataSize.Text = "Data Size";
            // 
            // cmbDataSize
            // 
            this.cmbDataSize.FormattingEnabled = true;
            this.cmbDataSize.Location = new System.Drawing.Point(19, 123);
            this.cmbDataSize.Name = "cmbDataSize";
            this.cmbDataSize.Size = new System.Drawing.Size(140, 21);
            this.cmbDataSize.TabIndex = 4;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(16, 147);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(33, 13);
            this.lblParity.TabIndex = 6;
            this.lblParity.Text = "Parity";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(19, 163);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(140, 21);
            this.cmbParity.TabIndex = 7;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // gboxSerialConfig
            // 
            this.gboxSerialConfig.Controls.Add(this.cmbParity);
            this.gboxSerialConfig.Controls.Add(this.lblParity);
            this.gboxSerialConfig.Controls.Add(this.lblDataSize);
            this.gboxSerialConfig.Controls.Add(this.cmbDataSize);
            this.gboxSerialConfig.Controls.Add(this.lblBaudRate);
            this.gboxSerialConfig.Controls.Add(this.lblSerialPort);
            this.gboxSerialConfig.Controls.Add(this.cmbBaudRate);
            this.gboxSerialConfig.Controls.Add(this.cmbSerialPort);
            this.gboxSerialConfig.Location = new System.Drawing.Point(13, 16);
            this.gboxSerialConfig.Name = "gboxSerialConfig";
            this.gboxSerialConfig.Size = new System.Drawing.Size(180, 206);
            this.gboxSerialConfig.TabIndex = 8;
            this.gboxSerialConfig.TabStop = false;
            this.gboxSerialConfig.Text = "Port Config";
            // 
            // gboxLogConfig
            // 
            this.gboxLogConfig.Controls.Add(this.lblPostfix);
            this.gboxLogConfig.Controls.Add(this.txxPostfix);
            this.gboxLogConfig.Controls.Add(this.lblSuffix);
            this.gboxLogConfig.Controls.Add(this.txtSuffix);
            this.gboxLogConfig.Controls.Add(this.cboxDateTime);
            this.gboxLogConfig.Controls.Add(this.cboxEnableLog);
            this.gboxLogConfig.Location = new System.Drawing.Point(212, 16);
            this.gboxLogConfig.Name = "gboxLogConfig";
            this.gboxLogConfig.Size = new System.Drawing.Size(223, 205);
            this.gboxLogConfig.TabIndex = 9;
            this.gboxLogConfig.TabStop = false;
            this.gboxLogConfig.Text = "Log Config";
            // 
            // cboxEnableLog
            // 
            this.cboxEnableLog.AutoSize = true;
            this.cboxEnableLog.Checked = true;
            this.cboxEnableLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxEnableLog.Location = new System.Drawing.Point(18, 27);
            this.cboxEnableLog.Name = "cboxEnableLog";
            this.cboxEnableLog.Size = new System.Drawing.Size(80, 17);
            this.cboxEnableLog.TabIndex = 0;
            this.cboxEnableLog.Text = "Enable Log";
            this.cboxEnableLog.UseVisualStyleBackColor = true;
            // 
            // cboxDateTime
            // 
            this.cboxDateTime.AutoSize = true;
            this.cboxDateTime.Location = new System.Drawing.Point(18, 43);
            this.cboxDateTime.Name = "cboxDateTime";
            this.cboxDateTime.Size = new System.Drawing.Size(99, 17);
            this.cboxDateTime.TabIndex = 1;
            this.cboxDateTime.Text = "Add Date/Time";
            this.cboxDateTime.UseVisualStyleBackColor = true;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(17, 83);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(200, 20);
            this.txtSuffix.TabIndex = 2;
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(15, 67);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(33, 13);
            this.lblSuffix.TabIndex = 3;
            this.lblSuffix.Text = "Suffix";
            // 
            // lblPostfix
            // 
            this.lblPostfix.AutoSize = true;
            this.lblPostfix.Location = new System.Drawing.Point(15, 108);
            this.lblPostfix.Name = "lblPostfix";
            this.lblPostfix.Size = new System.Drawing.Size(38, 13);
            this.lblPostfix.TabIndex = 5;
            this.lblPostfix.Text = "Postfix";
            // 
            // txxPostfix
            // 
            this.txxPostfix.Location = new System.Drawing.Point(17, 124);
            this.txxPostfix.Name = "txxPostfix";
            this.txxPostfix.Size = new System.Drawing.Size(200, 20);
            this.txxPostfix.TabIndex = 4;
            // 
            // SerialPortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gboxLogConfig);
            this.Controls.Add(this.gboxSerialConfig);
            this.Name = "SerialPortControl";
            this.Size = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.SerialPortControl_Load);
            this.gboxSerialConfig.ResumeLayout(false);
            this.gboxSerialConfig.PerformLayout();
            this.gboxLogConfig.ResumeLayout(false);
            this.gboxLogConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Label lblDataSize;
        private System.Windows.Forms.ComboBox cmbDataSize;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox gboxSerialConfig;
        private System.Windows.Forms.GroupBox gboxLogConfig;
        private System.Windows.Forms.Label lblPostfix;
        private System.Windows.Forms.TextBox txxPostfix;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.CheckBox cboxDateTime;
        private System.Windows.Forms.CheckBox cboxEnableLog;
    }
}
