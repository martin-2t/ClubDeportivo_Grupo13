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
            dtgvMorosos = new DataGridView();
            colNum = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvMorosos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(50, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 25);
            lblTitulo.TabIndex = 45;
            lblTitulo.Text = "Socios que tienen cuotas vencidas:";
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
            // dtgvMorosos
            // 
            dtgvMorosos.AllowUserToAddRows = false;
            dtgvMorosos.AllowUserToDeleteRows = false;
            dtgvMorosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMorosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMorosos.Columns.AddRange(new DataGridViewColumn[] { colNum, colApellido, colNombre });
            dtgvMorosos.Location = new Point(101, 120);
            dtgvMorosos.Name = "dtgvMorosos";
            dtgvMorosos.ReadOnly = true;
            dtgvMorosos.RowHeadersWidth = 51;
            dtgvMorosos.Size = new Size(569, 188);
            dtgvMorosos.TabIndex = 47;
            // 
            // colNum
            // 
            colNum.HeaderText = "ID";
            colNum.MinimumWidth = 6;
            colNum.Name = "colNum";
            colNum.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // frmListaMorosos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvMorosos);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "frmListaMorosos";
            Text = "Lista de socios morosos";
            Load += frmListaMorosos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvMorosos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnVolver;
        private DataGridView dtgvMorosos;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colNombre;
    }
}