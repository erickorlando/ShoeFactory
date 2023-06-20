namespace ShoeFactory.WinPart
{
    public partial class PlantillaCrud : PlantillaBase
    {
        public bool ModoEditar { get; set; } = false;

        public PlantillaCrud()
        {
            InitializeComponent();
            toolNuevo.Click += (_, _) => Nuevo();
            toolEditar.Click += (_, _) => Editar();
            toolEliminar.Click += (_, _) => Eliminar();
            toolGrabar.Click += (_, _) => Guardar();
            toolCancelar.Click += (_, _) => Cancelar();
            toolList.Click += (_, _) => Listar();

            Load += (_, _) => Inicializar();

        }

        protected virtual void HabilitaBotones(bool enabled)
        {
            toolNuevo.Enabled = enabled;
            toolEditar.Enabled = enabled;
            toolEliminar.Enabled = enabled;
            toolGrabar.Enabled = !enabled;
            toolCancelar.Enabled = !enabled;
            toolList.Enabled = enabled;
        }

        public virtual void Inicializar()
        {
            HabilitaBotones(true);
        }

        public virtual void Nuevo()
        {
            HabilitaBotones(false);
            ModoEditar = false;
        }

        public virtual void Editar()
        {
            HabilitaBotones(false);
            ModoEditar = true;
        }

        public virtual void Eliminar()
        {
            
        }

        public virtual void Guardar()
        {
            HabilitaBotones(true);
            ModoEditar = false;
        }

        public virtual void Cancelar()
        {
            HabilitaBotones(true);
        }

        public virtual void Listar()
        {

        }
    }
}
