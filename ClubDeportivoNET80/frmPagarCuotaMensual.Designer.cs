namespace ClubDeportivoNET80
{
    partial class frmPagarCuotaMensual
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
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            lblSocio = new Label();
            dtgvCuotasMensuales = new DataGridView();
            colNum = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colFechaVencimiento = new DataGridViewTextBoxColumn();
            ctrlMontoTotalMensual = new ClubDeportivoNET80.Controles.ctrlMontoTotal();
            lblUltimaPagada = new Label();
            ctrlModoPagoMensual = new ClubDeportivoNET80.Controles.ctrlModoPago();
            ((System.ComponentModel.ISupportInitialize)dtgvCuotasMensuales).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.Desktop;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ControlLight;
            btnConfirmar.Location = new Point(520, 556);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 38);
            btnConfirmar.TabIndex = 51;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(232, 556);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(140, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(184, 28);
            lblNombre.TabIndex = 53;
            lblNombre.Text = "APELLIDO NOMBRE";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSocio.Location = new Point(56, 53);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(76, 28);
            lblSocio.TabIndex = 52;
            lblSocio.Text = "SOCIO:";
            // 
            // dtgvCuotasMensuales
            // 
            dtgvCuotasMensuales.AllowUserToAddRows = false;
            dtgvCuotasMensuales.AllowUserToDeleteRows = false;
            dtgvCuotasMensuales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCuotasMensuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCuotasMensuales.Columns.AddRange(new DataGridViewColumn[] { colNum, colMonto, colFechaVencimiento });
            dtgvCuotasMensuales.Location = new Point(56, 110);
            dtgvCuotasMensuales.Name = "dtgvCuotasMensuales";
            dtgvCuotasMensuales.ReadOnly = true;
            dtgvCuotasMensuales.RowHeadersWidth = 51;
            dtgvCuotasMensuales.Size = new Size(470, 188);
            dtgvCuotasMensuales.TabIndex = 54;
            // 
            // colNum
            // 
            colNum.HeaderText = "ID";
            colNum.MinimumWidth = 6;
            colNum.Name = "colNum";
            colNum.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Precio";
            colMonto.MinimumWidth = 6;
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colFechaVencimiento
            // 
            colFechaVencimiento.HeaderText = "Fecha de vencimiento";
            colFechaVencimiento.MinimumWidth = 6;
            colFechaVencimiento.Name = "colFechaVencimiento";
            colFechaVencimiento.ReadOnly = true;
            // 
            // ctrlMontoTotalMensual
            // 
            ctrlMontoTotalMensual.Location = new Point(549, 137);
            ctrlMontoTotalMensual.Name = "ctrlMontoTotalMensual";
            ctrlMontoTotalMensual.Size = new Size(322, 146);
            ctrlMontoTotalMensual.TabIndex = 55;
            // 
            // lblUltimaPagada
            // 
            lblUltimaPagada.AutoSize = true;
            lblUltimaPagada.BackColor = SystemColors.Info;
            lblUltimaPagada.Location = new Point(60, 321);
            lblUltimaPagada.Name = "lblUltimaPagada";
            lblUltimaPagada.Size = new Size(211, 20);
            lblUltimaPagada.TabIndex = 56;
            lblUltimaPagada.Text = "La última cuota pagada fue el \r\n";
            // 
            // ctrlModoPagoMensual
            // 
            ctrlModoPagoMensual.Location = new Point(59, 368);
            ctrlModoPagoMensual.Name = "ctrlModoPagoMensual";
            ctrlModoPagoMensual.Size = new Size(706, 144);
            ctrlModoPagoMensual.TabIndex = 57;
            // 
            // frmPagarCuotaMensual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 632);
            Controls.Add(ctrlModoPagoMensual);
            Controls.Add(lblUltimaPagada);
            Controls.Add(ctrlMontoTotalMensual);
            Controls.Add(dtgvCuotasMensuales);
            Controls.Add(lblNombre);
            Controls.Add(lblSocio);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Name = "frmPagarCuotaMensual";
            Text = "Pagar cuota mensual";
            Load += frmPagarCuotaMensual_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCuotasMensuales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblNombre;
        private Label lblSocio;
        private DataGridView dtgvCuotasMensuales;
        private Controles.ctrlMontoTotal ctrlMontoTotalMensual;
        private Label lblUltimaPagada;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colFechaVencimiento;
        private Controles.ctrlModoPago ctrlModoPagoMensual;
    }
}