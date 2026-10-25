using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace posta__01
{
    public partial class Topio : Form
    {
        // Registro seleccionado por búsqueda DNI o clic en grilla
        private RegistroCita? _registroSeleccionado = null;

        public Topio()
        {
            InitializeComponent();

            // ── Restricciones de tipo de dato ────────────────────────
            txtBuscarDNI.KeyPress += SoloDigitos_KeyPress;
            txtTalla.KeyPress += SoloDecimal_KeyPress;
            txtPeso.KeyPress += SoloDecimal_KeyPress;
            txtTenperatura.KeyPress += SoloDecimal_KeyPress;
            txtPresion.KeyPress += PresionKeyPress;

            // ── Búsqueda reactiva mientras se escribe ─────────────────
            txtBuscarDNI.TextChanged += TxtBuscarDNI_TextChanged;

            // ── Clasificación clínica en tiempo real al salir del campo
            txtTenperatura.Leave += TxtTenperatura_Leave;
            txtPresion.Leave += TxtPresion_Leave;
            txtTalla.Leave += CalcularIMC_Leave;
            txtPeso.Leave += CalcularIMC_Leave;

            // ── Selección al hacer clic en una fila de la grilla ─────
            dgvCita.CellClick += DgvCita_CellClick;
        }

        private void Topio_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        // ════════════════════════════════════════════════════════════
        //  Validación de teclas (KeyPress estricto)
        // ════════════════════════════════════════════════════════════

        private void SoloDigitos_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void SoloDecimal_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '.' && (tb == null || !tb.Text.Contains('.')))
                    return; // permitir un solo punto decimal
                e.Handled = true;
            }
        }

        private void PresionKeyPress(object? sender, KeyPressEventArgs e)
        {
            var tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '/' && (tb == null || !tb.Text.Contains('/')))
                    return; // permitir una sola barra (120/80)
                e.Handled = true;
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
                // Si el campo está vacío, restaurar TODOS los registros
                CargarDgv();
                return;
            }

            // Filtrar grilla en tiempo real por coincidencia
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
            LimpiarCampos();
            _registroSeleccionado = null;
            lblPacienteActivo.Text = "Paciente: Ninguno seleccionado (busque o haga clic en la lista)";
            lblPacienteActivo.ForeColor = Color.FromArgb(127, 140, 141);
        }

        private void SeleccionarPaciente(RegistroCita r)
        {
            _registroSeleccionado = r;
            lblPacienteActivo.Text = $"Paciente activo: {r.Nombre} {r.Apellido} (DNI: {r.DNI})";
            lblPacienteActivo.ForeColor = Color.FromArgb(39, 174, 96);

            // Cargar datos previos si existen
            txtTalla.Text = r.Talla;
            txtPeso.Text = r.Peso;
            txtPresion.Text = r.Presion;
            txtTenperatura.Text = r.Temperatura;
            lblClasTemp.Text = r.ClasificacionTemp;
            lblClasPresion.Text = r.ClasificacionPresion;
            lblIMC.Text = string.IsNullOrEmpty(r.IMC) ? "IMC: --" : $"IMC: {r.IMC}";
        }

        // ════════════════════════════════════════════════════════════
        //  Cálculo de IMC (Índice de Masa Corporal)
        // ════════════════════════════════════════════════════════════

        private void CalcularIMC_Leave(object? sender, EventArgs e)
        {
            if (double.TryParse(txtTalla.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double talla) &&
                double.TryParse(txtPeso.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double peso) &&
                talla > 0)
            {
                double imc = peso / (talla * talla);
                var (clasif, color) = ClasificarIMC(imc);
                lblIMC.Text = $"IMC: {imc:F1} ({clasif})";
                lblIMC.ForeColor = color;
            }
            else
            {
                lblIMC.Text = "IMC: --";
                lblIMC.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private static (string texto, Color color) ClasificarIMC(double imc)
        {
            if (imc < 18.5) return ("Bajo peso", Color.FromArgb(41, 128, 185));
            if (imc < 25.0) return ("Normal", Color.FromArgb(39, 174, 96));
            if (imc < 30.0) return ("Sobrepeso", Color.FromArgb(230, 126, 34));
            return ("Obesidad", Color.FromArgb(192, 57, 43));
        }

        // ════════════════════════════════════════════════════════════
        //  Clasificaciones clínicas (Temperatura y Presión)
        // ════════════════════════════════════════════════════════════

        private void TxtTenperatura_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenperatura.Text)) { lblClasTemp.Text = ""; return; }
            if (double.TryParse(txtTenperatura.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double temp))
            {
                var (texto, color) = ClasificarTemperatura(temp);
                lblClasTemp.Text = texto;
                lblClasTemp.ForeColor = color;
            }
            else
            {
                lblClasTemp.Text = "Valor inválido";
                lblClasTemp.ForeColor = Color.Red;
            }
        }

        private void TxtPresion_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPresion.Text)) { lblClasPresion.Text = ""; return; }
            var partes = txtPresion.Text.Split('/');
            if (partes.Length == 2 &&
                int.TryParse(partes[0].Trim(), out int sistolica) &&
                int.TryParse(partes[1].Trim(), out int diastolica))
            {
                if (sistolica < diastolica)
                {
                    lblClasPresion.Text = "El número mayor va primero (ej: 120/80)";
                    lblClasPresion.ForeColor = Color.DarkOrange;
                    return;
                }

                var (texto, color) = ClasificarPresion(sistolica, diastolica);
                lblClasPresion.Text = texto;
                lblClasPresion.ForeColor = color;
            }
            else
            {
                lblClasPresion.Text = "Formato inválido (use 120/80)";
                lblClasPresion.ForeColor = Color.Red;
            }
        }

        private static (string texto, Color color) ClasificarTemperatura(double temp)
        {
            if (temp < 35.0) return ("Hipotermia severa (< 35 °C)", Color.DarkBlue);
            if (temp < 36.0) return ("Hipotermia (35–36 °C)", Color.Blue);
            if (temp <= 37.4) return ("Normal (36–37.4 °C)", Color.Green);
            if (temp <= 37.9) return ("Febrícula (37.5–37.9 °C)", Color.Goldenrod);
            if (temp <= 38.9) return ("Fiebre moderada (38–38.9 °C)", Color.DarkOrange);
            if (temp <= 40.0) return ("Fiebre alta (39–40 °C)", Color.OrangeRed);
            return ("Hiperpirexia (> 40 °C) - URGENCIA", Color.Red);
        }

        private static (string texto, Color color) ClasificarPresion(int sistolica, int diastolica)
        {
            if (sistolica < 90 || diastolica < 60)
                return ("Hipotensión (< 90/60 mmHg)", Color.Blue);
            if (sistolica < 120 && diastolica < 80)
                return ("Normal (< 120/80 mmHg)", Color.Green);
            if (sistolica <= 129 && diastolica < 80)
                return ("Elevada (120-129 / < 80 mmHg)", Color.Goldenrod);
            if (sistolica <= 139 || diastolica <= 89)
                return ("Hipertensión Etapa 1 (130-139 / 80-89 mmHg)", Color.DarkOrange);
            if (sistolica <= 179 || diastolica <= 119)
                return ("Hipertensión Etapa 2 (140-179 / 90-119 mmHg)", Color.OrangeRed);
            return ("Crisis hipertensiva (>= 180 / >= 120) - URGENCIA", Color.Red);
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
                r.Peso, r.Talla, r.IMC, r.Temperatura,
                r.ClasificacionTemp, r.Presion, r.ClasificacionPresion);
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

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtTalla.Text))
            { Alerta("Ingrese la talla del paciente (ej: 1.68).", txtTalla); return; }

            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            { Alerta("Ingrese el peso del paciente (ej: 65.5).", txtPeso); return; }

            if (string.IsNullOrWhiteSpace(txtPresion.Text))
            { Alerta("Ingrese la presión arterial (ej: 120/80).", txtPresion); return; }

            if (string.IsNullOrWhiteSpace(txtTenperatura.Text))
            { Alerta("Ingrese la temperatura del paciente (ej: 36.8).", txtTenperatura); return; }

            // Validar formato de presión
            var partes = txtPresion.Text.Split('/');
            if (partes.Length != 2 ||
                !int.TryParse(partes[0].Trim(), out int sistolica) ||
                !int.TryParse(partes[1].Trim(), out int diastolica))
            {
                Alerta("La presión debe tener el formato 120/80 (sistólica/diastólica).", txtPresion);
                return;
            }

            if (sistolica < diastolica)
            {
                Alerta("En la presión arterial el número mayor (sistólica) va primero. Ejemplo correcto: 120/80.", txtPresion);
                return;
            }

            // Validar temperatura
            if (!double.TryParse(txtTenperatura.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double temp))
            {
                Alerta("Ingrese un valor numérico válido para la temperatura.", txtTenperatura);
                return;
            }

            // Validar y calcular IMC
            double imcValor = 0;
            string imcTexto = "";
            if (double.TryParse(txtTalla.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double talla) &&
                double.TryParse(txtPeso.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double peso) &&
                talla > 0)
            {
                imcValor = peso / (talla * talla);
                var (clasifIMC, _) = ClasificarIMC(imcValor);
                imcTexto = $"{imcValor:F1} ({clasifIMC})";
            }

            var (textoTemp, _) = ClasificarTemperatura(temp);
            var (textoPresion, _) = ClasificarPresion(sistolica, diastolica);

            // Actualizar datos en el paciente
            _registroSeleccionado.Talla = txtTalla.Text.Trim();
            _registroSeleccionado.Peso = txtPeso.Text.Trim();
            _registroSeleccionado.IMC = imcTexto;
            _registroSeleccionado.Presion = txtPresion.Text.Trim();
            _registroSeleccionado.Temperatura = txtTenperatura.Text.Trim();
            _registroSeleccionado.ClasificacionTemp = textoTemp;
            _registroSeleccionado.ClasificacionPresion = textoPresion;

            CargarDgv();

            MessageBox.Show(
                $"Datos de tópico guardados correctamente para {_registroSeleccionado.Nombre} {_registroSeleccionado.Apellido}.\n\n" +
                $"IMC: {imcTexto}\n" +
                $"Temperatura: {textoTemp}\n" +
                $"Presión: {textoPresion}",
                "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
            _registroSeleccionado = null;
            lblPacienteActivo.Text = "Paciente: Ninguno seleccionado (busque o haga clic en la lista)";
            lblPacienteActivo.ForeColor = Color.FromArgb(127, 140, 141);
        }

        private void LimpiarCampos()
        {
            txtTalla.Clear();
            txtPeso.Clear();
            txtPresion.Clear();
            txtTenperatura.Clear();
            lblClasTemp.Text = "";
            lblClasPresion.Text = "";
            lblIMC.Text = "IMC: --";
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
