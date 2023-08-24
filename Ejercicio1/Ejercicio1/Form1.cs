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
    public partial class CALCULADORA : Form
    {
        ClsCalculadora ObjCalculadora = new ClsCalculadora();
        public CALCULADORA()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTT_SUMA_Click(object sender, EventArgs e) {

            int num1 = Convert.ToInt32(TB_N1.Text);
            int num2 = Convert.ToInt32(TB_N2.Text);
            ObjCalculadora.Sumar(num1, num2);
            LB_Resultado.Text = "Resultado: " + ObjCalculadora.resultado;
        }

        private void BTT_RESTA_Click(object sender, EventArgs e) {
            ObjCalculadora.Restar(Convert.ToInt32(TB_N1.Text), Convert.ToInt32(TB_N2.Text));
            LB_Resultado.Text = "Resultado: " + ObjCalculadora.resultado;
        }

        private void BTT_MULTI_Click(object sender, EventArgs e)
        {
            ObjCalculadora.Multiplicar(Convert.ToInt32(TB_N1.Text), Convert.ToInt32(TB_N2.Text));
            LB_Resultado.Text = "Resultado: " + ObjCalculadora.resultado;
        }

        private void BTT_DIVICION_Click(object sender, EventArgs e)
        {
            ObjCalculadora.Dividir(Convert.ToInt32(TB_N1.Text),Convert.ToInt32(TB_N2.Text));
            LB_Resultado.Text = "Resultado: " + ObjCalculadora.resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_Calculadora2 forma = new FRM_Calculadora2();
            forma.Show();

        }
    }
}
