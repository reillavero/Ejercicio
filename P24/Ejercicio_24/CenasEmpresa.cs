using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    class CenasEmpresa : Fiesta
    {
        private bool opcionSaludable;
        private double costeBebidaPorPersona;

        public bool OpcionSaludable
        {
            get { return opcionSaludable; }
            set { opcionSaludable = value; }
        }

        public double CosteBebidaPorPersona
        {
            get { return costeBebidaPorPersona; }
            set { costeBebidaPorPersona = value; }
        }

        public CenasEmpresa() : base()
        {
            OpcionSaludable = false;
            CosteBebidaPorPersona = 20;
        }

        public override double CalcularCoste()
        {
            if(OpcionSaludable)
            {
                return Math.Round(EstableceOpcionSaludable() * (NumPersonas * (CosteFijoPersona + CosteBebidaPorPersona) 
                    + CosteDecoracion), 2);
            }
            else
            {
                CosteBebidaPorPersona = 20;
                return Math.Round(NumPersonas * (CosteFijoPersona + CosteBebidaPorPersona) + CosteDecoracion, 2);
            }  
        }

        public double EstableceOpcionSaludable()
        {
            CosteBebidaPorPersona = 5;
            return 0.95;   
        }
    }
}
