namespace ClubDeportivo
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
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarSocio = new System.Windows.Forms.Button();
            this.btnRegistrarNoSocio = new System.Windows.Forms.Button();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.btnGenerarListaMorosos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(93, 27);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(43, 13);
            this.lblIngreso.TabIndex = 1;
            this.lblIngreso.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(96, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarSocio
            // 
            this.btnRegistrarSocio.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSocio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrarSocio.Location = new System.Drawing.Point(96, 155);
            this.btnRegistrarSocio.Name = "btnRegistrarSocio";
            this.btnRegistrarSocio.Size = new System.Drawing.Size(127, 70);
            this.btnRegistrarSocio.TabIndex = 3;
            this.btnRegistrarSocio.Text = "Registrar Socio";
            this.btnRegistrarSocio.UseVisualStyleBackColor = false;
            this.btnRegistrarSocio.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // btnRegistrarNoSocio
            // 
            this.btnRegistrarNoSocio.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrarNoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarNoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNoSocio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegistrarNoSocio.Location = new System.Drawing.Point(299, 155);
            this.btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            this.btnRegistrarNoSocio.Size = new System.Drawing.Size(127, 70);
            this.btnRegistrarNoSocio.TabIndex = 4;
            this.btnRegistrarNoSocio.Text = "Registrar No Socio";
            this.btnRegistrarNoSocio.UseVisualStyleBackColor = false;
            this.btnRegistrarNoSocio.Click += new System.EventHandler(this.btnRegistrarNoSocio_Click);
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPagarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCuota.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPagarCuota.Location = new System.Drawing.Point(96, 274);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(127, 70);
            this.btnPagarCuota.TabIndex = 5;
            this.btnPagarCuota.Text = "PagarCuota";
            this.btnPagarCuota.UseVisualStyleBackColor = false;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnPagarCuota_Click);
            // 
            // btnGenerarListaMorosos
            // 
            this.btnGenerarListaMorosos.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGenerarListaMorosos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarListaMorosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarListaMorosos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerarListaMorosos.Location = new System.Drawing.Point(299, 274);
            this.btnGenerarListaMorosos.Name = "btnGenerarListaMorosos";
            this.btnGenerarListaMorosos.Size = new System.Drawing.Size(127, 70);
            this.btnGenerarListaMorosos.TabIndex = 6;
            this.btnGenerarListaMorosos.Text = "Generar Lista Morosos";
            this.btnGenerarListaMorosos.UseVisualStyleBackColor = false;
            this.btnGenerarListaMorosos.Click += new System.EventHandler(this.btnGenerarListaMorosos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú Principal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarListaMorosos);
            this.Controls.Add(this.btnPagarCuota);
            this.Controls.Add(this.btnRegistrarNoSocio);
            this.Controls.Add(this.btnRegistrarSocio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIngreso);
            this.Name = "frmPrincipal";
            this.Text = "Pantalla inicio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarSocio;
        private System.Windows.Forms.Button btnRegistrarNoSocio;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Button btnGenerarListaMorosos;
        private System.Windows.Forms.Label label1;
    }
}