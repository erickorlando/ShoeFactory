using ShoeFactory.WinPart;

namespace ShoeFactory.WinApp.Maestros
{
    public partial class FrmCrudMaestro : PlantillaCrud
    {
        public string Endpoint { get; set; } = null!;

        public FrmCrudMaestro()
        {
            InitializeComponent();
        }
    }
}
