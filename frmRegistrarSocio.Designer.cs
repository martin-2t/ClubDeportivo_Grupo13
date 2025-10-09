namespace ClubDeportivo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.chkAptoFisico = new System.Windows.Forms.CheckBox();
            this.lblAstNombre = new System.Windows.Forms.Label();
            this.lblAstApellido = new System.Windows.Forms.Label();
            this.lblAstTelefono = new System.Windows.Forms.Label();
            this.lblAstEmail = new System.Windows.Forms.Label();
            this.lblAstAptoFisico = new System.Windows.Forms.Label();
            this.lblAstNumDoc = new System.Windows.Forms.Label();
            this.lblAstTipoDoc = new System.Windows.Forms.Label();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.cboModoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModoPago = new System.Windows.Forms.Label();
            this.cboPromocion = new System.Windows.Forms.ComboBox();
            this.lblPromocion = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMontoCuotaMensual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(87, 44);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Registrar Socio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(222, 570);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 38);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrar.Location = new System.Drawing.Point(500, 572);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(140, 38);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(367, 129);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 20);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(89, 129);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(371, 153);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(179, 22);
            this.txtApellido.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 153);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(367, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(89, 211);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 20);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(371, 234);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 22);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(93, 234);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(179, 22);
            this.txtTelefono.TabIndex = 15;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // chkAptoFisico
            // 
            this.chkAptoFisico.AutoSize = true;
            this.chkAptoFisico.Location = new System.Drawing.Point(718, 316);
            this.chkAptoFisico.Margin = new System.Windows.Forms.Padding(4);
            this.chkAptoFisico.Name = "chkAptoFisico";
            this.chkAptoFisico.Size = new System.Drawing.Size(96, 20);
            this.chkAptoFisico.TabIndex = 19;
            this.chkAptoFisico.Text = "Apto Fisico";
            this.chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // lblAstNombre
            // 
            this.lblAstNombre.AutoSize = true;
            this.lblAstNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstNombre.Location = new System.Drawing.Point(281, 153);
            this.lblAstNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstNombre.Name = "lblAstNombre";
            this.lblAstNombre.Size = new System.Drawing.Size(20, 25);
            this.lblAstNombre.TabIndex = 20;
            this.lblAstNombre.Text = "*";
            // 
            // lblAstApellido
            // 
            this.lblAstApellido.AutoSize = true;
            this.lblAstApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstApellido.Location = new System.Drawing.Point(559, 153);
            this.lblAstApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstApellido.Name = "lblAstApellido";
            this.lblAstApellido.Size = new System.Drawing.Size(20, 25);
            this.lblAstApellido.TabIndex = 21;
            this.lblAstApellido.Text = "*";
            // 
            // lblAstTelefono
            // 
            this.lblAstTelefono.AutoSize = true;
            this.lblAstTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstTelefono.Location = new System.Drawing.Point(281, 234);
            this.lblAstTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstTelefono.Name = "lblAstTelefono";
            this.lblAstTelefono.Size = new System.Drawing.Size(20, 25);
            this.lblAstTelefono.TabIndex = 22;
            this.lblAstTelefono.Text = "*";
            this.lblAstTelefono.Click += new System.EventHandler(this.lblAstTelefono_Click);
            // 
            // lblAstEmail
            // 
            this.lblAstEmail.AutoSize = true;
            this.lblAstEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstEmail.Location = new System.Drawing.Point(559, 234);
            this.lblAstEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstEmail.Name = "lblAstEmail";
            this.lblAstEmail.Size = new System.Drawing.Size(20, 25);
            this.lblAstEmail.TabIndex = 23;
            this.lblAstEmail.Text = "*";
            this.lblAstEmail.Click += new System.EventHandler(this.lblAstEmail_Click);
            // 
            // lblAstAptoFisico
            // 
            this.lblAstAptoFisico.AutoSize = true;
            this.lblAstAptoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstAptoFisico.Location = new System.Drawing.Point(830, 316);
            this.lblAstAptoFisico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstAptoFisico.Name = "lblAstAptoFisico";
            this.lblAstAptoFisico.Size = new System.Drawing.Size(20, 25);
            this.lblAstAptoFisico.TabIndex = 24;
            this.lblAstAptoFisico.Text = "*";
            // 
            // lblAstNumDoc
            // 
            this.lblAstNumDoc.AutoSize = true;
            this.lblAstNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstNumDoc.Location = new System.Drawing.Point(824, 234);
            this.lblAstNumDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstNumDoc.Name = "lblAstNumDoc";
            this.lblAstNumDoc.Size = new System.Drawing.Size(20, 25);
            this.lblAstNumDoc.TabIndex = 30;
            this.lblAstNumDoc.Text = "*";
            // 
            // lblAstTipoDoc
            // 
            this.lblAstTipoDoc.AutoSize = true;
            this.lblAstTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAstTipoDoc.Location = new System.Drawing.Point(824, 153);
            this.lblAstTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAstTipoDoc.Name = "lblAstTipoDoc";
            this.lblAstTipoDoc.Size = new System.Drawing.Size(20, 25);
            this.lblAstTipoDoc.TabIndex = 29;
            this.lblAstTipoDoc.Text = "*";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDoc.Location = new System.Drawing.Point(632, 210);
            this.lblNumDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(182, 20);
            this.lblNumDoc.TabIndex = 28;
            this.lblNumDoc.Text = "Número del documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(632, 129);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(132, 20);
            this.lblTipoDoc.TabIndex = 27;
            this.lblTipoDoc.Text = "Tipo Documento";
            this.lblTipoDoc.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(636, 234);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(179, 22);
            this.txtNumDoc.TabIndex = 26;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cboTipoDoc.Location = new System.Drawing.Point(636, 154);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(179, 24);
            this.cboTipoDoc.TabIndex = 31;
            // 
            // cboModoPago
            // 
            this.cboModoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModoPago.FormattingEnabled = true;
            this.cboModoPago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo"});
            this.cboModoPago.Location = new System.Drawing.Point(93, 364);
            this.cboModoPago.Name = "cboModoPago";
            this.cboModoPago.Size = new System.Drawing.Size(179, 24);
            this.cboModoPago.TabIndex = 34;
            this.cboModoPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 363);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModoPago
            // 
            this.lblModoPago.AutoSize = true;
            this.lblModoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoPago.Location = new System.Drawing.Point(89, 339);
            this.lblModoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModoPago.Name = "lblModoPago";
            this.lblModoPago.Size = new System.Drawing.Size(114, 20);
            this.lblModoPago.TabIndex = 32;
            this.lblModoPago.Text = "Modo de pago";
            this.lblModoPago.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboPromocion
            // 
            this.cboPromocion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPromocion.FormattingEnabled = true;
            this.cboPromocion.Items.AddRange(new object[] {
            "3 cuotas",
            "6 cuotas"});
            this.cboPromocion.Location = new System.Drawing.Point(371, 364);
            this.cboPromocion.Name = "cboPromocion";
            this.cboPromocion.Size = new System.Drawing.Size(179, 24);
            this.cboPromocion.TabIndex = 37;
            this.cboPromocion.Visible = false;
            // 
            // lblPromocion
            // 
            this.lblPromocion.AutoSize = true;
            this.lblPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(367, 339);
            this.lblPromocion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(89, 20);
            this.lblPromocion.TabIndex = 35;
            this.lblPromocion.Text = "Promocion";
            this.lblPromocion.Visible = false;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(251, 464);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(126, 25);
            this.lblMonto.TabIndex = 38;
            this.lblMonto.Text = "Monto total:";
            // 
            // lblMontoCuotaMensual
            // 
            this.lblMontoCuotaMensual.AutoSize = true;
            this.lblMontoCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCuotaMensual.Location = new System.Drawing.Point(412, 468);
            this.lblMontoCuotaMensual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoCuotaMensual.Name = "lblMontoCuotaMensual";
            this.lblMontoCuotaMensual.Size = new System.Drawing.Size(0, 20);
            this.lblMontoCuotaMensual.TabIndex = 39;
            // 
            // frmRegistrarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 686);
            this.Controls.Add(this.lblMontoCuotaMensual);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cboPromocion);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.cboModoPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModoPago);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.lblAstNumDoc);
            this.Controls.Add(this.lblAstTipoDoc);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblAstAptoFisico);
            this.Controls.Add(this.lblAstEmail);
            this.Controls.Add(this.lblAstTelefono);
            this.Controls.Add(this.lblAstApellido);
            this.Controls.Add(this.lblAstNombre);
            this.Controls.Add(this.chkAptoFisico);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarSocio";
            this.Text = "Registrar Socio";
            this.Load += new System.EventHandler(this.frmRegistrarSocio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkAptoFisico;
        private System.Windows.Forms.Label lblAstNombre;
        private System.Windows.Forms.Label lblAstApellido;
        private System.Windows.Forms.Label lblAstTelefono;
        private System.Windows.Forms.Label lblAstEmail;
        private System.Windows.Forms.Label lblAstAptoFisico;
        private System.Windows.Forms.Label lblAstNumDoc;
        private System.Windows.Forms.Label lblAstTipoDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.ComboBox cboModoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModoPago;
        private System.Windows.Forms.ComboBox cboPromocion;
        private System.Windows.Forms.Label lblPromocion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMontoCuotaMensual;
    }
}