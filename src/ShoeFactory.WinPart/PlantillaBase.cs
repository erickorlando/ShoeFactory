namespace ShoeFactory.WinPart
{
    public partial class PlantillaBase : Form
    {
        public PlantillaBase()
        {
            InitializeComponent();
        }

        protected void ShowWaitCursor(bool wait)
        {
            Cursor.Current = wait ? Cursors.WaitCursor : Cursors.Default;
        }
    }
}
