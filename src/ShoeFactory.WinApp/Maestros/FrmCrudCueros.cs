using ShoeFactory.Dto.Request;
using ShoeFactory.WinPart;

namespace ShoeFactory.WinApp.Maestros
{
    public partial class FrmCrudCueros : PlantillaCrud
    {
        public FrmCrudCueros()
        {
            InitializeComponent();
        }

        private void FrmCrudCueros_Load(object sender, EventArgs e)
        {
            tableTypeDtoRequestBindingSource.DataSource = new List<TableTypeDtoRequest>
            {
                new()
                {
                    Code = "001",
                    Description = "Cueros"
                },
                new()
                {
                    Code = "002",
                    Description = "Cueros 2"
                },
                
            };
            tableTypeDtoRequestBindingSource.ResetBindings(false);
        }
    }
}
