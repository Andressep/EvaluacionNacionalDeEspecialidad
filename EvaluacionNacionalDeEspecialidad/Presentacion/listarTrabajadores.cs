using EvaluacionNacionalDeEspecialidad.Datos;
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
    public partial class listarTrabajadores : Form
    {
        public listarTrabajadores()
        {
            InitializeComponent();

            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Empleado("26931652-7", "Andres Sepulveda", "Santiago", "9 3707 8878", 2500, 3000));
            empleados.Add(new Empleado("26571474-3", "Jose Maipu", "Melipilla", "9 2312 5232", 2500, 3000));
            empleados.Add(new Empleado("25669453-7", "Juanito Peloncio", "Queretaro", "9 5211 8859", 2500, 3000));
            empleados.Add(new Empleado("27477888-7", "Francisco Jurao", "Tialocaca", "9 2412 59i1", 2500, 3000));
            empleados.Add(new Empleado("8756172-7", "Jacinto Montt", "Puerto Montt", "9 5555 6475", 2500, 3000));

            dataGridView1.DataSource = empleados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int indiceSeleccionado = dataGridView1.SelectedRows[0].Index;

                // Accede a la lista de empleados y elimina el empleado correspondiente al índice seleccionado
                ((List<Empleado>)dataGridView1.DataSource).RemoveAt(indiceSeleccionado);

                // Actualiza el DataGridView para reflejar los cambios

                dataGridView1.Refresh();

                // Opcionalmente, puedes guardar los cambios en una base de datos o archivo aquí
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }
    }
}
