using ShoeFactory.Dto.Response;
using ShoeFactory.WinApp.Proxy;
using ShoeFactory.WinPart;

namespace ShoeFactory.WinApp.Maestros
{
    public partial class FrmCrudCurrencies : PlantillaCrud
    {
        public FrmCrudCurrencies()
        {
            InitializeComponent();
            Shown+= FrmCrudCurrencies_Load;
        }

        private void FrmCrudCurrencies_Load(object? sender, EventArgs e)
        {
            try
            {
                ShowWaitCursor(true);
                ICollection<TableTypeDtoResponse> currencies = new List<TableTypeDtoResponse>();

                Task.Run(async () =>
                {
                    currencies = await ApiHelper.Instance.List("Currencies", string.Empty);
                }).Wait();

                tableTypeDtoResponseBindingSource.DataSource = currencies;
                tableTypeDtoResponseBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ShowWaitCursor(false);
            }
        }
    }
}
