namespace posta__01
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlCard = new Panel();
            label3 = new Label();
            lblTitulo = new Label();
            lblUsuario = new Label();
            comboBox1 = new ComboBox();
            lblContrase = new Label();
            textBox1 = new TextBox();
            BtnIngresar = new Button();
            btnSalir = new Button();
            lblPista = new Label();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(label3);
            pnlCard.Controls.Add(lblTitulo);
            pnlCard.Controls.Add(lblUsuario);
            pnlCard.Controls.Add(comboBox1);
            pnlCard.Controls.Add(lblContrase);
            pnlCard.Controls.Add(textBox1);
            pnlCard.Controls.Add(BtnIngresar);
            pnlCard.Controls.Add(btnSalir);
            pnlCard.Controls.Add(lblPista);
            pnlCard.Location = new Point(80, 45);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(440, 360);
            pnlCard.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(26, 82, 118);
            label3.Location = new Point(135, 20);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 0;
            label3.Text = "POSTA MÉDICA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9.5F);
            lblTitulo.ForeColor = Color.FromArgb(127, 140, 141);
            lblTitulo.Location = new Point(130, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 17);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Control y Gestión de Citas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += label3_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(52, 73, 94);
            lblUsuario.Location = new Point(50, 105);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "USUARIO :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9.5F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Paciente", "Topico", "Doctor" });
            comboBox1.Location = new Point(155, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 25);
            comboBox1.TabIndex = 3;
            // 
            // lblContrase
            // 
            lblContrase.AutoSize = true;
            lblContrase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContrase.ForeColor = Color.FromArgb(52, 73, 94);
            lblContrase.Location = new Point(50, 155);
            lblContrase.Name = "lblContrase";
            lblContrase.Size = new Size(92, 15);
            lblContrase.TabIndex = 4;
            lblContrase.Text = "CONTRASEÑA :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(155, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 24);
            textBox1.TabIndex = 5;
            textBox1.UseSystemPasswordChar = true;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(41, 128, 185);
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(80, 225);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(130, 36);
            BtnIngresar.TabIndex = 6;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 57, 43);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(230, 225);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 36);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblPista
            // 
            lblPista.AutoSize = true;
            lblPista.Font = new Font("Segoe UI", 8F);
            lblPista.ForeColor = Color.FromArgb(149, 165, 166);
            lblPista.Location = new Point(70, 295);
            lblPista.Name = "lblPista";
            lblPista.Size = new Size(300, 13);
            lblPista.TabIndex = 8;
            lblPista.Text = "Claves: Paciente (321)  |  Tópico (123)  |  Doctor (123)";
            lblPista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AcceptButton = BtnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            CancelButton = btnSalir;
            ClientSize = new Size(600, 460);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posta Médica - Inicio de Sesión";
            Load += Login_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private ComboBox comboBox1;
        private Label lblContrase;
        private Label lblTitulo;
        private Button btnSalir;
        private Button BtnIngresar;
        private TextBox textBox1;
        private Label label3;
        private Label lblUsuario;
        private Label lblPista;
    }
}
