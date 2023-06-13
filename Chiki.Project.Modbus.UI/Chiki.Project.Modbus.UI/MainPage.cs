using Chiki.Project.Modbus.UI.Forms;
using ModbusMaster;

namespace Chiki.Project.Modbus.UI
{
    public partial class MainPage : Form
    {
        settingsMdbusTcp settingsForm = new settingsMdbusTcp();
        ManualMode ManualForm = new ManualMode();
        AutomaticMode automaticMode = new AutomaticMode();
        public static ModbusTcp MasterModbusTcp;
        public MainPage()
        {
            InitializeComponent();
            //sia allarga tutta la windoes form quando clicco sui bottoni
            this.WindowState = FormWindowState.Maximized;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            ManualForm.Hide();
            automaticMode.Hide();

            this.IsMdiContainer = true;

            settingsForm.TopLevel = false;
            //remove all'space
            settingsForm.FormBorderStyle = FormBorderStyle.None;
            //insideForm.Dock = DockStyle.Fill;
            this.Controls.Add(settingsForm);
            this.WindowState = FormWindowState.Maximized;
            settingsForm.MdiParent = this;
            settingsForm.Width= this.Width - 330;
            settingsForm.Height= this.Height - 170;
            

            settingsForm.Show();


            //Form Form2 = new Form();
            
        }

        private void AutomaticMode_Click(object sender, EventArgs e)
        {
            ManualForm.Hide();
            settingsForm.Hide();

            this.IsMdiContainer = true;

            automaticMode.TopLevel = false;
            //remove all'space
            automaticMode.FormBorderStyle = FormBorderStyle.None;
            //insideForm.Dock = DockStyle.Fill;
            this.Controls.Add(automaticMode);
            this.WindowState = FormWindowState.Maximized;
            automaticMode.MdiParent = this;
            automaticMode.Width = this.Width - 330;
            automaticMode.Height = this.Height - 170;


            automaticMode.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManualMode_Click(object sender, EventArgs e)
        {
            
            settingsForm.Hide();
            automaticMode.Hide();

            this.IsMdiContainer = true;
            
            ManualForm.TopLevel = false;
            //remove all'space
            ManualForm.FormBorderStyle = FormBorderStyle.None;
            //insideForm.Dock = DockStyle.Fill;
            this.Controls.Add(ManualForm);
            this.WindowState = FormWindowState.Maximized;
            ManualForm.MdiParent = this;
            ManualForm.Width = this.Width - 330;
            ManualForm.Height = this.Height - 170;
            

            ManualForm.Show();

           // this.settingsForm.Hide();
        }
    }

}