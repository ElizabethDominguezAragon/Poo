using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_4_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsEmpleado objEmpleado = new ClsEmpleado();
            objEmpleado.numEmpleado = Convert.ToInt32(txtNumEmpleado.Text);
            objEmpleado.nombreEmpleado = txtNombre.Text;
            objEmpleado.Puesto = cmbTipo.SelectedItem.ToString();

            rhResultado.Text = objEmpleado.ToString() + 
                "\n Total Salario: " +  objEmpleado.calcularSalario(
                    Convert.ToDouble(txtSalario.Text),
                    Convert.ToInt32(txtDias.Text), 
                    Convert.ToDouble(txtVentas.Text),
                    Convert.ToInt32(cmbComision.Text)) +"\n";
        }
    }
}
