namespace ClubDeportivo
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(148, 59);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(87, 29);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "LOGIN";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(25, 117);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(160, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(206, 136);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(135, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Location = new System.Drawing.Point(206, 188);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.Size = new System.Drawing.Size(135, 20);
            this.txtPassLogin.TabIndex = 3;
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnIngresarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnIngresarLogin.Location = new System.Drawing.Point(206, 233);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(135, 31);
            this.btnIngresarLogin.TabIndex = 4;
            this.btnIngresarLogin.Text = "INGRESAR";
            this.btnIngresarLogin.UseVisualStyleBackColor = false;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(203, 117);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(203, 169);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(76, 16);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Contraseña";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 320);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresarLogin);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTituloLogin);
            this.Name = "frmLogin";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
    }
}