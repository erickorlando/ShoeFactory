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
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableTypeDtoResponseBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            editBindingSource = new BindingSource(components);
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableTypeDtoResponseBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 217);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 1;
            label1.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(76, 215);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(423, 22);
            txtFiltro.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.buscar_16x16;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(513, 215);
            button1.Name = "button1";
            button1.Size = new Size(112, 22);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, descripcionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tableTypeDtoResponseBindingSource;
            dataGridView1.Location = new Point(12, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(667, 407);
            dataGridView1.TabIndex = 3;
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
            // tableTypeDtoResponseBindingSource
            // 
            tableTypeDtoResponseBindingSource.DataSource = typeof(Dto.Response.TableTypeDtoResponse);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 138);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", editBindingSource, "Description", true));
            textBox2.Location = new Point(90, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(426, 22);
            textBox2.TabIndex = 1;
            // 
            // editBindingSource
            // 
            editBindingSource.DataSource = typeof(Dto.Request.TableTypeDtoRequest);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 81);
            label3.Name = "label3";
            label3.Size = new Size(70, 13);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", editBindingSource, "Code", true));
            textBox1.Location = new Point(90, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 43);
            label2.Name = "label2";
            label2.Size = new Size(48, 13);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // FrmCrudMaestro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 676);
            Controls.Add(groupBox1);
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
            Controls.SetChildIndex(groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableTypeDtoResponseBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editBindingSource).EndInit();
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
        private GroupBox groupBox1;
        private TextBox textBox2;
        private BindingSource editBindingSource;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
    }
}