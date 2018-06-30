using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MultiSerialLogger
{
    public partial class SerialPortControl : UserControl
    {
        private String PortName = "";


        public SerialPortControl(String portName)
        {
            InitializeComponent();
        }

        private void SerialPortControl_Load(object sender, EventArgs e)
        {
            Dictionary<Int32, String> baudrateItems = new Dictionary<Int32, String>();
            baudrateItems.Add(600   , "600" );
            baudrateItems.Add(1200  , "1200");
            baudrateItems.Add(4800  , "4800");
            baudrateItems.Add(9600  , "9600");
            baudrateItems.Add(14400 , "14400");
            baudrateItems.Add(19200 , "19200");
            baudrateItems.Add(38400 , "38400");
            baudrateItems.Add(56000 , "56000");
            baudrateItems.Add(57600 , "57600");
            baudrateItems.Add(115200, "115200");

            this.cmbBaudRate.DataSource = new BindingSource(baudrateItems, null);
            this.cmbBaudRate.DisplayMember = "Value";
            this.cmbBaudRate.ValueMember = "Key";

            string[] ports = SerialPort.GetPortNames();
            this.cmbSerialPort.DataSource = new BindingSource(ports, null);

            Dictionary<Int32, String> datasizeItems = new Dictionary<Int32, String>();
            datasizeItems.Add(7, "7");
            datasizeItems.Add(8, "8");
            this.cmbDataSize.DataSource = new BindingSource(datasizeItems, null);
            this.cmbDataSize.DisplayMember = "Value";
            this.cmbDataSize.ValueMember = "Key";


            Dictionary<Int32, String> parityItems = new Dictionary<Int32, String>();
            parityItems.Add(0, "none");
            parityItems.Add(1, "odd");
            parityItems.Add(2, "even");
            this.cmbParity.DataSource = new BindingSource(parityItems, null);
            this.cmbParity.DisplayMember = "Value";
            this.cmbParity.ValueMember = "Key";


        }

        public bool setPortName( String portName )
        {
            this.PortName = portName;
            return true;
        }
    }
}
