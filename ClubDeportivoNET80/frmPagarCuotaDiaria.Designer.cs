namespace ClubDeportivoNET80
{
    partial class frmPagarCuotaDiaria
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(68, 85);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(224, 35);
            lblTitulo.TabIndex = 46;
            lblTitulo.Text = "Pagar cuota diaria";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.Desktop;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ControlLight;
            btnConfirmar.Location = new Point(450, 368);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 38);
            btnConfirmar.TabIndex = 48;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(162, 368);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmPagarCuotaDiaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Name = "frmPagarCuotaDiaria";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}