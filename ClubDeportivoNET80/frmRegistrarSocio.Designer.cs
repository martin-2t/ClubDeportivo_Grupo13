namespace ClubDeportivoNET80
{
    partial class frmRegistrarSocio
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblAstNombre = new Label();
            lblAstTelefono = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblAstEmail = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblAstApellido = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            cboTipoDoc = new ComboBox();
            lblTipoDoc = new Label();
            lblAstTipoDoc = new Label();
            lblAstNumDoc = new Label();
            txtNumDoc = new TextBox();
            lblNumDoc = new Label();
            chkAptoFisico = new CheckBox();
            lblAstModoPago = new Label();
            lblModoPago = new Label();
            cboModoPago = new ComboBox();
            lblPromocion = new Label();
            cboPromocion = new ComboBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lblMontoTitulo = new Label();
            lblMontoValor = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(87, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 129);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblAstNombre
            // 
            lblAstNombre.AutoSize = true;
            lblAstNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNombre.Location = new Point(259, 153);
            lblAstNombre.Name = "lblAstNombre";
            lblAstNombre.Size = new Size(20, 28);
            lblAstNombre.TabIndex = 3;
            lblAstNombre.Text = "*";
            // 
            // lblAstTelefono
            // 
            lblAstTelefono.AutoSize = true;
            lblAstTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstTelefono.Location = new Point(259, 250);
            lblAstTelefono.Name = "lblAstTelefono";
            lblAstTelefono.Size = new Size(20, 28);
            lblAstTelefono.TabIndex = 6;
            lblAstTelefono.Text = "*";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(71, 250);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(179, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(67, 226);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // lblAstEmail
            // 
            lblAstEmail.AutoSize = true;
            lblAstEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstEmail.Location = new Point(563, 250);
            lblAstEmail.Name = "lblAstEmail";
            lblAstEmail.Size = new Size(20, 28);
            lblAstEmail.TabIndex = 9;
            lblAstEmail.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(375, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(371, 226);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblAstApellido
            // 
            lblAstApellido.AutoSize = true;
            lblAstApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstApellido.Location = new Point(563, 153);
            lblAstApellido.Name = "lblAstApellido";
            lblAstApellido.Size = new Size(20, 28);
            lblAstApellido.TabIndex = 12;
            lblAstApellido.Text = "*";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(375, 153);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(179, 27);
            txtApellido.TabIndex = 11;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(371, 129);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Items.AddRange(new object[] { "DNI", "Pasaporte" });
            cboTipoDoc.Location = new Point(666, 152);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(179, 28);
            cboTipoDoc.TabIndex = 13;
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(663, 128);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(140, 20);
            lblTipoDoc.TabIndex = 14;
            lblTipoDoc.Text = "Tipo de documento";
            // 
            // lblAstTipoDoc
            // 
            lblAstTipoDoc.AutoSize = true;
            lblAstTipoDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstTipoDoc.Location = new Point(852, 151);
            lblAstTipoDoc.Name = "lblAstTipoDoc";
            lblAstTipoDoc.Size = new Size(20, 28);
            lblAstTipoDoc.TabIndex = 15;
            lblAstTipoDoc.Text = "*";
            // 
            // lblAstNumDoc
            // 
            lblAstNumDoc.AutoSize = true;
            lblAstNumDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNumDoc.Location = new Point(854, 250);
            lblAstNumDoc.Name = "lblAstNumDoc";
            lblAstNumDoc.Size = new Size(20, 28);
            lblAstNumDoc.TabIndex = 18;
            lblAstNumDoc.Text = "*";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(666, 250);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(179, 27);
            txtNumDoc.TabIndex = 17;
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(662, 226);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(168, 20);
            lblNumDoc.TabIndex = 16;
            lblNumDoc.Text = "Número del documneto";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(740, 331);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(105, 24);
            chkAptoFisico.TabIndex = 19;
            chkAptoFisico.Text = "Apto Fisico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // lblAstModoPago
            // 
            lblAstModoPago.AutoSize = true;
            lblAstModoPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstModoPago.Location = new Point(257, 454);
            lblAstModoPago.Name = "lblAstModoPago";
            lblAstModoPago.Size = new Size(20, 28);
            lblAstModoPago.TabIndex = 22;
            lblAstModoPago.Text = "*";
            // 
            // lblModoPago
            // 
            lblModoPago.AutoSize = true;
            lblModoPago.Location = new Point(68, 431);
            lblModoPago.Name = "lblModoPago";
            lblModoPago.Size = new Size(109, 20);
            lblModoPago.TabIndex = 21;
            lblModoPago.Text = "Modo de pago";
            // 
            // cboModoPago
            // 
            cboModoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModoPago.FormattingEnabled = true;
            cboModoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cboModoPago.Location = new Point(71, 455);
            cboModoPago.Name = "cboModoPago";
            cboModoPago.Size = new Size(179, 28);
            cboModoPago.TabIndex = 20;
            cboModoPago.SelectedIndexChanged += cboModoPago_SelectedIndexChanged;
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Location = new Point(372, 430);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(81, 20);
            lblPromocion.TabIndex = 24;
            lblPromocion.Text = "Promocion";
            lblPromocion.Visible = false;
            // 
            // cboPromocion
            // 
            cboPromocion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPromocion.FormattingEnabled = true;
            cboPromocion.Items.AddRange(new object[] { "3 cuotas", "6 cuotas" });
            cboPromocion.Location = new Point(375, 454);
            cboPromocion.Name = "cboPromocion";
            cboPromocion.Size = new Size(179, 28);
            cboPromocion.TabIndex = 23;
            cboPromocion.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(231, 665);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Desktop;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLight;
            btnRegistrar.Location = new Point(519, 665);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 38);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblMontoTitulo
            // 
            lblMontoTitulo.AutoSize = true;
            lblMontoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoTitulo.Location = new Point(87, 564);
            lblMontoTitulo.Name = "lblMontoTitulo";
            lblMontoTitulo.Size = new Size(131, 28);
            lblMontoTitulo.TabIndex = 27;
            lblMontoTitulo.Text = "Monto total:";
            // 
            // lblMontoValor
            // 
            lblMontoValor.AutoSize = true;
            lblMontoValor.Location = new Point(257, 571);
            lblMontoValor.Name = "lblMontoValor";
            lblMontoValor.Size = new Size(0, 20);
            lblMontoValor.TabIndex = 28;
            // 
            // frmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 767);
            Controls.Add(lblMontoValor);
            Controls.Add(lblMontoTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblPromocion);
            Controls.Add(cboPromocion);
            Controls.Add(lblAstModoPago);
            Controls.Add(lblModoPago);
            Controls.Add(cboModoPago);
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
            Name = "frmRegistrarSocio";
            Text = "Registrar socio";
            Load += frmRegistrarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblAstNombre;
        private Label lblAstTelefono;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblAstEmail;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblAstApellido;
        private TextBox txtApellido;
        private Label lblApellido;
        private ComboBox cboTipoDoc;
        private Label lblTipoDoc;
        private Label lblAstTipoDoc;
        private Label lblAstNumDoc;
        private TextBox txtNumDoc;
        private Label lblNumDoc;
        private CheckBox chkAptoFisico;
        private Label lblAstModoPago;
        private Label lblModoPago;
        private ComboBox cboModoPago;
        private Label lblPromocion;
        private ComboBox cboPromocion;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Label lblMontoTitulo;
        private Label lblMontoValor;
    }
}