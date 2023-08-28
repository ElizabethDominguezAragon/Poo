using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO2_Converciones
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }
        CLS_CONVERSION obj = new CLS_CONVERSION();
        private void button1_Click(object sender, EventArgs e)
        {
            switch (Opciones.SelectedIndex) {
                case 0:
                    LBL_Resultado.Text = "Resultado: " + obj.Convertir_KM_Millas(Convert.ToDouble(Txt_Cantidad.Text));
                    break;
                case 1:
                    LBL_Resultado.Text = "Resultado: " + obj.Convertir_Millas_KM(Convert.ToDouble(Txt_Cantidad.Text));
                    break;
                case 2:
                    LBL_Resultado.Text = "Resultado: " + obj.ConvertirKgLbs(Convert.ToDouble(Txt_Cantidad.Text));
                    break;
                case 3:
                    LBL_Resultado.Text = "Resultado: " + obj.ConvertirLbsKg(Convert.ToDouble(Txt_Cantidad.Text));
                    break;
            }
        }
    }
}
