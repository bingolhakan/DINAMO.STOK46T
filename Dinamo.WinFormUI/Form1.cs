using Dinamo.Bussiness.Concrete;

namespace Dinamo.WinFormUI
{
    public partial class Form1 : Form
    {
        STOK46TMANAGER _stok46Manager = new STOK46TMANAGER();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _stok46Manager.GetAll();
            comboBoxAcikKapali.Text = "Seçiniz...";
        }

        private void comboBoxAcikKapali_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}