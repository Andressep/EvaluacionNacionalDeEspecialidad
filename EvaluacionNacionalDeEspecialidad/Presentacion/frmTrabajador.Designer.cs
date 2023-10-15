namespace EvaluacionNacionalDeEspecialidad.Presentacion
{
    partial class frmTrabajador
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
            horasTrabajadas = new Label();
            horasExtras = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalcular = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnListar = new Button();
            hrsTrabajadasInput = new TextBox();
            sueldoLiquidoInput = new TextBox();
            hrsExtrasInput = new TextBox();
            sueldobrutoInput = new TextBox();
            AFP = new ComboBox();
            SALUD = new ComboBox();
            SuspendLayout();
            // 
            // horasTrabajadas
            // 
            horasTrabajadas.AutoSize = true;
            horasTrabajadas.Location = new Point(80, 42);
            horasTrabajadas.Name = "horasTrabajadas";
            horasTrabajadas.Size = new Size(120, 15);
            horasTrabajadas.TabIndex = 0;
            horasTrabajadas.Text = "HORAS TRABAJADAS";
            // 
            // horasExtras
            // 
            horasExtras.AutoSize = true;
            horasExtras.Location = new Point(80, 97);
            horasExtras.Name = "horasExtras";
            horasExtras.Size = new Size(89, 15);
            horasExtras.TabIndex = 1;
            horasExtras.Text = "HORAS EXTRAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 181);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "SUELDO BRUTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 232);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "SUELDO LIQUIDO";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 149);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(80, 190);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(80, 232);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 24);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(80, 275);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // hrsTrabajadasInput
            // 
            hrsTrabajadasInput.Location = new Point(226, 34);
            hrsTrabajadasInput.Name = "hrsTrabajadasInput";
            hrsTrabajadasInput.Size = new Size(100, 23);
            hrsTrabajadasInput.TabIndex = 8;
            // 
            // sueldoLiquidoInput
            // 
            sueldoLiquidoInput.Location = new Point(406, 233);
            sueldoLiquidoInput.Name = "sueldoLiquidoInput";
            sueldoLiquidoInput.Size = new Size(100, 23);
            sueldoLiquidoInput.TabIndex = 9;
            // 
            // hrsExtrasInput
            // 
            hrsExtrasInput.Location = new Point(226, 97);
            hrsExtrasInput.Name = "hrsExtrasInput";
            hrsExtrasInput.Size = new Size(100, 23);
            hrsExtrasInput.TabIndex = 9;
            // 
            // sueldobrutoInput
            // 
            sueldobrutoInput.Location = new Point(406, 173);
            sueldobrutoInput.Name = "sueldobrutoInput";
            sueldobrutoInput.Size = new Size(100, 23);
            sueldobrutoInput.TabIndex = 10;
            // 
            // AFP
            // 
            AFP.FormattingEnabled = true;
            AFP.Location = new Point(406, 39);
            AFP.Name = "AFP";
            AFP.Size = new Size(121, 23);
            AFP.TabIndex = 11;
            AFP.Text = "AFP";
            AFP.SelectedIndexChanged += AFP_SelectedIndexChanged;
            // 
            // SALUD
            // 
            SALUD.FormattingEnabled = true;
            SALUD.Location = new Point(406, 97);
            SALUD.Name = "SALUD";
            SALUD.Size = new Size(121, 23);
            SALUD.TabIndex = 12;
            SALUD.Text = "SALUD";
            SALUD.SelectedIndexChanged += SALUD_SelectedIndexChanged;
            // 
            // frmTrabajador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 343);
            Controls.Add(SALUD);
            Controls.Add(AFP);
            Controls.Add(sueldobrutoInput);
            Controls.Add(hrsExtrasInput);
            Controls.Add(sueldoLiquidoInput);
            Controls.Add(hrsTrabajadasInput);
            Controls.Add(btnListar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(horasExtras);
            Controls.Add(horasTrabajadas);
            Name = "frmTrabajador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrabajador";
            Load += frmTrabajador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label horasTrabajadas;
        private Label horasExtras;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnListar;
        private TextBox hrsTrabajadasInput;
        private TextBox sueldoLiquidoInput;
        private TextBox hrsExtrasInput;
        private TextBox sueldobrutoInput;
        private ComboBox AFP;
        private ComboBox SALUD;
    }
}