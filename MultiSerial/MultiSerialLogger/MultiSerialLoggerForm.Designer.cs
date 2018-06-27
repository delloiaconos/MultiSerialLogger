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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.serialPortControl1 = new MultiSerialLogger.SerialPortControl();
            this.grbSerial1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSerial1
            // 
            this.grbSerial1.Controls.Add(this.textBox1);
            this.grbSerial1.Controls.Add(this.serialPortControl1);
            this.grbSerial1.Location = new System.Drawing.Point(543, 74);
            this.grbSerial1.Name = "grbSerial1";
            this.grbSerial1.Size = new System.Drawing.Size(169, 341);
            this.grbSerial1.TabIndex = 1;
            this.grbSerial1.TabStop = false;
            this.grbSerial1.Text = "Serial Port 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(22, 35);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(139, 274);
            this.checkedListBox1.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.grbSerial1);
            this.Name = "MultiSerialLoggerForm";
            this.Text = "Multi Serial Logger by SDI";
            this.Load += new System.EventHandler(this.MultiSerialLogger_Load);
            this.grbSerial1.ResumeLayout(false);
            this.grbSerial1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SerialPortControl serialPortControl1;
        private System.Windows.Forms.GroupBox grbSerial1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

