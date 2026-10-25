using System;
using System.Windows.Forms;

namespace posta__01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        // ── Botón SALIR ──────────────────────────────────────────────
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ── Botón INGRESAR ───────────────────────────────────────────
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un usuario
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Por favor seleccione un usuario.",
                    "Usuario requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string usuario = comboBox1.SelectedItem?.ToString()?.Trim() ?? "";
            string contrasena = textBox1.Text.Trim();

            // Contraseñas: Paciente → 321 | Topico → 123 | Doctor → 123
            bool esDoctor = string.Equals(usuario, "Doctor", StringComparison.OrdinalIgnoreCase);
            bool esTopico = string.Equals(usuario, "Topico", StringComparison.OrdinalIgnoreCase);
            bool esPaciente = string.Equals(usuario, "Paciente", StringComparison.OrdinalIgnoreCase);

            string claveEsperada = esPaciente ? "321" : "123";

            if (contrasena != claveEsperada)
            {
                MessageBox.Show(
                    "Contraseña incorrecta. Intente nuevamente.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            // Contraseña correcta → navegar al formulario correspondiente
            textBox1.Clear();

            if (esPaciente)
            {
                Paciente_Cita frmPaciente = new Paciente_Cita();
                frmPaciente.FormClosed += (s, args) => {
                    this.Show();
                    this.textBox1.Clear();
                };
                frmPaciente.Show();
                this.Hide();
            }
            else if (esTopico)
            {
                Topio frmTopio = new Topio();
                frmTopio.FormClosed += (s, args) => {
                    this.Show();
                    this.textBox1.Clear();
                };
                frmTopio.Show();
                this.Hide();
            }
            else if (esDoctor)
            {
                Doctor frmDoctor = new Doctor();
                frmDoctor.FormClosed += (s, args) => {
                    this.Show();
                    this.textBox1.Clear();
                };
                frmDoctor.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
