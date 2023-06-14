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
    public partial class ManualMode : Form
    {
        public ManualMode()
        {
            InitializeComponent();
        }

        //START STOP
        private void Start_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 4, 1);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 5, 0);
            MainPage.MasterModbusTcp.OnResponseData += new ModbusTcp.ResponseData(AggiornaStatusOutput);
            //MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 0, 4);

            //OUTPUT
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 0, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 1, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 2, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 3, 1);

            //INPUT
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 8, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 9, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 10, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 11, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 12, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 13, 1);

            //ReadRegisters();
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMilliseconds(1000);

            var timer = new System.Threading.Timer((e) =>
            {
                ReadRegisters();
            }, null, startTimeSpan, periodTimeSpan);
        }

        public void ReadRegisters()
        {
            //Task.Delay(1000).Wait();
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 8, 6);

            //SINISTRA 
            int fcSinistra = MainPage.MasterModbusTcp.ResponseFromSlave[10]; //| MainPage.MasterModbusTcp._ResponseFromSlave[9] << 8;
            if (fcSinistra == 1)
            {
                StateInputSinistraRobot.BackColor = Color.Green;
                StateInputDestraRobot.BackColor = Color.Red;
            }

            //DESTRA
            int fcDestra = MainPage.MasterModbusTcp.ResponseFromSlave[12];// | MainPage.MasterModbusTcp._ResponseFromSlave[11] << 8;
            if(fcDestra == 1)
            {
                StateInputSinistraRobot.BackColor = Color.Red;
                StateInputDestraRobot.BackColor = Color.Green;
            }

            //StateInputSinistraRobot.Text = cambioStatoPinzaAperta.ToString();

            //SU GIU
            int fcSu = MainPage.MasterModbusTcp.ResponseFromSlave[14];// | MainPage.MasterModbusTcp._ResponseFromSlave[13] << 8;
            if (fcSu == 1)
            {
                StateInputSuRobot.BackColor = Color.Green;
                StateInputGiuRobot.BackColor = Color.Red;
            }

            int fcGiu = MainPage.MasterModbusTcp.ResponseFromSlave[16];// | MainPage.MasterModbusTcp._ResponseFromSlave[15] << 8;
            if (fcGiu == 1)
            {
                StateInputSuRobot.BackColor = Color.Red;
                StateInputGiuRobot.BackColor = Color.Green;
            }

            //AVANTI INDIETRO
            int fcAvanti = MainPage.MasterModbusTcp.ResponseFromSlave[18];// | MainPage.MasterModbusTcp._ResponseFromSlave[17] << 8;
            if (fcAvanti == 1)
            {
                StateInputAvantiRobot.BackColor = Color.Green;
                StateInputIndietroRobot.BackColor = Color.Red;

            }

            int fcIndietro = MainPage.MasterModbusTcp.ResponseFromSlave[20];// | MainPage.MasterModbusTcp._ResponseFromSlave[19] << 8;
            if (fcIndietro == 1)
            {
                StateInputAvantiRobot.BackColor = Color.Red;
                StateInputIndietroRobot.BackColor = Color.Green;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 5, 1);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 4, 0);
        }

        //FUNGO EMERGENZA
        private void FungoEmergenza_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 6, 0);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 7, 1);
            //START A 0
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 4, 0);
        }

        private void ResetEmergenza_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 6, 1);
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 7, 0);
            //START A 0
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 4, 0);
        }

        //PINZE
        private void ButtonChiudePinzaRobot_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0,0,1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 0, 1);
        }

        private void AperturaPinzaRobot_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 0, 0);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 0, 1);
        }
        //SU GIU ROBOT
        private void suRobot_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 1, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 1, 1);
        }

        private void GiuRobot_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 1, 0);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 1, 1);
        }

        //SINISTRA DESTRA ROBOT

        private void SinistraRobot_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 2, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 2, 1);
            //INPUT
        }

        private void DestraRobot_Click(object sender, EventArgs e)
        {
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 2, 0);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 2, 1);
        }

        //AVANTI INDIETRO ROBOT
        private void AvantiRobot_Click(object sender, EventArgs e)
        {
            //OUTPUT
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 3, 1);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 3, 1);
        }

        private void IndietroRobot_Click(object sender, EventArgs e)
        {
            //INPUT
            MainPage.MasterModbusTcp.WriteSingleRegister((byte)0, 3, 0);
            MainPage.MasterModbusTcp.ReadHoldingRegisters((byte)0, 3, 1);

        }
        private void AggiornaStatusOutput(byte[] values)
        {
            if(values[7] == 3)
            {
                //PINZE
                if (values[10] == 1 && values[1] == 0)          //il numero del registro
                {
                    labelChiusuraPinza.BackColor = Color.Green;
                    labelAperturaPinza.BackColor = Color.Red;
                }
                if (values[10] == 0 && values[1] == 0)
                {
                    labelChiusuraPinza.BackColor = Color.Red;
                    labelAperturaPinza.BackColor = Color.Green;
                }

                //SU GIU ROBOT
                if (values[10] == 1 && values[1] == 1)       //il numero del registro
                {
                    labelSuRobot.BackColor = Color.Green;
                    labelGiuRobot.BackColor = Color.Red;
                }
                if (values[10] == 0 && values[1] == 1)
                {
                    labelSuRobot.BackColor = Color.Red;
                    labelGiuRobot.BackColor = Color.Green;
                }

                //SINISTRA DESTRA ROBOT
                if (values[10] == 1 && values[1] == 2)        //il numero del registro
                {
                    labelDestraRobot.BackColor = Color.Red;
                    labelSinistraRobot.BackColor = Color.Green;
                }
                if (values[10] == 0 && values[1] == 2)
                {
                    labelDestraRobot.BackColor = Color.Green;
                    labelSinistraRobot.BackColor = Color.Red;
                }

                //AVANTI INDIETRO ROBOT
                
                if (values[10] == 1 && values[1] == 3)       //il numero del registro
                {
                    labelAvantiRobot.BackColor = Color.Green;
                    labelIndietroRobot.BackColor = Color.Red;
                }
                if (values[10] == 0 && values[1] == 3)
                {
                    labelAvantiRobot.BackColor = Color.Red;
                    labelIndietroRobot.BackColor = Color.Green;
                }
            }
        }
    }
    }

