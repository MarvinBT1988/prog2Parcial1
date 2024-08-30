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

        private void btnCalcularPlanilla_Click(object sender, EventArgs e)
        {

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
