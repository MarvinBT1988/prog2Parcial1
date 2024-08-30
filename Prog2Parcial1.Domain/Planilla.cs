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

        private decimal ISSS { get; set; }

        private decimal AFP { get; set; }

        private decimal Renta { get; set; }

        public Planilla()
        {

        }

        public Planilla(decimal salario)
        {
            Salario = salario;
        }


        public decimal CalcularISSS()
        {

            ISSS = Salario * 0.03m ;           
            ISSS = decimal.Round(ISSS,2);
            if (ISSS > 30)
                return 30;
            else
                return ISSS;
        }

        public decimal CalcularAFP()
        {
            AFP = Salario * 0.0725m;
            AFP = decimal.Round(AFP,2);
            return AFP;
        }

        public decimal CalcularRenta() 
        {
            decimal salarioDespuesDescuentosISSSyAFP = Salario - AFP - ISSS;
			if (salarioDespuesDescuentosISSSyAFP >= 472.01m & salarioDespuesDescuentosISSSyAFP <= 895.24m)
            {
                Renta = ((salarioDespuesDescuentosISSSyAFP - 472.0m )* 0.10m)+17.67m;
            }
            else if(salarioDespuesDescuentosISSSyAFP >= 895.25m & salarioDespuesDescuentosISSSyAFP <= 2038.10m)
            {
				Renta = ((salarioDespuesDescuentosISSSyAFP - 895.24m) * 0.20m) + 60m;
			}
            else if (salarioDespuesDescuentosISSSyAFP >= 2038.11m )
            {
				Renta = ((salarioDespuesDescuentosISSSyAFP - 2038.11m) * 0.30m) + 288.57m;
			}
            Renta = decimal.Round(Renta,2);
            return Renta;
   
        }

    }



}
