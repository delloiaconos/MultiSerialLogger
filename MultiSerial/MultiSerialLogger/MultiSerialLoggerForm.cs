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
        Dictionary<String, TabPage> dynamicPages;
        Dictionary<String, SerialPortControl> dynamicComControl;

        public MultiSerialLoggerForm()
        {
            InitializeComponent();
            this.dynamicPages = new Dictionary<String, TabPage>();
            this.dynamicComControl = new Dictionary<String, SerialPortControl>();
        }

        private void MultiSerialLogger_Load(object sender, EventArgs e)
        {
            
            this.clbPortsList.Items.Clear();

            List<String> lstPortNames = new List<string>(SerialPort.GetPortNames());
            lstPortNames.Sort();
            foreach ( string port in lstPortNames)
            {
                this.clbPortsList.Items.Add(port, false);
            }

            //this.checkedListBox1.DataBindings = new BindingSource(ports, null);
            //this.cmbSerialPort.DataSource = new BindingSource(ports, null);
        }


        private void clbPortsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item = this.clbPortsList.SelectedIndex;

            String PortName = "";
            if (item != -1) {
                PortName = (String)this.clbPortsList.Items[item];
            }

            if( item == -1 || !( PortName.Length > 0 ) ) {
                return;
            }

            lock( this.clbPortsList ) { 
                if (clbPortsList.GetItemChecked(item) == true) {
                    /* Insert Page */

                    SerialPortControl myComControl; 
                    if ( dynamicComControl.TryGetValue(PortName, out myComControl ) == false ) {
                        myComControl = new SerialPortControl();
                        myComControl.setPortName(PortName);
                        dynamicComControl.Add(PortName, myComControl );
                        // Eventuali settaggi...
                    }

                    TabPage myPage;
                    if(dynamicPages.TryGetValue( PortName, out myPage ) == false ) {
                        myPage = new TabPage();
                        myPage.Text = PortName;
                        // Settaggi Pagina...

                        myPage.Controls.Add(myComControl);

                        dynamicPages.Add(PortName, myPage);
                    }

                    tabControl.TabPages.Add(myPage);

                } else if (clbPortsList.GetItemChecked(item) == false) {
                    /* Remove Page */

                    TabPage myPage = new TabPage();
                    if (dynamicPages.TryGetValue(PortName, out myPage) == true) {
                        tabControl.TabPages.Remove(myPage);
                        dynamicPages.Remove(PortName);
                    }
                
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Enabled = false;
            foreach (KeyValuePair<String, SerialPortControl> entry in this.dynamicComControl )
            {
                SerialPortControl myControl = entry.Value;
                myControl.StartPort();
            }
            this.btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            foreach (KeyValuePair<String, SerialPortControl> entry in this.dynamicComControl)
            {
                SerialPortControl myControl = entry.Value;
                myControl.StopPort();
            }
            this.btnStart.Enabled = true;
        }
    }
}
