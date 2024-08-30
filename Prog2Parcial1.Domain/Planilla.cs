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
            SalarioMenosISSYAFP = ObtenerSalarioMenosISSYAFP();

            if (SalarioMenosISSYAFP >= 472.1m & SalarioMenosISSYAFP <= 895.24m)
            {
                Renta = ((SalarioMenosISSYAFP- 472.1m )* 0.10m)+17.67m;
            }
            else if(SalarioMenosISSYAFP >= 895.24m & SalarioMenosISSYAFP <= 2038.10m)
            {
                Renta = SalarioMenosISSYAFP * 0.20m;
            }
            else if ( SalarioMenosISSYAFP >= 2038.10m )
            {
                Renta = SalarioMenosISSYAFP * 0.30m;
            }

            return Renta;
   
        }

    }



}
