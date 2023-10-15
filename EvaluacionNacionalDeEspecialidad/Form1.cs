using EvaluacionNacionalDeEspecialidad.Presentacion;

namespace EvaluacionNacionalDeEspecialidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int contador = 0;
        private void brnIngresar_Click(object sender, EventArgs e)
        {
            frmTrabajador formularioTrabajadores = new frmTrabajador();
            string usuarioIngresado = userInput.Text;
            string contraseñaIngresada = passwordInput.Text;

            if (usuarioIngresado == "admin" && contraseñaIngresada == "1234")
            {
                // Las credenciales son correctas, abrir el formulario de trabajadores
                formularioTrabajadores.Show();
                this.Hide();
            }
            else
            {
                // Las credenciales son incorrectas, mostrar un mensaje de error o tomar otra acción
                MessageBox.Show("Credenciales incorrectas. Inténtelo de nuevo.");
                contador += 1;
                if (contador >= 3)
                {
                    // Si se superan 3 intentos fallidos, cerrar la aplicación
                    Application.Exit();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}