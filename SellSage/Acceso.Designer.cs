namespace SellSage
{
    partial class Acceso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            PnlPrincipal = new Panel();
            PnlIzquierdo = new Panel();
            LblInformacionAcceso = new Label();
            TxtUsuario = new TextBox();
            TxtContraseña = new TextBox();
            BtnAcceder = new Button();
            LblMensajeError = new Label();
            LinkLblOlvContraseña = new LinkLabel();
            BtnCerrar = new PictureBox();
            BtnMinimizar = new PictureBox();
            PnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // PnlPrincipal
            // 
            PnlPrincipal.BackColor = Color.FromArgb(15, 15, 15);
            PnlPrincipal.Controls.Add(BtnMinimizar);
            PnlPrincipal.Controls.Add(BtnCerrar);
            PnlPrincipal.Controls.Add(LblMensajeError);
            PnlPrincipal.Controls.Add(LinkLblOlvContraseña);
            PnlPrincipal.Controls.Add(BtnAcceder);
            PnlPrincipal.Controls.Add(TxtContraseña);
            PnlPrincipal.Controls.Add(TxtUsuario);
            PnlPrincipal.Controls.Add(LblInformacionAcceso);
            PnlPrincipal.Controls.Add(PnlIzquierdo);
            PnlPrincipal.Dock = DockStyle.Fill;
            PnlPrincipal.Location = new Point(0, 0);
            PnlPrincipal.Name = "PnlPrincipal";
            PnlPrincipal.Size = new Size(934, 392);
            PnlPrincipal.TabIndex = 0;
            // 
            // PnlIzquierdo
            // 
            PnlIzquierdo.BackColor = Color.FromArgb(1, 46, 64);
            PnlIzquierdo.Dock = DockStyle.Left;
            PnlIzquierdo.Location = new Point(0, 0);
            PnlIzquierdo.Name = "PnlIzquierdo";
            PnlIzquierdo.Size = new Size(272, 392);
            PnlIzquierdo.TabIndex = 0;
            // 
            // LblInformacionAcceso
            // 
            LblInformacionAcceso.AutoSize = true;
            LblInformacionAcceso.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LblInformacionAcceso.ForeColor = Color.DimGray;
            LblInformacionAcceso.Location = new Point(511, 9);
            LblInformacionAcceso.Name = "LblInformacionAcceso";
            LblInformacionAcceso.Size = new Size(191, 49);
            LblInformacionAcceso.TabIndex = 1;
            LblInformacionAcceso.Text = "ACCESO";
            // 
            // TxtUsuario
            // 
            TxtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            TxtUsuario.BorderStyle = BorderStyle.FixedSingle;
            TxtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsuario.ForeColor = Color.DimGray;
            TxtUsuario.Location = new Point(314, 102);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(574, 37);
            TxtUsuario.TabIndex = 2;
            TxtUsuario.Text = "USUARIO";
            // 
            // TxtContraseña
            // 
            TxtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            TxtContraseña.BorderStyle = BorderStyle.FixedSingle;
            TxtContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtContraseña.ForeColor = Color.DimGray;
            TxtContraseña.Location = new Point(314, 166);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.Size = new Size(574, 37);
            TxtContraseña.TabIndex = 3;
            TxtContraseña.Text = "CONTRASEÑA";
            // 
            // BtnAcceder
            // 
            BtnAcceder.BackColor = Color.FromArgb(40, 40, 40);
            BtnAcceder.FlatAppearance.BorderSize = 0;
            BtnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnAcceder.FlatStyle = FlatStyle.Flat;
            BtnAcceder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAcceder.ForeColor = Color.DimGray;
            BtnAcceder.Location = new Point(314, 273);
            BtnAcceder.Name = "BtnAcceder";
            BtnAcceder.Size = new Size(574, 42);
            BtnAcceder.TabIndex = 4;
            BtnAcceder.Text = "ACCEDER";
            BtnAcceder.UseVisualStyleBackColor = false;
            // 
            // LblMensajeError
            // 
            LblMensajeError.AutoSize = true;
            LblMensajeError.Font = new Font("MS Reference Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LblMensajeError.ForeColor = Color.DimGray;
            LblMensajeError.Image = (Image)resources.GetObject("LblMensajeError.Image");
            LblMensajeError.ImageAlign = ContentAlignment.MiddleLeft;
            LblMensajeError.Location = new Point(314, 225);
            LblMensajeError.Name = "LblMensajeError";
            LblMensajeError.Size = new Size(121, 20);
            LblMensajeError.TabIndex = 5;
            LblMensajeError.Text = "Mensaje Error";
            // 
            // LinkLblOlvContraseña
            // 
            LinkLblOlvContraseña.AutoSize = true;
            LinkLblOlvContraseña.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LinkLblOlvContraseña.LinkColor = Color.DimGray;
            LinkLblOlvContraseña.Location = new Point(479, 333);
            LinkLblOlvContraseña.Name = "LinkLblOlvContraseña";
            LinkLblOlvContraseña.Size = new Size(243, 23);
            LinkLblOlvContraseña.TabIndex = 7;
            LinkLblOlvContraseña.TabStop = true;
            LinkLblOlvContraseña.Text = "¿Olvido su contraseña?";
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(892, 9);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(30, 30);
            BtnCerrar.TabIndex = 8;
            BtnCerrar.TabStop = false;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(856, 9);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(30, 30);
            BtnMinimizar.TabIndex = 9;
            BtnMinimizar.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 392);
            Controls.Add(PnlPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PnlPrincipal.ResumeLayout(false);
            PnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlPrincipal;
        private Label LblInformacionAcceso;
        private Panel PnlIzquierdo;
        private TextBox TxtContraseña;
        private TextBox TxtUsuario;
        private Button BtnAcceder;
        private LinkLabel LinkLblOlvContraseña;
        private Label LblMensajeError;
        private PictureBox BtnMinimizar;
        private PictureBox BtnCerrar;
    }
}