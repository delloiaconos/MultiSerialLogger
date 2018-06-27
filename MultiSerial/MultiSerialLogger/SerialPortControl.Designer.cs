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
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.lblDataSize = new System.Windows.Forms.Label();
            this.cmbDataSize = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(3, 20);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(140, 21);
            this.cmbSerialPort.TabIndex = 0;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(3, 60);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(140, 21);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(0, 4);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(57, 13);
            this.lblSerialPort.TabIndex = 2;
            this.lblSerialPort.Text = "Port Name";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(0, 44);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "Baud Rate";
            // 
            // lblDataSize
            // 
            this.lblDataSize.AutoSize = true;
            this.lblDataSize.Location = new System.Drawing.Point(0, 84);
            this.lblDataSize.Name = "lblDataSize";
            this.lblDataSize.Size = new System.Drawing.Size(53, 13);
            this.lblDataSize.TabIndex = 5;
            this.lblDataSize.Text = "Data Size";
            // 
            // cmbDataSize
            // 
            this.cmbDataSize.FormattingEnabled = true;
            this.cmbDataSize.Location = new System.Drawing.Point(3, 100);
            this.cmbDataSize.Name = "cmbDataSize";
            this.cmbDataSize.Size = new System.Drawing.Size(140, 21);
            this.cmbDataSize.TabIndex = 4;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(0, 124);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(33, 13);
            this.lblParity.TabIndex = 6;
            this.lblParity.Text = "Parity";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(3, 140);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(140, 21);
            this.cmbParity.TabIndex = 7;
            // 
            // SerialPortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbParity);
            this.Controls.Add(this.lblParity);
            this.Controls.Add(this.lblDataSize);
            this.Controls.Add(this.cmbDataSize);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.lblSerialPort);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.cmbSerialPort);
            this.Name = "SerialPortControl";
            this.Size = new System.Drawing.Size(151, 169);
            this.Load += new System.EventHandler(this.SerialPortControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
