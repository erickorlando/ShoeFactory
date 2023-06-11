namespace ShoeFactory.WinApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            datosMaestrosToolStripMenuItem = new ToolStripMenuItem();
            tiposDeMovimientoToolStripMenuItem = new ToolStripMenuItem();
            cuerosToolStripMenuItem = new ToolStripMenuItem();
            monedasToolStripMenuItem = new ToolStripMenuItem();
            modelosToolStripMenuItem = new ToolStripMenuItem();
            tiposDeDocumentoToolStripMenuItem = new ToolStripMenuItem();
            tiposDePagoToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            codigosDeSeccionToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            controlDeProduccionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            mostrarAyudaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { datosMaestrosToolStripMenuItem, procesosToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(783, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // datosMaestrosToolStripMenuItem
            // 
            datosMaestrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiposDeMovimientoToolStripMenuItem, cuerosToolStripMenuItem, monedasToolStripMenuItem, modelosToolStripMenuItem, tiposDeDocumentoToolStripMenuItem, tiposDePagoToolStripMenuItem, categoriasToolStripMenuItem, productosToolStripMenuItem, codigosDeSeccionToolStripMenuItem });
            datosMaestrosToolStripMenuItem.Name = "datosMaestrosToolStripMenuItem";
            datosMaestrosToolStripMenuItem.Size = new Size(100, 20);
            datosMaestrosToolStripMenuItem.Text = "Datos Maestros";
            // 
            // tiposDeMovimientoToolStripMenuItem
            // 
            tiposDeMovimientoToolStripMenuItem.Name = "tiposDeMovimientoToolStripMenuItem";
            tiposDeMovimientoToolStripMenuItem.Size = new Size(186, 22);
            tiposDeMovimientoToolStripMenuItem.Text = "Tipos de Movimiento";
            // 
            // cuerosToolStripMenuItem
            // 
            cuerosToolStripMenuItem.Name = "cuerosToolStripMenuItem";
            cuerosToolStripMenuItem.Size = new Size(186, 22);
            cuerosToolStripMenuItem.Text = "Cueros";
            cuerosToolStripMenuItem.Click += cuerosToolStripMenuItem_Click;
            // 
            // monedasToolStripMenuItem
            // 
            monedasToolStripMenuItem.Name = "monedasToolStripMenuItem";
            monedasToolStripMenuItem.Size = new Size(186, 22);
            monedasToolStripMenuItem.Text = "Monedas";
            monedasToolStripMenuItem.Click += monedasToolStripMenuItem_Click;
            // 
            // modelosToolStripMenuItem
            // 
            modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            modelosToolStripMenuItem.Size = new Size(186, 22);
            modelosToolStripMenuItem.Text = "Modelos";
            // 
            // tiposDeDocumentoToolStripMenuItem
            // 
            tiposDeDocumentoToolStripMenuItem.Name = "tiposDeDocumentoToolStripMenuItem";
            tiposDeDocumentoToolStripMenuItem.Size = new Size(186, 22);
            tiposDeDocumentoToolStripMenuItem.Text = "Tipos de Documento";
            // 
            // tiposDePagoToolStripMenuItem
            // 
            tiposDePagoToolStripMenuItem.Name = "tiposDePagoToolStripMenuItem";
            tiposDePagoToolStripMenuItem.Size = new Size(186, 22);
            tiposDePagoToolStripMenuItem.Text = "Tipos de Pago";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(186, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(186, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // codigosDeSeccionToolStripMenuItem
            // 
            codigosDeSeccionToolStripMenuItem.Name = "codigosDeSeccionToolStripMenuItem";
            codigosDeSeccionToolStripMenuItem.Size = new Size(186, 22);
            codigosDeSeccionToolStripMenuItem.Text = "Codigos de Seccion";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controlDeProduccionToolStripMenuItem });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "&Procesos";
            // 
            // controlDeProduccionToolStripMenuItem
            // 
            controlDeProduccionToolStripMenuItem.Name = "controlDeProduccionToolStripMenuItem";
            controlDeProduccionToolStripMenuItem.Size = new Size(194, 22);
            controlDeProduccionToolStripMenuItem.Text = "&Control de Produccion";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarAyudaToolStripMenuItem, toolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // mostrarAyudaToolStripMenuItem
            // 
            mostrarAyudaToolStripMenuItem.Name = "mostrarAyudaToolStripMenuItem";
            mostrarAyudaToolStripMenuItem.Size = new Size(152, 22);
            mostrarAyudaToolStripMenuItem.Text = "Mostrar Ayuda";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(149, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(152, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.backgroundrealistic;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 497);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 521);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shoe Factory - Sistema de Gestión Integral de Producción";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem datosMaestrosToolStripMenuItem;
        private ToolStripMenuItem tiposDeMovimientoToolStripMenuItem;
        private ToolStripMenuItem cuerosToolStripMenuItem;
        private ToolStripMenuItem monedasToolStripMenuItem;
        private ToolStripMenuItem modelosToolStripMenuItem;
        private ToolStripMenuItem tiposDeDocumentoToolStripMenuItem;
        private ToolStripMenuItem tiposDePagoToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem codigosDeSeccionToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem controlDeProduccionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem mostrarAyudaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}