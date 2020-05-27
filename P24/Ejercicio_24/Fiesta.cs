using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_24
{
    class Fiesta
    {
        private int numPersonas;
        private double costeDecoracion;
        private bool decoracionLujo;
        private double costeFijoPersona;

        public int NumPersonas
        {
            get { return numPersonas; }
            set { numPersonas = value; }
        }

        public double CosteDecoracion
        {
            get { return costeDecoracion; }
            set { costeDecoracion = value; }
        }

        public bool DecoracionLujo
        {
            get { return decoracionLujo; }
            set { decoracionLujo = value; }
        }

        public double CosteFijoPersona
        {
            get { return costeFijoPersona; }
            set { costeFijoPersona = value; }
        }

        public Fiesta()
        {
            NumPersonas = 0;
            CosteDecoracion = 0;
            DecoracionLujo = false;
            CosteFijoPersona = 25;
        }

        public void CalcularCosteDecoracion()
        {
            if(decoracionLujo)
            {
                CosteDecoracion = NumPersonas * 15 + 50;
            }
            else
            {
                CosteDecoracion = NumPersonas * 7.50 + 30;
            }
        }

        public virtual double CalcularCoste()
        {
            throw new System.NotImplementedException();
        }
    }
}
