using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    internal class ClsCalculadora
    {
        public int resultado = 0;
        public void Sumar(int numero1, int numero2)
        {
            resultado = numero1 + numero2;
        }
        public void Restar(int numero1, int numero2)
        {
             resultado = numero1 - numero2;
        }
        public void Multiplicar(int numero1, int numero2)
        {
             resultado = numero1 * numero2;
        }
        public void Dividir(int numero1, int numero2)
        {
            resultado = numero1 / numero2;
        }

    }
    
        
}
