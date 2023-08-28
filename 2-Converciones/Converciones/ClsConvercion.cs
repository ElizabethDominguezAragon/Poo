using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converciones
{
    internal class ClsConvercion
    {
        public double ConvertirKmMilla (double cantidad)
        {
            return cantidad / 1.604;
        }
        public double ConvertirMillaKm(double cantidad)
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
