using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSerialLogger
{
    public partial class MultiSerialLoggerForm : Form
    {

        public MultiSerialLoggerForm()
        {
            InitializeComponent();
        }

        private void MultiSerialLogger_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.checkedListBox1.Items.Clear();
            foreach( string port in ports)
            {
                this.checkedListBox1.Items.Add(port, false);
            }
            //this.checkedListBox1.DataBindings = new BindingSource(ports, null);
            //this.cmbSerialPort.DataSource = new BindingSource(ports, null);
        }
    }
}
