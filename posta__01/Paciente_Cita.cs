using System;
using System.Drawing;
using System.Windows.Forms;

namespace posta__01
{
    public partial class Paciente_Cita : Form
    {
        public Paciente_Cita()
        {
            InitializeComponent();

            // ── Restricción de tipos de dato en tiempo real ──────────
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtApellido.KeyPress += SoloLetras_KeyPress;
            txtDni.KeyPress += SoloDigitos_KeyPress;
            txtBuscarDNI.KeyPress += SoloDigitos_KeyPress;

            // ── Búsqueda reactiva mientras se escribe el DNI ──────────
            txtBuscarDNI.TextChanged += TxtBuscarDNI_TextChanged;

            // ── Cálculo dinámico de costo al seleccionar SIS ─────────
            cmbSis.SelectedIndexChanged += CmbSis_SelectedIndexChanged;

            // ── Restringir citas pasadas ─────────────────────────────
            dtpFecha.MinDate = DateTime.Today;
        }

        private void Paciente_Cita_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        // ════════════════════════════════════════════════════════════
        //  Validaciones de teclado (KeyPress estricto)
        // ════════════════════════════════════════════════════════════

        private void SoloLetras_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void SoloDigitos_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // ════════════════════════════════════════════════════════════
        //  Cálculo visual en tiempo real del costo según SIS
        // ════════════════════════════════════════════════════════════

        private void CmbSis_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string sis = cmbSis.SelectedItem?.ToString() ?? "";
            if (sis == "SI")
            {
                lblCostoInfo.Text = "Costo: S/. 0.00 (Gratuito por SIS)";
                lblCostoInfo.ForeColor = Color.FromArgb(39, 174, 96);
            }
            else if (sis == "NO")
            {
                lblCostoInfo.Text = "Costo: S/. 20.00 (Consulta Particular)";
                lblCostoInfo.ForeColor = Color.FromArgb(41, 128, 185);
            }
            else
            {
                lblCostoInfo.Text = "Costo: S/. --";
                lblCostoInfo.ForeColor = Color.FromArgb(127, 140, 141);
            }
        }

        // ════════════════════════════════════════════════════════════
        //  Búsqueda en tiempo real mientras se escribe el DNI
        // ════════════════════════════════════════════════════════════

        private void TxtBuscarDNI_TextChanged(object? sender, EventArgs e)
        {
            string filtro = txtBuscarDNI.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                CargarDgv();
                return;
            }

            dgvCita.Rows.Clear();
            ConfigurarColumnas();

            foreach (var r in DatosClinica.Citas)
            {
                if (r.DNI.StartsWith(filtro, StringComparison.OrdinalIgnoreCase))
                {
                    AgregarFila(r);
                }
            }

            lblTotalRegistros.Text = $"Total de citas encontradas: {dgvCita.Rows.Count}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text.Trim();
            if (dni.Length == 0)
            {
                MessageBox.Show("Ingrese un DNI para filtrar la lista.", "Campo vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarDNI.Focus();
                return;
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtBuscarDNI.Clear(); // Dispara TextChanged y recarga todas las citas
        }

        // ════════════════════════════════════════════════════════════
        //  DataGridView
        // ════════════════════════════════════════════════════════════

        private void ConfigurarColumnas()
        {
            dgvCita.Columns.Clear();
            dgvCita.Columns.Add("Nombre", "Nombre");
            dgvCita.Columns.Add("Apellido", "Apellido");
            dgvCita.Columns.Add("DNI", "DNI");
            dgvCita.Columns.Add("SIS", "SIS");
            dgvCita.Columns.Add("Especialidad", "Especialidad");
            dgvCita.Columns.Add("Fecha", "Fecha");
            dgvCita.Columns.Add("Hora", "Hora");
            dgvCita.Columns.Add("Costo", "Costo");
        }

        private void CargarDgv()
        {
            dgvCita.Rows.Clear();
            ConfigurarColumnas();

            foreach (var r in DatosClinica.Citas)
                AgregarFila(r);

            lblTotalRegistros.Text = $"Total de citas: {dgvCita.Rows.Count}";
        }

        private void AgregarFila(RegistroCita r)
        {
            dgvCita.Rows.Add(
                r.Nombre, r.Apellido, r.DNI, r.SIS,
                r.Especialidad, r.Fecha, r.Hora, r.Costo);
        }

        // ════════════════════════════════════════════════════════════
        //  Botón GUARDAR CITA
        // ════════════════════════════════════════════════════════════

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Alerta("Por favor ingrese el nombre del paciente.", txtNombre);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                Alerta("Por favor ingrese el apellido del paciente.", txtApellido);
                return;
            }

            string dni = txtDni.Text.Trim();
            if (dni.Length != 8)
            {
                Alerta("El DNI debe tener exactamente 8 dígitos numéricos.", txtDni);
                return;
            }

            // Validar que el DNI no esté duplicado
            bool yaExiste = DatosClinica.Citas.Exists(r => r.DNI == dni);
            if (yaExiste)
            {
                DialogResult re = MessageBox.Show(
                    $"Ya existe un registro con el DNI {dni}.\n¿Desea registrar una nueva cita para este paciente?",
                    "Paciente existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re != DialogResult.Yes)
                    return;
            }

            if (cmbSis.SelectedIndex < 0)
            {
                Alerta("Seleccione si el paciente cuenta con SIS (SI / NO).", cmbSis);
                return;
            }

            if (cmbEspecialidad.SelectedIndex < 0)
            {
                Alerta("Seleccione la especialidad médica.", cmbEspecialidad);
                return;
            }

            string sis = cmbSis.SelectedItem?.ToString() ?? "NO";
            string costo = sis == "SI" ? "S/. 0.00" : "S/. 20.00";

            var registro = new RegistroCita
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                DNI = dni,
                SIS = sis,
                Especialidad = cmbEspecialidad.SelectedItem?.ToString() ?? "",
                Fecha = dtpFecha.Value.ToShortDateString(),
                Hora = dtpHora.Value.ToString("HH:mm"),
                Costo = costo
            };

            DatosClinica.Citas.Add(registro);
            CargarDgv();

            MessageBox.Show(
                $"Cita registrada con éxito para {registro.Nombre} {registro.Apellido}.\n" +
                $"Especialidad: {registro.Especialidad}\n" +
                $"Costo de consulta: {costo}",
                "Cita Agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLimpiar_Click(sender, e);
        }

        // ════════════════════════════════════════════════════════════
        //  Botón LIMPIAR CAMPOS
        // ════════════════════════════════════════════════════════════

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            cmbSis.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;
            lblCostoInfo.Text = "Costo: S/. --";
            lblCostoInfo.ForeColor = Color.FromArgb(127, 140, 141);
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
            txtNombre.Focus();
        }

        // ════════════════════════════════════════════════════════════
        //  Botón REGRESAR
        // ════════════════════════════════════════════════════════════

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void Alerta(string msg, Control ctrl)
        {
            MessageBox.Show(msg, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ctrl.Focus();
        }
    }
}
