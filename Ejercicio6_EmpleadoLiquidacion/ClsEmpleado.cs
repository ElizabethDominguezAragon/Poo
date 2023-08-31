using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_EmpleadoLiquidacion
{
    internal class ClsEmpleado
    {
        string nombre;
        int IMSS;
        double salario;
        int años;

        public ClsEmpleado(string nombre, int IMSS, double salario, int años)
        {
            this.nombre = nombre;
            this.IMSS = IMSS;
            this.salario = salario;
            this.años = años;
        }
        public double Calcular_Finiquito(double salario, int años)
        {
            //3 meses por salario 
            double finiquito = salario * 90;
            //20 dias por cada año en la empresa
            finiquito +=
            return 0;
        }
        }
        public override string ToString() {
            return string.Format("");

        }
    }
}
