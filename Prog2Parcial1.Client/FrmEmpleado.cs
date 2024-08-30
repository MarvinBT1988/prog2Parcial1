using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Prog2Parcial1.Domain;

namespace Prog2Parcial1.Client
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text=string.Empty;
            txtApellido.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtDUI.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtISSS.Text = string.Empty;
            txtAFP.Text = string.Empty;
            txtDUI.Text= string.Empty;
        }
        private Empleado ObtenerEmpleado() {
            Empleado empleado = new Empleado();
            empleado.Nombre=txtNombre.Text;
            empleado.Apellido=txtApellido.Text;
            empleado.Area=txtArea.Text;
            empleado.DUI=txtDUI.Text;
            empleado.Salario = decimal.Parse(txtSalario.Text);
            return empleado;
        }
        private void MostrarInformacion(Planilla planilla)
        {
            txtAFP.Text = planilla.CalcularAFP().ToString();
            txtISSS.Text = planilla.CalcularISSS().ToString();
            txtRenta.Text = planilla.CalcularRenta().ToString();
        }
        private void btnCalcularPlanilla_Click(object sender, EventArgs e)
        {
            Empleado empleado=ObtenerEmpleado();
            Planilla planilla=new Planilla(empleado.Salario);
            MostrarInformacion(planilla);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, un punto decimal y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || txtSalario.Text.Contains(".")))
            {
                e.Handled = true; // Bloquear el ingreso de otros caracteres
            }
        }
    }
}
