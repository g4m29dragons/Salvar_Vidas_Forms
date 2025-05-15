using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPS_Salvar_Vidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ControlBox = false; // Esto debería desactivar el botón de cerrar
            this.StartPosition = FormStartPosition.CenterScreen; // Centra el formulario

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTCAPTION = 0x02;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            // Bloquear el movimiento del formulario
            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION; // Evita mover el formulario
                return;
            }

            // Bloquear el movimiento por el mouse y teclado
            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MOVE)
            {
                return; // No permitir mover
            }

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Deshabilita el campo de contraseña y el botón de ingresar al inicio
            TextBox_Contasena.Enabled = true;
            bto_Ingresar.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Habilita el campo de contraseña y el botón de ingresar
            TextBox_Contasena.Enabled = true;
            bto_Ingresar.Enabled = true;
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje con la información del curso y el estudiante
            MessageBox.Show("Estructura de Datos\nNombre: Jesus Augusto Chacon Corredor\nGrupo: 08", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bto_Ingresar_Click(object sender, EventArgs e)
        {
            if (TextBox_Contasena.Text == "unad")
            {
                var formData = new FormularioDatos();
                formData.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bto_Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
