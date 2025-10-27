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
            btnRegistrar = new Button();
            btnCancelar = new Button();
            ctrlRegistrarClienteNoSocio = new ClubDeportivoNET80.Controles.ctrlRegistrarCliente();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Desktop;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLight;
            btnRegistrar.Location = new Point(543, 484);
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
            btnCancelar.Location = new Point(255, 484);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 40;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ctrlRegistrarClienteNoSocio
            // 
            ctrlRegistrarClienteNoSocio.Location = new Point(13, 53);
            ctrlRegistrarClienteNoSocio.Name = "ctrlRegistrarClienteNoSocio";
            ctrlRegistrarClienteNoSocio.Size = new Size(953, 395);
            ctrlRegistrarClienteNoSocio.TabIndex = 42;
            // 
            // frmRegistrarNoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 560);
            Controls.Add(ctrlRegistrarClienteNoSocio);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Name = "frmRegistrarNoSocio";
            Text = "Registrar no socio";
            Load += frmRegistrarNoSocio_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistrar;
        private Button btnCancelar;
        private Controles.ctrlRegistrarCliente ctrlRegistrarClienteNoSocio;
    }
}