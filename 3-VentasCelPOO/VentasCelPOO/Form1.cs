﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasCelPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ClsCalcular objCalcular = new ClsCalcular();
            MessageBox.Show("Total de la venta: "+objCalcular.CalcularCostoCelulares(Convert.ToDouble(txtCosto.Text), Convert.ToInt32(txtCantidad.Text)));

        }
    }
}
