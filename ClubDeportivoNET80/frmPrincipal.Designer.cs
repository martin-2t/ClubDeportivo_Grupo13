namespace ClubDeportivoNET80
{
    partial class frmPrincipal
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
            lblIngreso = new Label();
            lblTituloInicio = new Label();
            btnRegistrarSocio = new Button();
            btnRegistrarNoSocio = new Button();
            btnPagarCuota = new Button();
            btnGenerarListaMorosos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(124, 33);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(59, 20);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Usuario";
            // 
            // lblTituloInicio
            // 
            lblTituloInicio.AutoSize = true;
            lblTituloInicio.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloInicio.Location = new Point(154, 97);
            lblTituloInicio.Name = "lblTituloInicio";
            lblTituloInicio.Size = new Size(192, 35);
            lblTituloInicio.TabIndex = 1;
            lblTituloInicio.Text = "Menú Principal";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.BackColor = SystemColors.Desktop;
            btnRegistrarSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarSocio.ForeColor = SystemColors.ControlLight;
            btnRegistrarSocio.Location = new Point(219, 189);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(169, 86);
            btnRegistrarSocio.TabIndex = 2;
            btnRegistrarSocio.Text = "Registrar socio";
            btnRegistrarSocio.UseVisualStyleBackColor = false;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.BackColor = SystemColors.Desktop;
            btnRegistrarNoSocio.FlatStyle = FlatStyle.Popup;
            btnRegistrarNoSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarNoSocio.ForeColor = SystemColors.ControlLight;
            btnRegistrarNoSocio.Location = new Point(499, 189);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(169, 86);
            btnRegistrarNoSocio.TabIndex = 3;
            btnRegistrarNoSocio.Text = "Registrar no socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.BackColor = SystemColors.Desktop;
            btnPagarCuota.FlatStyle = FlatStyle.Popup;
            btnPagarCuota.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagarCuota.ForeColor = SystemColors.ControlLight;
            btnPagarCuota.Location = new Point(219, 328);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(169, 86);
            btnPagarCuota.TabIndex = 4;
            btnPagarCuota.Text = "Pagar cuota";
            btnPagarCuota.UseVisualStyleBackColor = false;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnGenerarListaMorosos
            // 
            btnGenerarListaMorosos.BackColor = SystemColors.Desktop;
            btnGenerarListaMorosos.FlatStyle = FlatStyle.Popup;
            btnGenerarListaMorosos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarListaMorosos.ForeColor = SystemColors.ControlLight;
            btnGenerarListaMorosos.Location = new Point(499, 328);
            btnGenerarListaMorosos.Name = "btnGenerarListaMorosos";
            btnGenerarListaMorosos.Size = new Size(169, 86);
            btnGenerarListaMorosos.TabIndex = 5;
            btnGenerarListaMorosos.Text = "Generar lista morosos";
            btnGenerarListaMorosos.UseVisualStyleBackColor = false;
            btnGenerarListaMorosos.Click += btnGenerarListaMorosos_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.WindowFrame;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(128, 473);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 49);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 554);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarListaMorosos);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnRegistrarNoSocio);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(lblTituloInicio);
            Controls.Add(lblIngreso);
            Name = "frmPrincipal";
            Text = "Pantalla inicio";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Label lblTituloInicio;
        private Button btnRegistrarSocio;
        private Button btnRegistrarNoSocio;
        private Button btnPagarCuota;
        private Button btnGenerarListaMorosos;
        private Button btnSalir;
    }
}