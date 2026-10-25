namespace posta__01
{
    partial class Doctor
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
            pnlBusqueda = new Panel();
            lblBuscarDNI = new Label();
            txtBuscarDNI = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            lblPacienteActivo = new Label();
            pnlDatos = new Panel();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            lblMedicamento = new Label();
            txtMedicamento = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            lblTotalRegistros = new Label();
            dgvCita = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
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
            pnlHeader.Size = new Size(1100, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitulo
            // 
            lblHeaderTitulo.AutoSize = true;
            lblHeaderTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitulo.ForeColor = Color.White;
            lblHeaderTitulo.Location = new Point(15, 8);
            lblHeaderTitulo.Name = "lblHeaderTitulo";
            lblHeaderTitulo.Size = new Size(470, 25);
            lblHeaderTitulo.TabIndex = 0;
            lblHeaderTitulo.Text = "POSTA MÉDICA - MÓDULO DE CONSULTA MÉDICA";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 8.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(208, 236, 231);
            lblHeaderSub.Location = new Point(18, 34);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(430, 15);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Evaluación médica, diagnóstico clínico y emisión de receta médica";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.White;
            pnlBusqueda.BorderStyle = BorderStyle.FixedSingle;
            pnlBusqueda.Controls.Add(lblBuscarDNI);
            pnlBusqueda.Controls.Add(txtBuscarDNI);
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(lblPacienteActivo);
            pnlBusqueda.Location = new Point(15, 70);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1070, 48);
            pnlBusqueda.TabIndex = 1;
            // 
            // lblBuscarDNI
            // 
            lblBuscarDNI.AutoSize = true;
            lblBuscarDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscarDNI.ForeColor = Color.FromArgb(44, 62, 80);
            lblBuscarDNI.Location = new Point(10, 15);
            lblBuscarDNI.Name = "lblBuscarDNI";
            lblBuscarDNI.Size = new Size(111, 15);
            lblBuscarDNI.TabIndex = 0;
            lblBuscarDNI.Text = "BUSCAR POR DNI :";
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Font = new Font("Segoe UI", 9F);
            txtBuscarDNI.Location = new Point(125, 12);
            txtBuscarDNI.MaxLength = 8;
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.PlaceholderText = "Escriba DNI...";
            txtBuscarDNI.Size = new Size(110, 23);
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
            btnBuscar.Location = new Point(245, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 152, 219);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(325, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 27);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblPacienteActivo
            // 
            lblPacienteActivo.AutoSize = true;
            lblPacienteActivo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPacienteActivo.ForeColor = Color.FromArgb(39, 174, 96);
            lblPacienteActivo.Location = new Point(415, 15);
            lblPacienteActivo.Name = "lblPacienteActivo";
            lblPacienteActivo.Size = new Size(400, 17);
            lblPacienteActivo.TabIndex = 4;
            lblPacienteActivo.Text = "Paciente: Ninguno seleccionado (busque o haga clic en la lista)";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(lblDiagnostico);
            pnlDatos.Controls.Add(txtDiagnostico);
            pnlDatos.Controls.Add(lblMedicamento);
            pnlDatos.Controls.Add(txtMedicamento);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnSalir);
            pnlDatos.Location = new Point(15, 126);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1070, 100);
            pnlDatos.TabIndex = 2;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiagnostico.Location = new Point(15, 18);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(97, 15);
            lblDiagnostico.TabIndex = 0;
            lblDiagnostico.Text = "DIAGNÓSTICO :";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Font = new Font("Segoe UI", 9F);
            txtDiagnostico.Location = new Point(125, 15);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.PlaceholderText = "Ingrese el diagnóstico clínico...";
            txtDiagnostico.Size = new Size(380, 23);
            txtDiagnostico.TabIndex = 1;
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMedicamento.Location = new Point(525, 18);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(103, 15);
            lblMedicamento.TabIndex = 2;
            lblMedicamento.Text = "MEDICAMENTO :";
            // 
            // txtMedicamento
            // 
            txtMedicamento.Font = new Font("Segoe UI", 9F);
            txtMedicamento.Location = new Point(635, 15);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.PlaceholderText = "Ingrese receta y posología...";
            txtMedicamento.Size = new Size(410, 23);
            txtMedicamento.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(125, 52);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 34);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 57, 43);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(270, 52);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 34);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalRegistros.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalRegistros.Location = new Point(15, 235);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(135, 15);
            lblTotalRegistros.TabIndex = 3;
            lblTotalRegistros.Text = "Total de pacientes: 0";
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
            dgvCita.Location = new Point(15, 255);
            dgvCita.MultiSelect = false;
            dgvCita.Name = "dgvCita";
            dgvCita.ReadOnly = true;
            dgvCita.RowHeadersVisible = false;
            dgvCita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCita.Size = new Size(1070, 270);
            dgvCita.TabIndex = 4;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1100, 545);
            Controls.Add(dgvCita);
            Controls.Add(lblTotalRegistros);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posta Médica - Módulo de Atención Médica";
            Load += Doctor_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitulo;
        private Label lblHeaderSub;
        private Panel pnlBusqueda;
        private Label lblBuscarDNI;
        private TextBox txtBuscarDNI;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Label lblPacienteActivo;
        private Panel pnlDatos;
        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private Label lblMedicamento;
        private TextBox txtMedicamento;
        private Button btnGuardar;
        private Button btnSalir;
        private Label lblTotalRegistros;
        private DataGridView dgvCita;
    }
}
