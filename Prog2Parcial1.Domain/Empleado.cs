using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1.Domain
{
	public  class Empleado
	{

		public string Nombre { get; set; }

		public string Apellido { get; set; }

		public string Area { get; set; }

		public string DUI {  get; set; }

		public decimal Salario { get; set; }

        public Empleado()
        {
				
        }


        public Empleado( string nombre, string apellido, string area, string dui, decimal salario )
        {
			Nombre = nombre;
			Apellido = apellido;
			Area = area;
			Dui = dui;
			Salario = salario;
        }
    }
}
