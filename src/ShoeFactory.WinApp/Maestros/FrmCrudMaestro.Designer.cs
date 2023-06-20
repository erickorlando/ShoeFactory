namespace ShoeFactory.WinApp.Maestros
{
    partial class FrmCrudMaestro
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFiltro = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tableTypeDtoResponseBindingSource = new BindingSource(components);
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableTypeDtoResponseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 1;
            label1.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(68, 62);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(423, 22);
            txtFiltro.TabIndex = 2;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.buscar_16x16;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(505, 62);
            button1.Name = "button1";
            button1.Size = new Size(112, 22);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tableTypeDtoResponseBindingSource;
            dataGridView1.Location = new Point(12, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(667, 288);
            dataGridView1.TabIndex = 4;
            // 
            // tableTypeDtoResponseBindingSource
            // 
            tableTypeDtoResponseBindingSource.DataSource = typeof(Dto.Response.TableTypeDtoResponse);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCrudMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 404);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            MinimumSize = new Size(707, 443);
            Name = "FrmCrudMaestro";
            Text = "FrmCrudMaestro";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtFiltro, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableTypeDtoResponseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private BindingSource tableTypeDtoResponseBindingSource;
    }
}