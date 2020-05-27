using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    class Cumpleaños : Fiesta
    {
        private int tamanyoTarta;
        private string textoTarta;

        public int TamanyoTarta
        {
            get { return tamanyoTarta; }
            set { tamanyoTarta = value; }
        }

        public string TextoTarta
        {
            get { return textoTarta; }
            set { textoTarta = value; }
        }

        public Cumpleaños() : base()
        {
            tamanyoTarta = 40;
            textoTarta = "";
        }

        public override double CalcularCoste()
        {
            if(NumPersonas > 8)
            {
                TamanyoTarta = 75;  
            }
            else
            {
                TamanyoTarta = 40;
            }
            
            return Math.Round(NumPersonas * CosteFijoPersona + CosteDecoracion 
                + TamanyoTarta + 0.25 * TextoTarta.Length, 2);

        }
    }
}
