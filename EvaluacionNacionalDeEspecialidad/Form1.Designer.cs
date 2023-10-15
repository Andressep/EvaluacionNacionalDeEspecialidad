namespace EvaluacionNacionalDeEspecialidad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userInput = new TextBox();
            passwordInput = new TextBox();
            brnIngresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Autentiacion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 48);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 90);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // userInput
            // 
            userInput.Location = new Point(118, 48);
            userInput.Name = "userInput";
            userInput.Size = new Size(134, 23);
            userInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(118, 82);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(134, 23);
            passwordInput.TabIndex = 4;
            // 
            // brnIngresar
            // 
            brnIngresar.Location = new Point(136, 124);
            brnIngresar.Name = "brnIngresar";
            brnIngresar.Size = new Size(96, 30);
            brnIngresar.TabIndex = 5;
            brnIngresar.Text = "Ingresar";
            brnIngresar.UseVisualStyleBackColor = true;
            brnIngresar.Click += brnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            StartPosition = FormStartPosition.CenterScreen; // Configura la posición de inicio al centro
            ClientSize = new Size(370, 166);
            Controls.Add(brnIngresar);
            Controls.Add(passwordInput);
            Controls.Add(userInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userInput;
        private TextBox passwordInput;
        private Button brnIngresar;
    }
}