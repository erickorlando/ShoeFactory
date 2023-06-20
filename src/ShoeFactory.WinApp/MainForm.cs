using ShoeFactory.WinApp.Maestros;

namespace ShoeFactory.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            categoriasToolStripMenuItem.Click += CallMaestroCrud;
            monedasToolStripMenuItem.Click += CallMaestroCrud;
            tiposDeDocumentoToolStripMenuItem.Click += CallMaestroCrud;
            cuerosToolStripMenuItem.Click += CallMaestroCrud;
            modelosToolStripMenuItem.Click += CallMaestroCrud;
            tiposDeMovimientoToolStripMenuItem.Click += CallMaestroCrud;
            tiposDePagoToolStripMenuItem.Click += CallMaestroCrud;
            codigosDeSeccionToolStripMenuItem.Click += CallMaestroCrud;
        }

        private void CallMaestroCrud(object? sender, EventArgs _)
        {
            using var frm = new FrmCrudMaestro();
            var menuItem = (ToolStripMenuItem)sender!;
            frm.Endpoint = menuItem.Tag.ToString() ?? string.Empty;
            frm.Text = menuItem.Text ?? string.Empty;
            frm.ShowDialog();
        }
    }
}
