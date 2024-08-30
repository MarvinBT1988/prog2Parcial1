using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1.Domain
{
	public class Planilla
	{

		public decimal Salario { get; set; }

        private decimal ISSS {  get; set; }

        private decimal AFP { get; set; }

        private decimal Renta { get; set; }


        public Planilla()
        {
            
        }

        public Planilla ( decimal salario)
        {
            Salario = salario;
        }


        public decimal CalcularISSS()
        {

            ISSS = Salario * 0.03m;
            if (ISSS > 30)
            {
                ISSS = 30;
            }
            return ISSS;
        }

        public decimal CalcularAFP()
        {
            AFP = Salario * 0.0725m;
            return AFP;
        }

        public decimal CalcularRenta() 
        {
            if (Renta > 472.1m & Renta < 895.24m)
            {
                Renta = Salario * 0.10m;
            }
            else if(Renta >= 895.24m &  Renta < 2038.10m)
            {
                Renta = Salario * 0.20m;
            }
            else if ( Renta >= 2038.10m )
            {
                Renta = Salario * 0.30m;
            }

            return Renta;
   
        }

    }



}
