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
            string contrase�aIngresada = passwordInput.Text;

            if (usuarioIngresado == "admin" && contrase�aIngresada == "1234")
            {
                // Las credenciales son correctas, abrir el formulario de trabajadores
                formularioTrabajadores.Show();
                this.Hide();
            }
            else
            {
                // Las credenciales son incorrectas, mostrar un mensaje de error o tomar otra acci�n
                MessageBox.Show("Credenciales incorrectas. Int�ntelo de nuevo.");
                contador += 1;
                if (contador >= 3)
                {
                    // Si se superan 3 intentos fallidos, cerrar la aplicaci�n
                    Application.Exit();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}