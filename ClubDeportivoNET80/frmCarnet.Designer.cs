namespace ClubDeportivoNET80
{
    partial class frmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            pnlCarnet = new Panel();
            flpInfo = new FlowLayoutPanel();
            flpNombreCompleto = new FlowLayoutPanel();
            lblApellido = new Label();
            lblNombre = new Label();
            flpNumSocio = new FlowLayoutPanel();
            lblNumSocio = new Label();
            picLogo = new PictureBox();
            lblFechaValor = new Label();
            lblFechaTitulo = new Label();
            btnImprimir = new Button();
            pdCarnet = new System.Drawing.Printing.PrintDocument();
            dlgImprimirCarnet = new PrintDialog();
            pnlCarnet.SuspendLayout();
            flpInfo.SuspendLayout();
            flpNombreCompleto.SuspendLayout();
            flpNumSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlCarnet
            // 
            pnlCarnet.BackColor = SystemColors.Info;
            pnlCarnet.Controls.Add(flpInfo);
            pnlCarnet.Controls.Add(picLogo);
            pnlCarnet.Controls.Add(lblFechaValor);
            pnlCarnet.Controls.Add(lblFechaTitulo);
            pnlCarnet.Location = new Point(46, 86);
            pnlCarnet.Name = "pnlCarnet";
            pnlCarnet.Size = new Size(682, 240);
            pnlCarnet.TabIndex = 0;
            // 
            // flpInfo
            // 
            flpInfo.Anchor = AnchorStyles.Left;
            flpInfo.Controls.Add(flpNombreCompleto);
            flpInfo.Controls.Add(flpNumSocio);
            flpInfo.FlowDirection = FlowDirection.TopDown;
            flpInfo.Location = new Point(39, 95);
            flpInfo.Name = "flpInfo";
            flpInfo.Size = new Size(368, 108);
            flpInfo.TabIndex = 3;
            // 
            // flpNombreCompleto
            // 
            flpNombreCompleto.Controls.Add(lblApellido);
            flpNombreCompleto.Controls.Add(lblNombre);
            flpNombreCompleto.Location = new Point(3, 3);
            flpNombreCompleto.Name = "flpNombreCompleto";
            flpNombreCompleto.Size = new Size(354, 31);
            flpNombreCompleto.TabIndex = 0;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(3, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(105, 28);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(114, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE";
            // 
            // flpNumSocio
            // 
            flpNumSocio.Anchor = AnchorStyles.Left;
            flpNumSocio.Controls.Add(lblNumSocio);
            flpNumSocio.Location = new Point(3, 40);
            flpNumSocio.Name = "flpNumSocio";
            flpNumSocio.Size = new Size(354, 32);
            flpNumSocio.TabIndex = 1;
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumSocio.Location = new Point(3, 0);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(196, 31);
            lblNumSocio.TabIndex = 0;
            lblNumSocio.Text = "00000000000000";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(440, 95);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(158, 108);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblFechaValor
            // 
            lblFechaValor.AutoSize = true;
            lblFechaValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaValor.Location = new Point(540, 28);
            lblFechaValor.Name = "lblFechaValor";
            lblFechaValor.Size = new Size(94, 28);
            lblFechaValor.TabIndex = 1;
            lblFechaValor.Text = "00/00/00";
            // 
            // lblFechaTitulo
            // 
            lblFechaTitulo.AutoSize = true;
            lblFechaTitulo.Location = new Point(401, 34);
            lblFechaTitulo.Name = "lblFechaTitulo";
            lblFechaTitulo.Size = new Size(124, 20);
            lblFechaTitulo.TabIndex = 0;
            lblFechaTitulo.Text = "FECHA DEL ALTA:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = SystemColors.Desktop;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = SystemColors.ControlLight;
            btnImprimir.Location = new Point(502, 372);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(140, 38);
            btnImprimir.TabIndex = 27;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pdCarnet
            // 
            pdCarnet.DocumentName = "pnlCarnet";
            pdCarnet.EndPrint += pdCarnet_EndPrint;
            pdCarnet.PrintPage += pdCarnet_PrintPage;
            // 
            // dlgImprimirCarnet
            // 
            dlgImprimirCarnet.Document = pdCarnet;
            dlgImprimirCarnet.UseEXDialog = true;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 430);
            Controls.Add(btnImprimir);
            Controls.Add(pnlCarnet);
            Name = "frmCarnet";
            Text = "Carnet";
            Load += frmCarnet_Load;
            pnlCarnet.ResumeLayout(false);
            pnlCarnet.PerformLayout();
            flpInfo.ResumeLayout(false);
            flpNombreCompleto.ResumeLayout(false);
            flpNombreCompleto.PerformLayout();
            flpNumSocio.ResumeLayout(false);
            flpNumSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCarnet;
        private Label lblFechaTitulo;
        private Label lblFechaValor;
        private PictureBox picLogo;
        private FlowLayoutPanel flpInfo;
        private FlowLayoutPanel flpNombreCompleto;
        private Label lblApellido;
        private Label lblNombre;
        private FlowLayoutPanel flpNumSocio;
        private Label lblNumSocio;
        private Button btnImprimir;
        private System.Drawing.Printing.PrintDocument pdCarnet;
        private PrintDialog dlgImprimirCarnet;
    }
}