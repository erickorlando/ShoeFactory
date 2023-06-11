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
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(606, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.nuevo;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(78, 36);
            toolStripButton1.Text = "&Nuevo";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.Editar;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(73, 36);
            toolStripButton2.Text = "&Editar";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.guardar;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(85, 36);
            toolStripButton3.Text = "&Guardar";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.cancelar;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(89, 36);
            toolStripButton4.Text = "&Cancelar";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.eliminar;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(86, 36);
            toolStripButton5.Text = "&Eliminar";
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.refrescar;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(122, 36);
            toolStripButton6.Text = "&Volver a Cargar";
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
        protected ToolStripButton toolStripButton1;
        protected ToolStripButton toolStripButton2;
        protected ToolStripButton toolStripButton3;
        protected ToolStripButton toolStripButton4;
        protected ToolStripButton toolStripButton5;
        protected ToolStripButton toolStripButton6;
    }
}