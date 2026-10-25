namespace posta__01
{
    partial class Topio
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
            lblTalla = new Label();
            txtTalla = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblIMC = new Label();
            lblPresion = new Label();
            txtPresion = new TextBox();
            lblClasPresion = new Label();
            lblTenperatura = new Label();
            txtTenperatura = new TextBox();
            lblClasTemp = new Label();
            btnGuardar = new Button();
            btnRegresar = new Button();
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
            pnlHeader.Size = new Size(1060, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitulo
            // 
            lblHeaderTitulo.AutoSize = true;
            lblHeaderTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitulo.ForeColor = Color.White;
            lblHeaderTitulo.Location = new Point(15, 8);
            lblHeaderTitulo.Name = "lblHeaderTitulo";
            lblHeaderTitulo.Size = new Size(390, 25);
            lblHeaderTitulo.TabIndex = 0;
            lblHeaderTitulo.Text = "POSTA MÉDICA - MÓDULO DE TÓPICO / TRIAJE";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 8.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(208, 236, 231);
            lblHeaderSub.Location = new Point(18, 34);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(420, 15);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Toma de signos vitales (Talla, Peso, Presión, Temperatura) y clasificación clínica";
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
            pnlBusqueda.Size = new Size(1030, 48);
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
            lblPacienteActivo.Size = new Size(390, 17);
            lblPacienteActivo.TabIndex = 4;
            lblPacienteActivo.Text = "Paciente: Ninguno seleccionado (busque o haga clic en la lista)";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.White;
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(lblTalla);
            pnlDatos.Controls.Add(txtTalla);
            pnlDatos.Controls.Add(lblPeso);
            pnlDatos.Controls.Add(txtPeso);
            pnlDatos.Controls.Add(lblIMC);
            pnlDatos.Controls.Add(lblPresion);
            pnlDatos.Controls.Add(txtPresion);
            pnlDatos.Controls.Add(lblClasPresion);
            pnlDatos.Controls.Add(lblTenperatura);
            pnlDatos.Controls.Add(txtTenperatura);
            pnlDatos.Controls.Add(lblClasTemp);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnRegresar);
            pnlDatos.Location = new Point(15, 126);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1030, 135);
            pnlDatos.TabIndex = 2;
            // 
            // lblTalla
            // 
            lblTalla.AutoSize = true;
            lblTalla.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTalla.Location = new Point(15, 15);
            lblTalla.Name = "lblTalla";
            lblTalla.Size = new Size(72, 15);
            lblTalla.TabIndex = 0;
            lblTalla.Text = "TALLA (m) :";
            // 
            // txtTalla
            // 
            txtTalla.Font = new Font("Segoe UI", 9F);
            txtTalla.Location = new Point(110, 12);
            txtTalla.Name = "txtTalla";
            txtTalla.PlaceholderText = "Ej: 1.68";
            txtTalla.Size = new Size(90, 23);
            txtTalla.TabIndex = 1;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPeso.Location = new Point(220, 15);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(71, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "PESO (kg) :";
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 9F);
            txtPeso.Location = new Point(300, 12);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Ej: 65.5";
            txtPeso.Size = new Size(90, 23);
            txtPeso.TabIndex = 3;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIMC.ForeColor = Color.FromArgb(41, 128, 185);
            lblIMC.Location = new Point(410, 15);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(120, 15);
            lblIMC.TabIndex = 4;
            lblIMC.Text = "IMC: --";
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPresion.Location = new Point(15, 52);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(116, 15);
            lblPresion.TabIndex = 5;
            lblPresion.Text = "PRESIÓN (mmHg) :";
            // 
            // txtPresion
            // 
            txtPresion.Font = new Font("Segoe UI", 9F);
            txtPresion.Location = new Point(140, 49);
            txtPresion.Name = "txtPresion";
            txtPresion.PlaceholderText = "Ej: 120/80";
            txtPresion.Size = new Size(90, 23);
            txtPresion.TabIndex = 6;
            // 
            // lblClasPresion
            // 
            lblClasPresion.AutoSize = true;
            lblClasPresion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClasPresion.Location = new Point(240, 52);
            lblClasPresion.Name = "lblClasPresion";
            lblClasPresion.Size = new Size(0, 15);
            lblClasPresion.TabIndex = 7;
            // 
            // lblTenperatura
            // 
            lblTenperatura.AutoSize = true;
            lblTenperatura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenperatura.Location = new Point(540, 52);
            lblTenperatura.Name = "lblTenperatura";
            lblTenperatura.Size = new Size(123, 15);
            lblTenperatura.TabIndex = 8;
            lblTenperatura.Text = "TEMPERATURA (°C) :";
            // 
            // txtTenperatura
            // 
            txtTenperatura.Font = new Font("Segoe UI", 9F);
            txtTenperatura.Location = new Point(670, 49);
            txtTenperatura.Name = "txtTenperatura";
            txtTenperatura.PlaceholderText = "Ej: 36.8";
            txtTenperatura.Size = new Size(80, 23);
            txtTenperatura.TabIndex = 9;
            // 
            // lblClasTemp
            // 
            lblClasTemp.AutoSize = true;
            lblClasTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClasTemp.Location = new Point(760, 52);
            lblClasTemp.Name = "lblClasTemp";
            lblClasTemp.Size = new Size(0, 15);
            lblClasTemp.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(15, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 34);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(108, 117, 125);
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(160, 88);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(130, 34);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalRegistros.ForeColor = Color.FromArgb(52, 73, 94);
            lblTotalRegistros.Location = new Point(15, 270);
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
            dgvCita.Location = new Point(15, 290);
            dgvCita.MultiSelect = false;
            dgvCita.Name = "dgvCita";
            dgvCita.ReadOnly = true;
            dgvCita.RowHeadersVisible = false;
            dgvCita.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCita.Size = new Size(1030, 240);
            dgvCita.TabIndex = 4;
            // 
            // Topio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1060, 545);
            Controls.Add(dgvCita);
            Controls.Add(lblTotalRegistros);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Topio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posta Médica - Módulo de Tópico";
            Load += Topio_Load;
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
        private Label lblTalla;
        private TextBox txtTalla;
        private Label lblPeso;
        private TextBox txtPeso;
        private Label lblIMC;
        private Label lblPresion;
        private TextBox txtPresion;
        private Label lblClasPresion;
        private Label lblTenperatura;
        private TextBox txtTenperatura;
        private Label lblClasTemp;
        private Button btnGuardar;
        private Button btnRegresar;
        private Label lblTotalRegistros;
        private DataGridView dgvCita;
    }
}
