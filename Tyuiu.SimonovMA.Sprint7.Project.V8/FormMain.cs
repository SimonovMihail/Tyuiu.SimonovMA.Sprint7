using Tyuiu.SimonovMA.Sprint7.Project.V8.Lib;

namespace Tyuiu.SimonovMA.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelName_SMA_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_SMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.StartPosition = FormStartPosition.Manual;
            formAbout.Location = this.Location;
            formAbout.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFuelCalculate formFuel = new FormFuelCalculate();
            formFuel.StartPosition = FormStartPosition.Manual;
            formFuel.Location = this.Location;
            formFuel.ShowDialog();
        }
    }
}