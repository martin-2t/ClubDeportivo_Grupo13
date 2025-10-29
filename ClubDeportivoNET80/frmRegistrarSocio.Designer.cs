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
            btnCancelar = new Button();
            btnRegistrar = new Button();
            ctrlRegistrarClienteSocio = new ClubDeportivoNET80.Controles.ctrlRegistrarCliente();
            ctrlMontoTotalSocio = new ClubDeportivoNET80.Controles.ctrlMontoTotal();
            ctrlModoPagoSocio = new ClubDeportivoNET80.Controles.ctrlModoPago();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(326, 678);
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
            btnRegistrar.Location = new Point(614, 678);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 38);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // ctrlRegistrarClienteSocio
            // 
            ctrlRegistrarClienteSocio.Location = new Point(48, 51);
            ctrlRegistrarClienteSocio.Name = "ctrlRegistrarClienteSocio";
            ctrlRegistrarClienteSocio.Size = new Size(956, 392);
            ctrlRegistrarClienteSocio.TabIndex = 28;
            // 
            // ctrlMontoTotalSocio
            // 
            ctrlMontoTotalSocio.Location = new Point(674, 475);
            ctrlMontoTotalSocio.Name = "ctrlMontoTotalSocio";
            ctrlMontoTotalSocio.Size = new Size(394, 155);
            ctrlMontoTotalSocio.TabIndex = 29;
            // 
            // ctrlModoPagoSocio
            // 
            ctrlModoPagoSocio.Location = new Point(30, 488);
            ctrlModoPagoSocio.Name = "ctrlModoPagoSocio";
            ctrlModoPagoSocio.Size = new Size(631, 138);
            ctrlModoPagoSocio.TabIndex = 30;
            // 
            // frmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 746);
            Controls.Add(ctrlModoPagoSocio);
            Controls.Add(ctrlMontoTotalSocio);
            Controls.Add(ctrlRegistrarClienteSocio);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Name = "frmRegistrarSocio";
            Text = "Registrar socio";
            Load += frmRegistrarSocio_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private Button btnRegistrar;
        private Controles.ctrlRegistrarCliente ctrlRegistrarClienteSocio;
        private Controles.ctrlMontoTotal ctrlMontoTotalSocio;
        private Controles.ctrlModoPago ctrlModoPagoSocio;
    }
}