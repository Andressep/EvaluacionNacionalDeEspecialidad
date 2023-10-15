using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionNacionalDeEspecialidad.Presentacion
{
    public partial class frmTrabajador : Form
    {
        public frmTrabajador()
        {
            InitializeComponent();

            AFP.Items.Clear();

            // Agrega nuevas opciones al ComboBox
            AFP.Items.Add("CUPRUM 7%");
            AFP.Items.Add("MODELO 9%");
            AFP.Items.Add("CAPITAL 12%");
            AFP.Items.Add("PROVIDA 13%");

            SALUD.Items.Clear();

            SALUD.Items.Add("FONASA 12%");
            SALUD.Items.Add("CONSALUD 13%");
            SALUD.Items.Add("MASVIDA 14%");
            SALUD.Items.Add("BANMEDICA 15%");
        }

        private void AFP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void SALUD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horasTrabajadas = int.Parse(hrsTrabajadasInput.Text);
            int horasExtras = int.Parse(hrsExtrasInput.Text);
            string afpSeleccionada = AFP.SelectedItem.ToString();
            string saludSeleccionada = SALUD.SelectedItem.ToString();


            if (horasTrabajadas > 1 && horasTrabajadas <= 180)
            {

                double valorHora = 2500.0;
                double valorHoraExtra = 3000.0;

                double sueldoBruto = (horasTrabajadas * valorHora) + (horasExtras * valorHoraExtra);

                double descuentoAFP = 0.0;
                double descuentoSalud = 0.0;

                if (afpSeleccionada == "CUPRUM 7%")
                {
                    descuentoAFP = sueldoBruto * 0.07;
                }
                else if (afpSeleccionada == "MODELO 9%")
                {
                    descuentoAFP = sueldoBruto * 0.09;
                }
                else if (afpSeleccionada == "CAPITAL 12%")
                {
                    descuentoAFP = sueldoBruto * 0.12;
                }
                else if (afpSeleccionada == "PROVIDA 13%")
                {
                    descuentoAFP = sueldoBruto * 0.13;
                }

                if (saludSeleccionada == "FONASA 12%")
                {
                    descuentoSalud = sueldoBruto * 0.12;
                }
                else if (saludSeleccionada == "CONSALUD 13%")
                {
                    descuentoSalud = sueldoBruto * 0.13;
                }
                else if (saludSeleccionada == "MASVIDA 14%")
                {
                    descuentoSalud = sueldoBruto * 0.14;
                }
                else if (saludSeleccionada == "BANMEDICA 15%")
                {
                    descuentoSalud = sueldoBruto * 0.15;
                }

                double sueldoLiquido = sueldoBruto - descuentoAFP - descuentoSalud;

                sueldobrutoInput.Text = sueldoBruto.ToString();
                sueldoLiquidoInput.Text = sueldoLiquido.ToString();
            }
            else
            {
                MessageBox.Show("Horas trabajadas no válidas. Debe ser un número entre 1 y 50.");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            hrsTrabajadasInput.Text = string.Empty;
            hrsExtrasInput.Text = string.Empty;
            AFP.SelectedIndex = -1; // Deseleccionar la opción en el ComboBox AFP
            SALUD.SelectedIndex = -1; // Deseleccionar la opción en el ComboBox SALUD
            sueldobrutoInput.Text = string.Empty;
            sueldoLiquidoInput.Text = string.Empty;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarTrabajadores listarTrabajadores = new listarTrabajadores();
            listarTrabajadores.Show();
            this.Hide();
        }
    }
}
