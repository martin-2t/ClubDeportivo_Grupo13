namespace ClubDeportivoNET80
{
    partial class frmRegistrarNoSocio
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
            chkAptoFisico = new CheckBox();
            lblAstNumDoc = new Label();
            txtNumDoc = new TextBox();
            lblNumDoc = new Label();
            lblAstTipoDoc = new Label();
            lblTipoDoc = new Label();
            cboTipoDoc = new ComboBox();
            lblAstApellido = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblAstEmail = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblAstTelefono = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblAstNombre = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblTitulo = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(727, 369);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(105, 24);
            chkAptoFisico.TabIndex = 39;
            chkAptoFisico.Text = "Apto Fisico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // lblAstNumDoc
            // 
            lblAstNumDoc.AutoSize = true;
            lblAstNumDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNumDoc.Location = new Point(841, 288);
            lblAstNumDoc.Name = "lblAstNumDoc";
            lblAstNumDoc.Size = new Size(20, 28);
            lblAstNumDoc.TabIndex = 38;
            lblAstNumDoc.Text = "*";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(653, 288);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(179, 27);
            txtNumDoc.TabIndex = 37;
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(649, 264);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(168, 20);
            lblNumDoc.TabIndex = 36;
            lblNumDoc.Text = "Número del documento";
            // 
            // lblAstTipoDoc
            // 
            lblAstTipoDoc.AutoSize = true;
            lblAstTipoDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstTipoDoc.Location = new Point(839, 189);
            lblAstTipoDoc.Name = "lblAstTipoDoc";
            lblAstTipoDoc.Size = new Size(20, 28);
            lblAstTipoDoc.TabIndex = 35;
            lblAstTipoDoc.Text = "*";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(650, 166);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(140, 20);
            lblTipoDoc.TabIndex = 34;
            lblTipoDoc.Text = "Tipo de documento";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Items.AddRange(new object[] { "DNI", "Pasaporte" });
            cboTipoDoc.Location = new Point(653, 190);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(179, 28);
            cboTipoDoc.TabIndex = 33;
            // 
            // lblAstApellido
            // 
            lblAstApellido.AutoSize = true;
            lblAstApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstApellido.Location = new Point(550, 191);
            lblAstApellido.Name = "lblAstApellido";
            lblAstApellido.Size = new Size(20, 28);
            lblAstApellido.TabIndex = 32;
            lblAstApellido.Text = "*";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(362, 191);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(179, 27);
            txtApellido.TabIndex = 31;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(358, 167);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 30;
            lblApellido.Text = "Apellido";
            // 
            // lblAstEmail
            // 
            lblAstEmail.AutoSize = true;
            lblAstEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstEmail.Location = new Point(550, 288);
            lblAstEmail.Name = "lblAstEmail";
            lblAstEmail.Size = new Size(20, 28);
            lblAstEmail.TabIndex = 29;
            lblAstEmail.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(362, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 28;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(358, 264);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 27;
            lblEmail.Text = "Email";
            // 
            // lblAstTelefono
            // 
            lblAstTelefono.AutoSize = true;
            lblAstTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstTelefono.Location = new Point(246, 288);
            lblAstTelefono.Name = "lblAstTelefono";
            lblAstTelefono.Size = new Size(20, 28);
            lblAstTelefono.TabIndex = 26;
            lblAstTelefono.Text = "*";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(58, 288);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(179, 27);
            txtTelefono.TabIndex = 25;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(54, 264);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Telefono";
            // 
            // lblAstNombre
            // 
            lblAstNombre.AutoSize = true;
            lblAstNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNombre.Location = new Point(246, 191);
            lblAstNombre.Name = "lblAstNombre";
            lblAstNombre.Size = new Size(20, 28);
            lblAstNombre.TabIndex = 23;
            lblAstNombre.Text = "*";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(58, 191);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 27);
            txtNombre.TabIndex = 22;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(54, 167);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(74, 82);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(224, 35);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Registrar no socio";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Desktop;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLight;
            btnRegistrar.Location = new Point(507, 494);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 38);
            btnRegistrar.TabIndex = 41;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(219, 494);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistrarNoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 587);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(chkAptoFisico);
            Controls.Add(lblAstNumDoc);
            Controls.Add(txtNumDoc);
            Controls.Add(lblNumDoc);
            Controls.Add(lblAstTipoDoc);
            Controls.Add(lblTipoDoc);
            Controls.Add(cboTipoDoc);
            Controls.Add(lblAstApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblAstEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblAstTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblAstNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmRegistrarNoSocio";
            Text = "Registrar no socio";
            Load += frmRegistrarNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAptoFisico;
        private Label lblAstNumDoc;
        private TextBox txtNumDoc;
        private Label lblNumDoc;
        private Label lblAstTipoDoc;
        private Label lblTipoDoc;
        private ComboBox cboTipoDoc;
        private Label lblAstApellido;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblAstEmail;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblAstTelefono;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblAstNombre;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblTitulo;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}