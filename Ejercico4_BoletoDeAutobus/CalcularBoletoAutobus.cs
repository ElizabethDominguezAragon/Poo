using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercico3_BoletoDeAutobus
{
    public partial class CalcularBoletoAutobus : Form
    {
        public CalcularBoletoAutobus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsBoleto obj = new ClsBoleto(); 
            obj.nombre = TXT_Nombre.Text;
            obj.edad = Convert.ToInt32(TXT_Edad.Text);
            obj.n_asiento = Convert.ToInt32(TXT_Asiento.Text);
            obj.origen = CBX_Origen.SelectedItem.ToString();
            obj.destino = CBX_Destino.SelectedItem.ToString();
            
            richTextBox1.Text = obj.ToString()+ "\nTotal: "+
                obj.CalcularCosto(Convert.ToDouble(TXT_Costo.Text),CBX_TIPO.SelectedIndex,CHB_Alimentos.Checked);
        }
    }
}
