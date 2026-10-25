namespace posta__01
{
    partial class Paciente_Cita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderTitulo = new Label();
            lblHeaderSub = new Label();
            pnlFormulario = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblSis = new Label();
            cmbSis = new ComboBox();
            lblCostoInfo = new Label();
            lblEspecialidad = new Label();
            cmbEspecialidad = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblHora = new Label();
            dtpHora = new DateTimePicker();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            pnlBusqueda = new Panel();
            lblBuscarDNI = new Label();
            txtBuscarDNI = new TextBox();
            btnBuscar = new Button();
            btnLimpiarFiltro = new Button();
            lblTotalRegistros = new Label();
            dgvCita = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlFormulario.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCita).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(26, 82, 118);
            pnlHeader.Controls.Add(lblHeaderSub);
            pnlHeader.Controls.Add(lblHeaderTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitulo
            // 
            lblHeaderTitulo.AutoSize = true;
            lblHeaderTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitulo.ForeColor = Color.White;
            lblHeaderTitulo.Location = new Point(15, 8);
            lblHeaderTitulo.Name = "lblHeaderTitulo";
            lblHeaderTitulo.Size = new Size(420, 25);
            lblHeaderTitulo.TabIndex = 0;
            lblHeaderTitulo.Text = "POSTA MÉDICA - REGISTRO DE CITAS MÉDICAS";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 8.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(208, 236, 231);
            lblHeaderSub.Location = new Point(18, 34);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(460, 15);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Filiación de pacientes, verificación de SIS, especialidad médica y programación de fecha/hora";
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = Color.White;
            pnlFormulario.BorderStyle = BorderStyle.FixedSingle;
            pnlFormulario.Controls.Add(lblNombre);
            pnlFormulario.Controls.Add(txtNombre);
            pnlFormulario.Controls.Add(lblApellido);
            pnlFormulario.Controls.Add(txtApellido);
            pnlFormulario.Controls.Add(lblDni);
            pnlFormulario.Controls.Add(txtDni);
            pnlFormulario.Controls.Add(lblSis);
            pnlFormulario.Controls.Add(cmbSis);
            pnlFormulario.Controls.Add(lblCostoInfo);
            pnlFormulario.Controls.Add(lblEspecialidad);
            pnlFormulario.Controls.Add(cmbEspecialidad);
            pnlFormulario.Controls.Add(lblFecha);
            pnlFormulario.Controls.Add(dtpFecha);
            pnlFormulario.Controls.Add(lblHora);
            pnlFormulario.Controls.Add(dtpHora);
            pnlFormulario.Controls.Add(btnRegistrar);
            pnlFormulario.Controls.Add(btnLimpiar);
            pnlFormulario.Controls.Add(btnRegresar);
            pnlFormulario.Location = new Point(15, 70);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(970, 155);
            pnlFormulario.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(15, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE :";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(100, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Solo letras";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(280, 15);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "APELLIDO :";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.Location = new Point(365, 12);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Solo letras";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDni.Location = new Point(545, 15);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI :";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 9F);
            txtDni.Location = new Point(590, 12);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "8 dígitos";
            txtDni.Size = new Size(120, 23);
            txtDni.TabIndex = 5;
            // 
            // lblSis
            // 
            lblSis.AutoSize = true;
            lblSis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSis.Location = new Point(15, 52);
            lblSis.Name = "lblSis";
            lblSis.Size = new Size(31, 15);
            lblSis.TabIndex = 6;
            lblSis.Text = "SIS :";
            // 
            // cmbSis
            // 
            cmbSis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSis.Font = new Font("Segoe UI", 9F);
            cmbSis.FormattingEnabled = true;
            cmbSis.Items.AddRange(new object[] { "SI", "NO" });
            cmbSis.Location = new Point(100, 48);
            cmbSis.Name = "cmbSis";
            cmbSis.Size = new Size(80, 23);
            cmbSis.TabIndex = 7;
            // 
            // lblCostoInfo
            // 
            lblCostoInfo.AutoSize = true;
            lblCostoInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCostoInfo.ForeColor = Color.FromArgb(41, 128, 185);
            lblCostoInfo.Location = new Point(190, 52);
            lblCostoInfo.Name = "lblCostoInfo";
            lblCostoInfo.Size = new Size(120, 15);
            lblCostoInfo.TabIndex = 8;
            lblCostoInfo.Text = "Costo: S/. --";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecialidad.Location = new Point(440, 52);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(95, 15);
            lblEspecialidad.TabIndex = 9;
            lblEspecialidad.Text = "ESPECIALIDAD :";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Font = new Font("Segoe UI", 9F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "Medicina General", "Odontología", "Oftalmología", "Cardiología", "Pediatría", "Ginecología", "Dermatología", "Traumatología", "Neurología", "Psicología" });
            cmbEspecialidad.Location = new Point(545, 48);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(165, 23);
            cmbEspecialidad.TabIndex = 10;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(15, 88);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 15);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "FECHA :";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(100, 84);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(130, 23);
            dtpFecha.TabIndex = 12;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHora.Location = new Point(280, 88);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(48, 15);
            lblHora.TabIndex = 13;
            lblHora.Text = "HORA :";
            // 
            // dtpHora
            // 
            dtpHora.CustomFormat = "HH:mm";
            dtpHora.Font = new Font("Segoe UI", 9F);
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.Location = new Point(365, 84);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(110, 23);
            dtpHora.TabIndex = 14;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(39, 174, 96);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(780, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(160, 34);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "GUARDAR CITA";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 152, 219);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(780, 56);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 34);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "LIMPIAR CAMPOS";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(108, 117, 125);
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(780, 97);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(160, 34);
            btnRegresar.TabIndex = 17;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.White;
            pnlBusqueda.BorderStyle = BorderStyle.FixedSingle;
            pnlBusqueda.Controls.Add(lblBuscarDNI);
            pnlBusqueda.Controls.Add(txtBuscarDNI);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(btnLimpiarFiltro);
            pnlBusqueda.Controls.Add(lblTotalRegistros);
            pnlBusqueda.Location = new Point(15, 235);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(970, 44);
            pnlBusqueda.TabIndex = 2;
            // 
            // lblBuscarDNI
            // 
            lblBuscarDNI.AutoSize = true;
            lblBuscarDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscarDNI.ForeColor = Color.FromArgb(44, 62, 80);
            lblBuscarDNI.Location = new Point(10, 13);
            lblBuscarDNI.Name = "lblBuscarDNI";
            lblBuscarDNI.Size = new Size(111, 15);
            lblBuscarDNI.TabIndex = 0;
            lblBuscarDNI.Text = "BUSCAR POR DNI :";
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Font = new Font("Segoe UI", 9F);
            txtBuscarDNI.Location = new Point(125, 10);
            txtBuscarDNI.MaxLength = 8;
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.PlaceholderText = "Filtrar por DNI...";
            txtBuscarDNI.Size = new Size(130, 23);
            txtBuscarDNI.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(41, 128, 185);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(265, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarFiltro
            // 
            btnLimpiarFiltro.BackColor = Color.FromArgb(52, 152, 219);
            btnLimpiarFiltro.Cursor = Cursors.Hand;
            btnLimpiarFiltro.FlatAppearance.BorderSize = 0;
            btnLimpiarFiltro.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltro.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLimpiarFiltro.ForeColor = Color.White;
            btnLimpiarFiltro.Location = new Point(345, 8);
            btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            btnLimpiarFiltro.Size = new Size(75, 27);
            btnLimpiarFiltro.TabIndex = 3;
            btnLimpiarFiltro.Text = "VER TODOS";
            btnLimpiarFiltro.UseVisualStyleBackColor = false;
            btnLimpiarFiltro.Click += btnLimpiarFiltro_Click;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalRegistros.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalRegistros.Location = new Point(460, 13);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(110, 15);
            lblTotalRegistros.TabIndex = 4;
            lblTotalRegistros.Text = "Total de citas: 0";
            // 
            // dgvCita
            // 
            dgvCita.AllowUserToAddRows = false;
            dgvCita.AllowUserToDeleteRows = false;
            altRowStyle.BackColor = Color.FromArgb(245, 249, 253);
            dgvCita.AlternatingRowsDefaultCellStyle = altRowStyle;
            dgvCita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCita.BackgroundColor = Color.White;
            dgvCita.BorderStyle = BorderStyle.Fixed3D;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(41, 128, 185);
            headerStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = SystemColors.Highlight;
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;
            dgvCita.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvCita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCita.EnableHeadersVisualStyles = false;
            dgvCita.Location = new Point(15, 288);
            dgvCita.MultiSelect = false;
            dgvCita.Name = "dgvCita";
            dgvCita.ReadOnly = true;
            dgvCita.RowHeadersVisible = false;
            dgvCita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCita.Size = new Size(970, 240);
            dgvCita.TabIndex = 3;
            // 
            // Paciente_Cita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1000, 545);
            Controls.Add(dgvCita);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Paciente_Cita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posta Médica - Registro de Pacientes y Citas";
            Load += Paciente_Cita_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCita).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitulo;
        private Label lblHeaderSub;
        private Panel pnlFormulario;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblSis;
        private ComboBox cmbSis;
        private Label lblCostoInfo;
        private Label lblEspecialidad;
        private ComboBox cmbEspecialidad;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblHora;
        private DateTimePicker dtpHora;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Panel pnlBusqueda;
        private Label lblBuscarDNI;
        private TextBox txtBuscarDNI;
        private Button btnBuscar;
        private Button btnLimpiarFiltro;
        private Label lblTotalRegistros;
        private DataGridView dgvCita;
    }
}
