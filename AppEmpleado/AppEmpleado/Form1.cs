using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncedad_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string fechanac=dtpnacimiento.Value.ToString("dd/mm/yyyy");
            string fechaing=dtpingreso.Value.ToString("dd/mm/yyyy");
            empleado empleado1 = new empleado(txtnombre.Text, txtapellido.Text, cmbsexo.Text, fechanac, fechaing, float.Parse(txtsalario.Text));
            MessageBox.Show("el empleado:  " + empleado1.Nombre + " " + empleado1.Apellido + " " + empleado1.Sexo + " " + empleado1.Fechanacimiento + " " + empleado1.Fechaingreso + " " + empleado1.Salario + " ha sido registrado");
            {

            }
        }
    }
}
