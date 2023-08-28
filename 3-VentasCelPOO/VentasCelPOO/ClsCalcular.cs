using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasCelPOO
{
    internal class ClsCalcular
       
    {
        public double CalcularCostoCelulares (double costo, int cantidad)
        {
            double totalVenta = costo * cantidad;
            if (cantidad >= 10 && cantidad <=20)
            {
                totalVenta *= .95;
            }
            else if (cantidad >= 21 && cantidad <= 50)
            {
                totalVenta *= .90;
            }
            else if (cantidad > 50)
            {
                totalVenta *= .80;
            }
            return totalVenta;
            
        }
    }
}
