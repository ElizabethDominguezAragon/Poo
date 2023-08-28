using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converciones
{
    public partial class Form1 : Form
    {
        ClsConvercion  objconversion = new ClsConvercion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btanCalcular_Click(object sender, EventArgs e)
        {
            switch (cmbConvercion.SelectedIndex)
            {
                case 0:
                    lblResultado.Text= "Resultado:" + objconversion.ConvertirKmMilla(Convert.ToDouble(txtCantidad.Text));
                    break;
                case 1:
                    lblResultado.Text = "Resultado:" + objconversion.ConvertirMillaKm(Convert.ToDouble(txtCantidad.Text));
                    break;
                case 2:
                    lblResultado.Text = "Resultado:" + objconversion.ConvertirKgLbs(Convert.ToDouble(txtCantidad.Text));
                    break;
                case 3:
                    lblResultado.Text = "Resultado:" + objconversion.ConvertirLbsKg(Convert.ToDouble(txtCantidad.Text));
                    break;
            }
        }
    }
}
