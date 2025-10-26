namespace ClubDeportivoNET80.Controles
{
    partial class ctrlRegistrarCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpInfoCliente = new GroupBox();
            lblAstAptoFisico = new Label();
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
            grpInfoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // grpInfoCliente
            // 
            grpInfoCliente.Controls.Add(lblAstAptoFisico);
            grpInfoCliente.Controls.Add(chkAptoFisico);
            grpInfoCliente.Controls.Add(lblAstNumDoc);
            grpInfoCliente.Controls.Add(txtNumDoc);
            grpInfoCliente.Controls.Add(lblNumDoc);
            grpInfoCliente.Controls.Add(lblAstTipoDoc);
            grpInfoCliente.Controls.Add(lblTipoDoc);
            grpInfoCliente.Controls.Add(cboTipoDoc);
            grpInfoCliente.Controls.Add(lblAstApellido);
            grpInfoCliente.Controls.Add(txtApellido);
            grpInfoCliente.Controls.Add(lblApellido);
            grpInfoCliente.Controls.Add(lblAstEmail);
            grpInfoCliente.Controls.Add(txtEmail);
            grpInfoCliente.Controls.Add(lblEmail);
            grpInfoCliente.Controls.Add(lblAstTelefono);
            grpInfoCliente.Controls.Add(txtTelefono);
            grpInfoCliente.Controls.Add(lblTelefono);
            grpInfoCliente.Controls.Add(lblAstNombre);
            grpInfoCliente.Controls.Add(txtNombre);
            grpInfoCliente.Controls.Add(lblNombre);
            grpInfoCliente.Location = new Point(25, 17);
            grpInfoCliente.Name = "grpInfoCliente";
            grpInfoCliente.Size = new Size(919, 363);
            grpInfoCliente.TabIndex = 0;
            grpInfoCliente.TabStop = false;
            grpInfoCliente.Text = "Información del cliente requerida";
            // 
            // lblAstAptoFisico
            // 
            lblAstAptoFisico.AutoSize = true;
            lblAstAptoFisico.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstAptoFisico.Location = new Point(846, 295);
            lblAstAptoFisico.Name = "lblAstAptoFisico";
            lblAstAptoFisico.Size = new Size(17, 23);
            lblAstAptoFisico.TabIndex = 39;
            lblAstAptoFisico.Text = "*";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Location = new Point(743, 293);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(105, 24);
            chkAptoFisico.TabIndex = 38;
            chkAptoFisico.Text = "Apto Fisico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // lblAstNumDoc
            // 
            lblAstNumDoc.AutoSize = true;
            lblAstNumDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNumDoc.Location = new Point(825, 212);
            lblAstNumDoc.Name = "lblAstNumDoc";
            lblAstNumDoc.Size = new Size(20, 28);
            lblAstNumDoc.TabIndex = 37;
            lblAstNumDoc.Text = "*";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(637, 212);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(179, 27);
            txtNumDoc.TabIndex = 36;
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(633, 188);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(168, 20);
            lblNumDoc.TabIndex = 35;
            lblNumDoc.Text = "Número del documento";
            // 
            // lblAstTipoDoc
            // 
            lblAstTipoDoc.AutoSize = true;
            lblAstTipoDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstTipoDoc.Location = new Point(823, 113);
            lblAstTipoDoc.Name = "lblAstTipoDoc";
            lblAstTipoDoc.Size = new Size(20, 28);
            lblAstTipoDoc.TabIndex = 34;
            lblAstTipoDoc.Text = "*";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(634, 90);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(140, 20);
            lblTipoDoc.TabIndex = 33;
            lblTipoDoc.Text = "Tipo de documento";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Items.AddRange(new object[] { "DNI", "Pasaporte" });
            cboTipoDoc.Location = new Point(637, 114);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(179, 28);
            cboTipoDoc.TabIndex = 32;
            // 
            // lblAstApellido
            // 
            lblAstApellido.AutoSize = true;
            lblAstApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstApellido.Location = new Point(548, 115);
            lblAstApellido.Name = "lblAstApellido";
            lblAstApellido.Size = new Size(20, 28);
            lblAstApellido.TabIndex = 31;
            lblAstApellido.Text = "*";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(360, 115);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(179, 27);
            txtApellido.TabIndex = 30;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(356, 91);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 29;
            lblApellido.Text = "Apellido";
            // 
            // lblAstEmail
            // 
            lblAstEmail.AutoSize = true;
            lblAstEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstEmail.Location = new Point(548, 212);
            lblAstEmail.Name = "lblAstEmail";
            lblAstEmail.Size = new Size(20, 28);
            lblAstEmail.TabIndex = 28;
            lblAstEmail.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(360, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 27);
            txtEmail.TabIndex = 27;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(356, 188);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 26;
            lblEmail.Text = "Email";
            // 
            // lblAstTelefono
            // 
            lblAstTelefono.AutoSize = true;
            lblAstTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstTelefono.Location = new Point(267, 212);
            lblAstTelefono.Name = "lblAstTelefono";
            lblAstTelefono.Size = new Size(20, 28);
            lblAstTelefono.TabIndex = 25;
            lblAstTelefono.Text = "*";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(79, 212);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(179, 27);
            txtTelefono.TabIndex = 24;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(75, 188);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Telefono";
            // 
            // lblAstNombre
            // 
            lblAstNombre.AutoSize = true;
            lblAstNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNombre.Location = new Point(267, 115);
            lblAstNombre.Name = "lblAstNombre";
            lblAstNombre.Size = new Size(20, 28);
            lblAstNombre.TabIndex = 22;
            lblAstNombre.Text = "*";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 27);
            txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(75, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // ctrlRegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpInfoCliente);
            Name = "ctrlRegistrarCliente";
            Size = new Size(993, 414);
            Load += ctrlRegistrarCliente_Load;
            grpInfoCliente.ResumeLayout(false);
            grpInfoCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInfoCliente;
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
        private Label lblAstAptoFisico;
    }
}
