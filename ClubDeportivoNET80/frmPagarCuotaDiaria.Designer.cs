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
            lblNoSocio = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lblNoSocioNombre = new Label();
            ctrlModoPagoDiario = new ClubDeportivoNET80.Controles.ctrlModoPago();
            ctrlMontoTotalDiario = new ClubDeportivoNET80.Controles.ctrlMontoTotal();
            dtgvActividades = new DataGridView();
            colSeleccionar = new DataGridViewCheckBoxColumn();
            colNum = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lblNoSocio
            // 
            lblNoSocio.AutoSize = true;
            lblNoSocio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoSocio.Location = new Point(64, 58);
            lblNoSocio.Name = "lblNoSocio";
            lblNoSocio.Size = new Size(112, 28);
            lblNoSocio.TabIndex = 46;
            lblNoSocio.Text = "NO SOCIO:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.Desktop;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ControlLight;
            btnConfirmar.Location = new Point(561, 592);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(140, 38);
            btnConfirmar.TabIndex = 48;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Desktop;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(273, 592);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNoSocioNombre
            // 
            lblNoSocioNombre.AutoSize = true;
            lblNoSocioNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoSocioNombre.Location = new Point(197, 58);
            lblNoSocioNombre.Name = "lblNoSocioNombre";
            lblNoSocioNombre.Size = new Size(184, 28);
            lblNoSocioNombre.TabIndex = 49;
            lblNoSocioNombre.Text = "APELLIDO NOMBRE";
            // 
            // ctrlModoPagoDiario
            // 
            ctrlModoPagoDiario.Location = new Point(158, 409);
            ctrlModoPagoDiario.Name = "ctrlModoPagoDiario";
            ctrlModoPagoDiario.Size = new Size(633, 142);
            ctrlModoPagoDiario.TabIndex = 50;
            // 
            // ctrlMontoTotalDiario
            // 
            ctrlMontoTotalDiario.Location = new Point(614, 202);
            ctrlMontoTotalDiario.Name = "ctrlMontoTotalDiario";
            ctrlMontoTotalDiario.Size = new Size(399, 164);
            ctrlMontoTotalDiario.TabIndex = 51;
            // 
            // dtgvActividades
            // 
            dtgvActividades.AllowUserToAddRows = false;
            dtgvActividades.AllowUserToDeleteRows = false;
            dtgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividades.Columns.AddRange(new DataGridViewColumn[] { colSeleccionar, colNum, colNombre, colMonto });
            dtgvActividades.Location = new Point(55, 122);
            dtgvActividades.Name = "dtgvActividades";
            dtgvActividades.RowHeadersWidth = 51;
            dtgvActividades.Size = new Size(520, 244);
            dtgvActividades.TabIndex = 52;
            dtgvActividades.CellValueChanged += dtgvActividades_CellValueChanged;
            dtgvActividades.CurrentCellDirtyStateChanged += dtgvActividades_CurrentCellDirtyStateChanged;

            // 
            // colSeleccionar
            // 
            colSeleccionar.HeaderText = "Seleccionar";
            colSeleccionar.MinimumWidth = 6;
            colSeleccionar.Name = "colSeleccionar";
            // 
            // colNum
            // 
            colNum.HeaderText = "ID";
            colNum.MinimumWidth = 6;
            colNum.Name = "colNum";
            colNum.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Actividad";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Precio";
            colMonto.MinimumWidth = 6;
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // frmPagarCuotaDiaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 674);
            Controls.Add(dtgvActividades);
            Controls.Add(ctrlMontoTotalDiario);
            Controls.Add(ctrlModoPagoDiario);
            Controls.Add(lblNoSocioNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(lblNoSocio);
            Name = "frmPagarCuotaDiaria";
            Text = "Pagar cuota diaria";
            Load += frmPagarCuotaDiaria_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoSocio;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label lblNoSocioNombre;
        private Controles.ctrlModoPago ctrlModoPagoDiario;
        private Controles.ctrlMontoTotal ctrlMontoTotalDiario;
        private DataGridView dtgvActividades;
        private DataGridViewCheckBoxColumn colSeleccionar;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colMonto;
    }
}