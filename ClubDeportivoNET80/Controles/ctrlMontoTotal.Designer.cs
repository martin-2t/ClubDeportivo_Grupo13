namespace ClubDeportivoNET80.Controles
{
    partial class ctrlMontoTotal
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
            grpMontoTotal = new GroupBox();
            lblMonto = new Label();
            grpMontoTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpMontoTotal
            // 
            grpMontoTotal.Controls.Add(lblMonto);
            grpMontoTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMontoTotal.Location = new Point(25, 18);
            grpMontoTotal.Name = "grpMontoTotal";
            grpMontoTotal.Size = new Size(532, 125);
            grpMontoTotal.TabIndex = 0;
            grpMontoTotal.TabStop = false;
            grpMontoTotal.Text = "El total del monto a pagar es:";
            grpMontoTotal.Enter += grpMontoTotal_Enter;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(95, 57);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(55, 31);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "0.00";
            // 
            // ctrlMontoTotal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpMontoTotal);
            Name = "ctrlMontoTotal";
            Size = new Size(577, 167);
            Load += ctrlMontoTotal_Load;
            grpMontoTotal.ResumeLayout(false);
            grpMontoTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMontoTotal;
        private Label lblMonto;
    }
}
