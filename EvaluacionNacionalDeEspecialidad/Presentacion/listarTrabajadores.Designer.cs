namespace EvaluacionNacionalDeEspecialidad.Presentacion
{
    partial class listarTrabajadores
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
            filter = new Label();
            filterBox = new ComboBox();
            dataGridView1 = new DataGridView();
            modificar = new Button();
            eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // filter
            // 
            filter.AutoSize = true;
            filter.Location = new Point(77, 43);
            filter.Name = "filter";
            filter.Size = new Size(80, 15);
            filter.TabIndex = 0;
            filter.Text = "TRABAJADOR";
            // 
            // filterBox
            // 
            filterBox.FormattingEnabled = true;
            filterBox.Location = new Point(187, 43);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(163, 23);
            filterBox.TabIndex = 1;
            filterBox.Text = "TODOS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(644, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // modificar
            // 
            modificar.Location = new Point(50, 281);
            modificar.Name = "modificar";
            modificar.Size = new Size(173, 65);
            modificar.TabIndex = 3;
            modificar.Text = "MODIFICAR";
            modificar.UseVisualStyleBackColor = true;
            modificar.Click += modificar_Click;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(442, 281);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(173, 65);
            eliminar.TabIndex = 4;
            eliminar.Text = "ELIMINAR";
            eliminar.UseVisualStyleBackColor = true;
            eliminar.Click += eliminar_Click;
            // 
            // listarTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 369);
            Controls.Add(eliminar);
            Controls.Add(modificar);
            Controls.Add(dataGridView1);
            Controls.Add(filterBox);
            Controls.Add(filter);
            Name = "listarTrabajadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "listarTrabajadores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label filter;
        private ComboBox filterBox;
        private DataGridView dataGridView1;
        private Button modificar;
        private Button eliminar;
    }
}