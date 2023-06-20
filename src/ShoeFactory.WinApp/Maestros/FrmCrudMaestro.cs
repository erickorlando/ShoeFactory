using ShoeFactory.Dto.Request;
using ShoeFactory.Dto.Response;
using ShoeFactory.WinApp.Proxy;
using ShoeFactory.WinPart;

namespace ShoeFactory.WinApp.Maestros
{
    public partial class FrmCrudMaestro : PlantillaCrud
    {
        public string Endpoint { get; set; } = null!;
        private TableTypeDtoRequest Request { get; set; } = null!;
        private int _currentId;

        public FrmCrudMaestro()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            Shown += (_, _) => Listar();
            button1.Click += (_, _) => Listar();
            txtFiltro.KeyUp+= (_, key) =>
            {
                if (key.KeyCode == Keys.Enter)
                {
                    Listar();
                }
            };
        }

        protected override void HabilitaBotones(bool enabled)
        {
            base.HabilitaBotones(enabled);
            groupBox1.Enabled = !enabled;
        }

        public override void Nuevo()
        {
            base.Nuevo();
            Request = new TableTypeDtoRequest();
            editBindingSource.DataSource = Request;
            editBindingSource.ResetBindings(false);
            textBox1.Focus();
        }

        public override void Editar()
        {
            base.Editar();
            if (tableTypeDtoResponseBindingSource.Current is TableTypeDtoResponse edit)
            {
                _currentId = edit.Id;
                Request = new TableTypeDtoRequest()
                {
                    Code = edit.Codigo,
                    Description = edit.Descripcion
                };
                editBindingSource.DataSource = Request;
                editBindingSource.ResetBindings(false);
                textBox1.Focus();
            }
        }

        public override void Guardar()
        {
            
            try
            {
                editBindingSource.EndEdit();
                var response = !ModoEditar
                    ? ApiHelper.Instance.Add(Endpoint, Request)
                    : ApiHelper.Instance.Update(Endpoint, _currentId, Request);

                if (response.Success)
                {
                    MessageBox.Show(@"Registro guardado correctamente",
                        @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitaBotones(true);
                    Listar();
                }
                else
                {
                    throw new InvalidOperationException(response.ErrorMessage);
                }

                base.Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Eliminar()
        {
            base.Eliminar();
            var rpta = MessageBox.Show(@"¿Desea eliminar el registro?",
                @"Confirme", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rpta != DialogResult.Yes) return;

            if (tableTypeDtoResponseBindingSource.Current is not TableTypeDtoResponse edit) return;

            var response = Task.Run(async () => await ApiHelper.Instance.Delete(Endpoint, edit.Id));
            response.Wait();

            if (response.Result.Success)
            {
                MessageBox.Show(@"Registro eliminado correctamente",
                    @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
            }
            else
            {
                MessageBox.Show(response.Result.ErrorMessage, @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Listar()
        {
            try
            {
                base.Listar();
                ShowWaitCursor(true);
                var response = Task.Run(async () => await ApiHelper.Instance.List(Endpoint, txtFiltro.Text));
                response.Wait();

                tableTypeDtoResponseBindingSource.DataSource = response.Result;
                tableTypeDtoResponseBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ShowWaitCursor(false);
            }
        }
    }
}
