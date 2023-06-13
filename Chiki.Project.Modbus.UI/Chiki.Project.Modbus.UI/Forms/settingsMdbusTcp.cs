using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusMaster;

namespace Chiki.Project.Modbus.UI.Forms
{
    public partial class settingsMdbusTcp : Form
    {
        
        public string IpAddress;
        public int Port;
        public bool ConnectionType;
        public settingsMdbusTcp()
        {
            InitializeComponent();
            //this.AutoSize = true;
            //this.AutoSizeMode = AutoSizeMode.;

            //COMBOBOX CONNECTION TYPE
            comboBoxTypeConnection.Items.Add("async");
            comboBoxTypeConnection.Items.Add("sync");
            comboBoxTypeConnection.SelectedItem = "async";

            //DEFAULT PARAMTERS
            textBoxPort.Text = "502";
            textBoxConnectionTimeout.Text= "1000";
            TextboxIpaddress.Text = "127.0.0.1";
            
            stateConnectionSignal.BackColor= Color.Red;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
            int port = Convert.ToInt16(textBoxPort.Text);
            bool connectionType = false;

            string selected = comboBoxTypeConnection.SelectedItem.ToString();
            if (selected == "async") connectionType = true;
            string ipAddress = TextboxIpaddress.Text;

            MainPage.MasterModbusTcp = new ModbusTcp(ipAddress, port, connectionType);
           
            //MasterModbusTcp.Connected;
       
            if(MainPage.MasterModbusTcp.Connected) stateConnectionSignal.BackColor = Color.Green;
            else stateConnectionSignal.BackColor = Color.Red;
        }

        private void settingsMdbusTcp_Load(object sender, EventArgs e)
        {

        }
    }
}
