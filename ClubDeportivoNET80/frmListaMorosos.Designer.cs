namespace ClubDeportivoNET80
{
    partial class frmListaMorosos
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
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(109, 84);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(290, 35);
            lblTitulo.TabIndex = 45;
            lblTitulo.Text = "Lista de socios morosos";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Desktop;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.ControlLight;
            btnVolver.Location = new Point(137, 375);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 38);
            btnVolver.TabIndex = 46;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmListaMorosos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "frmListaMorosos";
            Text = "frmListaMorosos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
    }
}