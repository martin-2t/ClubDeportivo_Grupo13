namespace ClubDeportivoNET80
{
    partial class frmPagarCuota
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
            lblAstNumeroCliente = new Label();
            txtNumeroCliente = new TextBox();
            lblNumeroCliente = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblAstNumeroCliente
            // 
            lblAstNumeroCliente.AutoSize = true;
            lblAstNumeroCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstNumeroCliente.Location = new Point(321, 177);
            lblAstNumeroCliente.Name = "lblAstNumeroCliente";
            lblAstNumeroCliente.Size = new Size(20, 28);
            lblAstNumeroCliente.TabIndex = 41;
            lblAstNumeroCliente.Text = "*";
            // 
            // txtNumeroCliente
            // 
            txtNumeroCliente.Location = new Point(133, 177);
            txtNumeroCliente.Name = "txtNumeroCliente";
            txtNumeroCliente.Size = new Size(179, 27);
            txtNumeroCliente.TabIndex = 40;
            // 
            // lblNumeroCliente
            // 
            lblNumeroCliente.AutoSize = true;
            lblNumeroCliente.Location = new Point(129, 153);
            lblNumeroCliente.Name = "lblNumeroCliente";
            lblNumeroCliente.Size = new Size(97, 20);
            lblNumeroCliente.TabIndex = 39;
            lblNumeroCliente.Text = "ID del cliente";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.Desktop;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ControlLight;
            btnConfirmar.Location = new Point(377, 295);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 38);
            btnConfirmar.TabIndex = 43;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(106, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(82, 66);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 35);
            lblTitulo.TabIndex = 44;
            lblTitulo.Text = "Pagar cuota";
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 373);
            Controls.Add(lblTitulo);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblAstNumeroCliente);
            Controls.Add(txtNumeroCliente);
            Controls.Add(lblNumeroCliente);
            Name = "frmPagarCuota";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pagar cuota";
            Load += frmPagarCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAstNumeroCliente;
        private TextBox txtNumeroCliente;
        private Label lblNumeroCliente;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblTitulo;
    }
}