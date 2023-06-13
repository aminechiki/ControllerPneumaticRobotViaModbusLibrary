using ModbusMaster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiki.Project.Modbus.UI.Forms
{
    public partial class AutomaticMode : Form
    {

        public AutomaticMode()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 15, 1);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 16, 0);
            MainPage.MasterModbusTcp.OnResponseData += new ModbusTcp.ResponseData(AggiornaStatusOutput);


            //ReadRegisters();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(1);

            var timer = new System.Threading.Timer((e) =>
            {
                ReadRegisters();
            }, null, startTimeSpan, periodTimeSpan);


        }

        public async Task ReadRegisters()
        {
            //Task.Delay(1000).Wait();
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 17, 9);

            //PINZA
            int cambioStatoPinzaAperta = MainPage.MasterModbusTcp.ResponseFromSlave[10] | MainPage.MasterModbusTcp.ResponseFromSlave[9] << 8;
            textBoxPinzaAperta.Text = cambioStatoPinzaAperta.ToString();

            int cambioStatoPinzaChiusa = MainPage.MasterModbusTcp.ResponseFromSlave[12] | MainPage.MasterModbusTcp.ResponseFromSlave[11] << 8;
            textBoxPinzaChiusa.Text = cambioStatoPinzaChiusa.ToString();

            //SU GIU
            int cambioStatoSuRobot = MainPage.MasterModbusTcp.ResponseFromSlave[14] | MainPage.MasterModbusTcp.ResponseFromSlave[13] << 8;
            textBoxSuRobot.Text = cambioStatoSuRobot.ToString();

            int cambioStatoGiuRobot = MainPage.MasterModbusTcp.ResponseFromSlave[16] | MainPage.MasterModbusTcp.ResponseFromSlave[15] << 8;
            textBoxGiuRobot.Text = cambioStatoGiuRobot.ToString();

            //DESTRA SINISTRA



            //CICLI MACCHINA

            int cicliMacchina = MainPage.MasterModbusTcp.ResponseFromSlave[26] | MainPage.MasterModbusTcp.ResponseFromSlave[25] << 8;
            textBoxCicliMacchina.Text = cicliMacchina.ToString();


        }

        public void AggiornaStatusOutput(byte[] values)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 16, 1);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 15, 0);
        }

        private void FungoEmergenza_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 6, 0);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 7, 1);
            //START A 0
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 15, 0);
        }

        private void ResetEmergenza_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 6, 1);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 7, 0);
            //START A 0
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 15, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
