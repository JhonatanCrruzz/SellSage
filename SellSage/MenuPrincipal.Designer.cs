namespace SellSage
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            PnlListaMenu = new Panel();
            PnlBarraSuperior = new Panel();
            BtnCerrar = new PictureBox();
            BtnMaximizar = new PictureBox();
            BtnRestaurar = new PictureBox();
            BtnMinimizar = new PictureBox();
            LblNomUsuario = new Label();
            LblCargo = new Label();
            LblCorreo = new Label();
            BtnMenu = new PictureBox();
            PnlListaMenu.SuspendLayout();
            PnlBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMenu).BeginInit();
            SuspendLayout();
            // 
            // PnlListaMenu
            // 
            PnlListaMenu.BackColor = Color.FromArgb(4, 41, 68);
            PnlListaMenu.Controls.Add(LblCorreo);
            PnlListaMenu.Controls.Add(LblCargo);
            PnlListaMenu.Controls.Add(LblNomUsuario);
            PnlListaMenu.Dock = DockStyle.Left;
            PnlListaMenu.Location = new Point(0, 0);
            PnlListaMenu.Name = "PnlListaMenu";
            PnlListaMenu.Size = new Size(300, 768);
            PnlListaMenu.TabIndex = 0;
            // 
            // PnlBarraSuperior
            // 
            PnlBarraSuperior.BackColor = Color.FromArgb(13, 93, 142);
            PnlBarraSuperior.Controls.Add(BtnMenu);
            PnlBarraSuperior.Controls.Add(BtnMinimizar);
            PnlBarraSuperior.Controls.Add(BtnRestaurar);
            PnlBarraSuperior.Controls.Add(BtnMaximizar);
            PnlBarraSuperior.Controls.Add(BtnCerrar);
            PnlBarraSuperior.Dock = DockStyle.Top;
            PnlBarraSuperior.Location = new Point(300, 0);
            PnlBarraSuperior.Name = "PnlBarraSuperior";
            PnlBarraSuperior.Size = new Size(928, 40);
            PnlBarraSuperior.TabIndex = 1;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCerrar.Cursor = Cursors.Hand;
            BtnCerrar.Image = (Image)resources.GetObject("BtnCerrar.Image");
            BtnCerrar.Location = new Point(895, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(30, 30);
            BtnCerrar.TabIndex = 9;
            BtnCerrar.TabStop = false;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Cursor = Cursors.Hand;
            BtnMaximizar.Image = (Image)resources.GetObject("BtnMaximizar.Image");
            BtnMaximizar.Location = new Point(859, 3);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(30, 30);
            BtnMaximizar.TabIndex = 10;
            BtnMaximizar.TabStop = false;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Cursor = Cursors.Hand;
            BtnRestaurar.Image = (Image)resources.GetObject("BtnRestaurar.Image");
            BtnRestaurar.Location = new Point(823, 3);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(30, 30);
            BtnRestaurar.TabIndex = 11;
            BtnRestaurar.TabStop = false;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(787, 3);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(30, 30);
            BtnMinimizar.TabIndex = 12;
            BtnMinimizar.TabStop = false;
            // 
            // LblNomUsuario
            // 
            LblNomUsuario.AutoSize = true;
            LblNomUsuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblNomUsuario.Location = new Point(107, 19);
            LblNomUsuario.Name = "LblNomUsuario";
            LblNomUsuario.Size = new Size(62, 21);
            LblNomUsuario.TabIndex = 0;
            LblNomUsuario.Text = "label1";
            // 
            // LblCargo
            // 
            LblCargo.AutoSize = true;
            LblCargo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblCargo.Location = new Point(107, 40);
            LblCargo.Name = "LblCargo";
            LblCargo.Size = new Size(62, 21);
            LblCargo.TabIndex = 1;
            LblCargo.Text = "label1";
            // 
            // LblCorreo
            // 
            LblCorreo.AutoSize = true;
            LblCorreo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblCorreo.Location = new Point(107, 61);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new Size(62, 21);
            LblCorreo.TabIndex = 2;
            LblCorreo.Text = "label1";
            // 
            // BtnMenu
            // 
            BtnMenu.Cursor = Cursors.Hand;
            BtnMenu.Image = (Image)resources.GetObject("BtnMenu.Image");
            BtnMenu.Location = new Point(6, 7);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(30, 30);
            BtnMenu.TabIndex = 13;
            BtnMenu.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 768);
            Controls.Add(PnlBarraSuperior);
            Controls.Add(PnlListaMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            PnlListaMenu.ResumeLayout(false);
            PnlListaMenu.PerformLayout();
            PnlBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlListaMenu;
        private Panel PnlBarraSuperior;
        private PictureBox BtnMinimizar;
        private PictureBox BtnRestaurar;
        private PictureBox BtnMaximizar;
        private PictureBox BtnCerrar;
        private Label LblCorreo;
        private Label LblCargo;
        private Label LblNomUsuario;
        private PictureBox BtnMenu;
    }
}