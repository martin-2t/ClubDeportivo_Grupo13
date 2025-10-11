namespace ClubDeportivoNET80
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuarioLogin = new TextBox();
            txtPassLogin = new TextBox();
            btnIngresarLogin = new Button();
            lblTituloLogin = new Label();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(271, 144);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(271, 208);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(83, 20);
            lblClave.TabIndex = 1;
            lblClave.Text = "Contraseña";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(275, 167);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(179, 27);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // txtPassLogin
            // 
            txtPassLogin.Location = new Point(275, 231);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(179, 27);
            txtPassLogin.TabIndex = 3;
            // 
            // btnIngresarLogin
            // 
            btnIngresarLogin.BackColor = SystemColors.ControlText;
            btnIngresarLogin.FlatStyle = FlatStyle.Popup;
            btnIngresarLogin.ForeColor = SystemColors.ControlLight;
            btnIngresarLogin.Location = new Point(275, 287);
            btnIngresarLogin.Margin = new Padding(4);
            btnIngresarLogin.Name = "btnIngresarLogin";
            btnIngresarLogin.Size = new Size(180, 38);
            btnIngresarLogin.TabIndex = 4;
            btnIngresarLogin.Text = "INGRESAR";
            btnIngresarLogin.UseVisualStyleBackColor = false;
            btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);

            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloLogin.Location = new Point(132, 73);
            lblTituloLogin.Margin = new Padding(4, 0, 4, 0);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(228, 41);
            lblTituloLogin.TabIndex = 5;
            lblTituloLogin.Text = "INICIAR SESIÓN";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(33, 144);
            picLogo.Margin = new Padding(4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(213, 181);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 394);
            Controls.Add(picLogo);
            Controls.Add(lblTituloLogin);
            Controls.Add(btnIngresarLogin);
            Controls.Add(txtPassLogin);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "Iniciar sesión";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtUsuarioLogin;
        private TextBox txtPassLogin;
        private Button btnIngresarLogin;
        private Label lblTituloLogin;
        private PictureBox picLogo;
    }
}
