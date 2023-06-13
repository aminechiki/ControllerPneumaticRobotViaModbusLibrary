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

            //DEFAULT PARAMTERS
            textBoxPort.Text = "502";
            textBoxConnectionTimeout.Text= "1000";
            TextboxIpaddress.Text = "127.0.0.1";
            
            stateConnectionSignal.BackColor= Color.Red;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //PORT
            int port = Convert.ToInt16(textBoxPort.Text);
            //IP ADDRESS
            string ipAddress = TextboxIpaddress.Text;

            MainPage.MasterModbusTcp = new ModbusTcp(ipAddress, port, true);     
            //Se la conessione con il modbus slave è avvenuta corretta la label che indica lo stato
            //della connessione diventra verde
            if(MainPage.MasterModbusTcp.Connected) stateConnectionSignal.BackColor = Color.Green;
            else stateConnectionSignal.BackColor = Color.Red;
        }
    }
}
