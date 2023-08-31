using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_4_Final
{
    internal class ClsEmpleado
    {
        public int numEmpleado;
        public string nombreEmpleado;
        public string Puesto;
        public double totalSalario;
        
        public string Nombre { get; internal set; }

        public double calcularSalario(double salario, int dias, double ventas, int comision)

        {
            double totalSalario = (salario * dias) + (ventas*comision/100);
            
            if (totalSalario > 10000)
            {
                totalSalario *= .75;
            }
            else if (totalSalario >= 5000)
            {
                totalSalario *= .90;
            }
            else if (totalSalario > 1000)
            {
                totalSalario *= .95;
            }


            return totalSalario;
        }


        public override string ToString()
        {
            return string.Format($"\n NumEmpleado: {numEmpleado} \n Nombre: {nombreEmpleado} \n Puesto {Puesto}");
        }
    }
}
