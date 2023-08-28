using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2_Converciones
{
    internal class CLS_CONVERSION
    {
        public double Convertir_KM_Millas(double cantidad)
        {
            return cantidad / 1.604;
        }
        public double Convertir_Millas_KM(double cantidad)
        {
            return cantidad * 1.604;
        }
        public double ConvertirKgLbs(double cantidad)
        {
            return cantidad * 0.454;
        }
        public double ConvertirLbsKg(double cantidad)
        {
            return cantidad / 0.454;
        }
    }
}
