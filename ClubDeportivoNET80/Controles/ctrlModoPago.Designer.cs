namespace ClubDeportivoNET80.Controles
{
    partial class ctrlModoPago
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
            grpModoPago = new GroupBox();
            lblPromocion = new Label();
            cboPromocion = new ComboBox();
            lblAstModoPago = new Label();
            lblModoPago = new Label();
            cboModoPago = new ComboBox();
            grpModoPago.SuspendLayout();
            SuspendLayout();
            // 
            // grpModoPago
            // 
            grpModoPago.Controls.Add(lblPromocion);
            grpModoPago.Controls.Add(cboPromocion);
            grpModoPago.Controls.Add(lblAstModoPago);
            grpModoPago.Controls.Add(lblModoPago);
            grpModoPago.Controls.Add(cboModoPago);
            grpModoPago.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpModoPago.Location = new Point(3, 3);
            grpModoPago.Name = "grpModoPago";
            grpModoPago.Size = new Size(619, 125);
            grpModoPago.TabIndex = 0;
            grpModoPago.TabStop = false;
            grpModoPago.Text = "Detalles del pago";
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromocion.Location = new Point(367, 39);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(81, 20);
            lblPromocion.TabIndex = 29;
            lblPromocion.Text = "Promocion";
            lblPromocion.Visible = false;
            // 
            // cboPromocion
            // 
            cboPromocion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPromocion.FormattingEnabled = true;
            cboPromocion.Items.AddRange(new object[] { "3 cuotas", "6 cuotas" });
            cboPromocion.Location = new Point(370, 63);
            cboPromocion.Name = "cboPromocion";
            cboPromocion.Size = new Size(179, 28);
            cboPromocion.TabIndex = 28;
            cboPromocion.Visible = false;
            // 
            // lblAstModoPago
            // 
            lblAstModoPago.AutoSize = true;
            lblAstModoPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAstModoPago.Location = new Point(252, 63);
            lblAstModoPago.Name = "lblAstModoPago";
            lblAstModoPago.Size = new Size(20, 28);
            lblAstModoPago.TabIndex = 27;
            lblAstModoPago.Text = "*";
            // 
            // lblModoPago
            // 
            lblModoPago.AutoSize = true;
            lblModoPago.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModoPago.Location = new Point(63, 40);
            lblModoPago.Name = "lblModoPago";
            lblModoPago.Size = new Size(109, 20);
            lblModoPago.TabIndex = 26;
            lblModoPago.Text = "Modo de pago";
            // 
            // cboModoPago
            // 
            cboModoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModoPago.FormattingEnabled = true;
            cboModoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cboModoPago.Location = new Point(66, 64);
            cboModoPago.Name = "cboModoPago";
            cboModoPago.Size = new Size(179, 28);
            cboModoPago.TabIndex = 25;
            cboModoPago.SelectedIndexChanged += cboModoPago_SelectedIndexChanged;
            // 
            // ctrlModoPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpModoPago);
            Name = "ctrlModoPago";
            Size = new Size(632, 134);
            grpModoPago.ResumeLayout(false);
            grpModoPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpModoPago;
        private Label lblPromocion;
        private ComboBox cboPromocion;
        private Label lblAstModoPago;
        private Label lblModoPago;
        private ComboBox cboModoPago;
    }
}
