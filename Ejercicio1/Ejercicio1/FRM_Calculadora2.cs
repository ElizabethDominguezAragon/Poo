using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FRM_Calculadora2 : Form
    {
        public FRM_Calculadora2()
        {
            InitializeComponent();
        }
       ClsCalculadora2 obj = new ClsCalculadora2();
        private void BTT_SUMA_Click(object sender, EventArgs e)
        {
            LB_Resultado.Text = "Resultado: " + obj.Sumar(Convert.ToInt32(TB_N1.Text), Convert.ToInt32(TB_N2.Text));
        }

        private void BTT_RESTA_Click(object sender, EventArgs e)
        {
            LB_Resultado.Text = "Resultado: " + obj.Restar(Convert.ToInt32(TB_N1.Text), Convert.ToInt32(TB_N2.Text));
        }

        private void BTT_DIVICION_Click(object sender, EventArgs e)
        {
            LB_Resultado.Text = "Resultado: " + obj.Dividir(Convert.ToInt32(TB_N1.Text), Convert.ToInt32(TB_N2.Text));

        }

        private void BTT_MULTI_Click(object sender, EventArgs e)
        {
            LB_Resultado.Text = "Resultado: " + obj.Multiplicar(Convert.ToInt32(TB_N1.Text), Convert.ToInt32(TB_N2.Text));

        }
    }
}
