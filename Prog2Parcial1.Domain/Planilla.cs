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

        
        private decimal SalarioMenosISSYAFP { get; set; }


        public Planilla()
        {

        }

        public Planilla(decimal salario)
        {
            Salario = salario;
        }

        private decimal  ObtenerSalarioMenosISSYAFP(){
             SalarioMenosISSYAFP = Salario - CalcularISSS() - CalcularAFP();
            return SalarioMenosISSYAFP;

		}


        public decimal CalcularISSS()
        {

            ISSS = Salario * 0.03m ; 
            if (ISSS > 30)
            {
                ISSS = 30;
            }
            // ISSS = decimal.Round(ISSS,2);
            return ISSS;
        }

        public decimal CalcularAFP()
        {
            AFP = Salario * 0.0725m;
            //AFP = decimal.Round(AFP,2);
            return AFP;
        }

        public decimal CalcularRenta() 
        {
            SalarioMenosISSYAFP = ObtenerSalarioMenosISSYAFP();
           // SalarioMenosISSYAFP = Salario - Salario * 0.03m - Salario * 0.0725M;

			if (SalarioMenosISSYAFP >= 472.01m & SalarioMenosISSYAFP <= 895.24m)
            {
                Renta = ((SalarioMenosISSYAFP- 472.0m )* 0.10m)+17.67m;
            }
            else if(SalarioMenosISSYAFP >= 895.25m & SalarioMenosISSYAFP <= 2038.10m)
            {
				Renta = ((SalarioMenosISSYAFP - 895.24m) * 0.20m) + 60m;
			}
            else if ( SalarioMenosISSYAFP >= 2038.11m )
            {
				Renta = ((SalarioMenosISSYAFP - 2038.11m) * 0.30m) + 288.57m;
			}
            Renta = decimal.Round(Renta,2);
            return Renta;
   
        }

    }



}
