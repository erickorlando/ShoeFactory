using ShoeFactory.WinApp.Maestros;

namespace ShoeFactory.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cuerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCrudCueros())
            {
                frm.ShowDialog();
            }
        }

        private void monedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCrudCurrencies())
            {
                frm.ShowDialog();
            }
        }
    }
}
