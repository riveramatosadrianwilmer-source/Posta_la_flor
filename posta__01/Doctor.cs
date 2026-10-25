using System;
using System.Drawing;
using System.Windows.Forms;

namespace posta__01
{
    public partial class Doctor : Form
    {
        // Registro seleccionado por búsqueda DNI o clic en la grilla
        private RegistroCita? _registroSeleccionado = null;

        public Doctor()
        {
            InitializeComponent();

            // DNI búsqueda: solo dígitos
            txtBuscarDNI.KeyPress += SoloDigitos_KeyPress;

            // Búsqueda en tiempo real mientras se escribe
            txtBuscarDNI.TextChanged += TxtBuscarDNI_TextChanged;

            // Selección al hacer clic en una fila de la grilla
            dgvCita.CellClick += DgvCita_CellClick;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void SoloDigitos_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // ════════════════════════════════════════════════════════════
        //  Búsqueda en tiempo real mientras se escribe el DNI
        // ════════════════════════════════════════════════════════════

        private void TxtBuscarDNI_TextChanged(object? sender, EventArgs e)
        {
            string filtro = txtBuscarDNI.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                // Si el campo está vacío, restaurar TODOS los registros
                CargarDgv();
                return;
            }

            // Filtrar grilla por coincidencia
            dgvCita.Rows.Clear();
            ConfigurarColumnas();

            RegistroCita? coincidenciaExacta = null;

            foreach (var r in DatosClinica.Citas)
            {
                if (r.DNI.StartsWith(filtro, StringComparison.OrdinalIgnoreCase))
                {
                    AgregarFila(r);
                    if (r.DNI == filtro)
                        coincidenciaExacta = r;
                }
            }

            lblTotalRegistros.Text = $"Total de pacientes encontrados: {dgvCita.Rows.Count}";

            if (coincidenciaExacta != null)
            {
                SeleccionarPaciente(coincidenciaExacta);
            }
            else
            {
                _registroSeleccionado = null;
                lblPacienteActivo.Text = $"Buscando DNI: {filtro}... ({dgvCita.Rows.Count} coincidencia(s))";
                lblPacienteActivo.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarDNI.Text.Trim();
            if (dni.Length == 0)
            {
                MessageBox.Show("Ingrese un DNI para buscar.", "Campo vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarDNI.Focus();
                return;
            }

            RegistroCita? encontrado = DatosClinica.Citas.Find(r => r.DNI == dni);

            if (encontrado == null)
            {
                MessageBox.Show($"No se encontró ningún paciente con DNI: {dni}",
                    "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SeleccionarPaciente(encontrado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarDNI.Clear(); // Dispara TextChanged y recarga todos los registros
            txtDiagnostico.Clear();
            txtMedicamento.Clear();
            _registroSeleccionado = null;
            lblPacienteActivo.Text = "Paciente: Ninguno seleccionado (busque o haga clic en la lista)";
            lblPacienteActivo.ForeColor = Color.FromArgb(127, 140, 141);
        }

        private void SeleccionarPaciente(RegistroCita r)
        {
            _registroSeleccionado = r;
            lblPacienteActivo.Text = $"Paciente activo: {r.Nombre} {r.Apellido} (DNI: {r.DNI}) - Especialidad: {r.Especialidad}";
            lblPacienteActivo.ForeColor = Color.FromArgb(39, 174, 96);

            // Cargar diagnóstico y medicamento previos si existen
            txtDiagnostico.Text = r.Diagnostico;
            txtMedicamento.Text = r.Medicamento;
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
            dgvCita.Columns.Add("Peso", "Peso (kg)");
            dgvCita.Columns.Add("Talla", "Talla (m)");
            dgvCita.Columns.Add("IMC", "IMC");
            dgvCita.Columns.Add("Temperatura", "Temp. (°C)");
            dgvCita.Columns.Add("ClasTemp", "Clasif. Temp.");
            dgvCita.Columns.Add("Presion", "Presión");
            dgvCita.Columns.Add("ClasPresion", "Clasif. Presión");
            dgvCita.Columns.Add("Diagnostico", "Diagnóstico");
            dgvCita.Columns.Add("Medicamento", "Medicamento");
        }

        private void CargarDgv()
        {
            dgvCita.Rows.Clear();
            ConfigurarColumnas();

            foreach (var r in DatosClinica.Citas)
                AgregarFila(r);

            lblTotalRegistros.Text = $"Total de pacientes: {dgvCita.Rows.Count}";
        }

        private void AgregarFila(RegistroCita r)
        {
            dgvCita.Rows.Add(
                r.Nombre, r.Apellido, r.DNI, r.SIS, r.Especialidad,
                r.Fecha, r.Hora, r.Costo,
                r.Peso, r.Talla, r.IMC, r.Temperatura, r.ClasificacionTemp,
                r.Presion, r.ClasificacionPresion,
                r.Diagnostico, r.Medicamento);
        }

        private void DgvCita_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCita.Rows.Count)
            {
                var fila = dgvCita.Rows[e.RowIndex];
                string? dni = fila.Cells["DNI"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(dni))
                {
                    txtBuscarDNI.Text = dni;
                    var encontrado = DatosClinica.Citas.Find(r => r.DNI == dni);
                    if (encontrado != null)
                        SeleccionarPaciente(encontrado);
                }
            }
        }

        // ════════════════════════════════════════════════════════════
        //  Botón GUARDAR
        // ════════════════════════════════════════════════════════════

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_registroSeleccionado == null)
            {
                MessageBox.Show(
                    "Primero busque al paciente por su DNI o selecciónelo de la lista.",
                    "Sin paciente seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarDNI.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiagnostico.Text))
            {
                Alerta("Ingrese el diagnóstico del paciente.", txtDiagnostico);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMedicamento.Text))
            {
                Alerta("Ingrese el medicamento o receta para el paciente.", txtMedicamento);
                return;
            }

            _registroSeleccionado.Diagnostico = txtDiagnostico.Text.Trim();
            _registroSeleccionado.Medicamento = txtMedicamento.Text.Trim();

            CargarDgv();

            MessageBox.Show(
                $"Consulta médica guardada correctamente para {_registroSeleccionado.Nombre} {_registroSeleccionado.Apellido}.",
                "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDiagnostico.Clear();
            txtMedicamento.Clear();
            _registroSeleccionado = null;
            lblPacienteActivo.Text = "Paciente: Ninguno seleccionado (busque o haga clic en la lista)";
            lblPacienteActivo.ForeColor = Color.FromArgb(127, 140, 141);
        }

        // ════════════════════════════════════════════════════════════
        //  Botón SALIR
        // ════════════════════════════════════════════════════════════

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "¿Está seguro de que desea salir del módulo médico?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private static void Alerta(string msg, Control ctrl)
        {
            MessageBox.Show(msg, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ctrl.Focus();
        }
    }
}
