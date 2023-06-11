using ShoeFactory.Dto.Request;
using ShoeFactory.WinPart;

namespace ShoeFactory.WinApp.Maestros
{
    public partial class FrmCrudCurrencies : PlantillaCrud
    {
        public FrmCrudCurrencies()
        {
            InitializeComponent();
        }

        private void FrmCrudCurrencies_Load(object sender, EventArgs e)
        {
            tableTypeDtoRequestBindingSource.DataSource = new List<TableTypeDtoRequest>
            {
                new()
                {
                    Code = "001",
                    Description = "SOLES"
                },
                new()
                {
                    Code = "002",
                    Description = "DOLARES AMERICANOS"
                },

            };
            tableTypeDtoRequestBindingSource.ResetBindings(false);
        }
    }
}
