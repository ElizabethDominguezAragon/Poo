using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico3_BoletoDeAutobus
{
    internal class ClsBoleto
    {
        public string nombre, origen, destino;
        public int edad, n_asiento;
        public double CalcularCosto(double costo, int tipo, bool alimento)
        {
            if (edad<=3|| edad >= 60){
                costo *= .50;
            }else if (tipo==1) { // si es maestro
                costo *= .75;
            }else if (tipo == 2){ //si es estudiante
                costo *= .60;
            }
            
            if (alimento) {
                costo += 100;
            }
            return costo;
        }
        public override string ToString() { 
        
            return string.Format($"Nombre: {nombre}\nEdad: {edad} Numero Asiento: {n_asiento}" +
                          $"\nOrigen: {origen} Destino: {destino}");
        }
    }
}
