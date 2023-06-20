namespace ShoeFactory.WinPart
{
    partial class PlantillaCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolNuevo = new ToolStripButton();
            toolEditar = new ToolStripButton();
            toolGrabar = new ToolStripButton();
            toolCancelar = new ToolStripButton();
            toolEliminar = new ToolStripButton();
            toolList = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolNuevo, toolEditar, toolGrabar, toolCancelar, toolEliminar, toolList });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(606, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolNuevo
            // 
            toolNuevo.Image = Properties.Resources.nuevo;
            toolNuevo.ImageTransparentColor = Color.Magenta;
            toolNuevo.Name = "toolNuevo";
            toolNuevo.Size = new Size(78, 36);
            toolNuevo.Text = "&Nuevo";
            // 
            // toolEditar
            // 
            toolEditar.Image = Properties.Resources.Editar;
            toolEditar.ImageTransparentColor = Color.Magenta;
            toolEditar.Name = "toolEditar";
            toolEditar.Size = new Size(73, 36);
            toolEditar.Text = "&Editar";
            // 
            // toolGrabar
            // 
            toolGrabar.Image = Properties.Resources.guardar;
            toolGrabar.ImageTransparentColor = Color.Magenta;
            toolGrabar.Name = "toolGrabar";
            toolGrabar.Size = new Size(85, 36);
            toolGrabar.Text = "&Guardar";
            // 
            // toolCancelar
            // 
            toolCancelar.Image = Properties.Resources.cancelar;
            toolCancelar.ImageTransparentColor = Color.Magenta;
            toolCancelar.Name = "toolCancelar";
            toolCancelar.Size = new Size(89, 36);
            toolCancelar.Text = "&Cancelar";
            // 
            // toolEliminar
            // 
            toolEliminar.Image = Properties.Resources.eliminar;
            toolEliminar.ImageTransparentColor = Color.Magenta;
            toolEliminar.Name = "toolEliminar";
            toolEliminar.Size = new Size(86, 36);
            toolEliminar.Text = "&Eliminar";
            // 
            // toolList
            // 
            toolList.Image = Properties.Resources.refrescar;
            toolList.ImageTransparentColor = Color.Magenta;
            toolList.Name = "toolList";
            toolList.Size = new Size(122, 36);
            toolList.Text = "&Volver a Cargar";
            // 
            // PlantillaCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 540);
            Controls.Add(toolStrip1);
            Name = "PlantillaCrud";
            Text = "PlantillaCrud";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected ToolStrip toolStrip1;
        protected ToolStripButton toolNuevo;
        protected ToolStripButton toolEditar;
        protected ToolStripButton toolGrabar;
        protected ToolStripButton toolCancelar;
        protected ToolStripButton toolEliminar;
        protected ToolStripButton toolList;
    }
}