namespace GrandDevOpsSanAndreas
{
    partial class Store
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
            pbBis = new PictureBox();
            pbTapioca = new PictureBox();
            pbMilho = new PictureBox();
            pbCola = new PictureBox();
            pbBook = new PictureBox();
            lblBisValor = new Label();
            lblMilhoValor = new Label();
            lblTapiocaValor = new Label();
            lblColaValor = new Label();
            lblBookValor = new Label();
            ((System.ComponentModel.ISupportInitialize)pbBis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTapioca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMilho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBook).BeginInit();
            SuspendLayout();
            // 
            // pbBis
            // 
            pbBis.Image = Properties.Resources.bis;
            pbBis.Location = new Point(303, 106);
            pbBis.Name = "pbBis";
            pbBis.Size = new Size(91, 30);
            pbBis.TabIndex = 0;
            pbBis.TabStop = false;
            pbBis.Click += pbBis_Click;
            pbBis.MouseEnter += pbBis_MouseEnter;
            pbBis.MouseLeave += pbBis_MouseLeave;
            // 
            // pbTapioca
            // 
            pbTapioca.Image = Properties.Resources.tapioca;
            pbTapioca.Location = new Point(409, 102);
            pbTapioca.Name = "pbTapioca";
            pbTapioca.Size = new Size(55, 36);
            pbTapioca.TabIndex = 1;
            pbTapioca.TabStop = false;
            pbTapioca.Click += pbTapioca_Click;
            pbTapioca.MouseEnter += pbTapioca_MouseEnter;
            pbTapioca.MouseLeave += pbTapioca_MouseLeave;
            // 
            // pbMilho
            // 
            pbMilho.Image = Properties.Resources.milho;
            pbMilho.Location = new Point(488, 106);
            pbMilho.Name = "pbMilho";
            pbMilho.Size = new Size(62, 32);
            pbMilho.TabIndex = 2;
            pbMilho.TabStop = false;
            pbMilho.Click += pbMilho_Click;
            pbMilho.MouseEnter += pbMilho_MouseEnter;
            pbMilho.MouseLeave += pbMilho_MouseLeave;
            // 
            // pbCola
            // 
            pbCola.Image = Properties.Resources.cola;
            pbCola.Location = new Point(335, 171);
            pbCola.Name = "pbCola";
            pbCola.Size = new Size(20, 69);
            pbCola.TabIndex = 3;
            pbCola.TabStop = false;
            pbCola.Click += pbCola_Click;
            pbCola.MouseEnter += pbCola_MouseEnter;
            pbCola.MouseLeave += pbCola_MouseLeave;
            // 
            // pbBook
            // 
            pbBook.Image = Properties.Resources.book;
            pbBook.Location = new Point(409, 171);
            pbBook.Name = "pbBook";
            pbBook.Size = new Size(104, 69);
            pbBook.TabIndex = 4;
            pbBook.TabStop = false;
            pbBook.Click += pbBook_Click;
            pbBook.MouseEnter += pbBook_MouseEnter;
            pbBook.MouseLeave += pbBook_MouseLeave;
            // 
            // lblBisValor
            // 
            lblBisValor.AutoSize = true;
            lblBisValor.Location = new Point(326, 78);
            lblBisValor.Name = "lblBisValor";
            lblBisValor.Size = new Size(32, 15);
            lblBisValor.TabIndex = 5;
            lblBisValor.Text = "R$15";
            lblBisValor.Visible = false;
            // 
            // lblMilhoValor
            // 
            lblMilhoValor.AutoSize = true;
            lblMilhoValor.Location = new Point(501, 78);
            lblMilhoValor.Name = "lblMilhoValor";
            lblMilhoValor.Size = new Size(32, 15);
            lblMilhoValor.TabIndex = 6;
            lblMilhoValor.Text = "R$20";
            lblMilhoValor.Visible = false;
            // 
            // lblTapiocaValor
            // 
            lblTapiocaValor.AutoSize = true;
            lblTapiocaValor.Location = new Point(419, 78);
            lblTapiocaValor.Name = "lblTapiocaValor";
            lblTapiocaValor.Size = new Size(38, 15);
            lblTapiocaValor.TabIndex = 7;
            lblTapiocaValor.Text = "R$100";
            lblTapiocaValor.Visible = false;
            // 
            // lblColaValor
            // 
            lblColaValor.AutoSize = true;
            lblColaValor.Location = new Point(326, 243);
            lblColaValor.Name = "lblColaValor";
            lblColaValor.Size = new Size(32, 15);
            lblColaValor.TabIndex = 8;
            lblColaValor.Text = "R$10";
            lblColaValor.Visible = false;
            // 
            // lblBookValor
            // 
            lblBookValor.AutoSize = true;
            lblBookValor.Location = new Point(444, 243);
            lblBookValor.Name = "lblBookValor";
            lblBookValor.Size = new Size(38, 15);
            lblBookValor.TabIndex = 9;
            lblBookValor.Text = "R$200";
            lblBookValor.Visible = false;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mercado;
            ClientSize = new Size(674, 332);
            Controls.Add(lblBookValor);
            Controls.Add(lblColaValor);
            Controls.Add(lblTapiocaValor);
            Controls.Add(lblMilhoValor);
            Controls.Add(lblBisValor);
            Controls.Add(pbBook);
            Controls.Add(pbCola);
            Controls.Add(pbMilho);
            Controls.Add(pbTapioca);
            Controls.Add(pbBis);
            Name = "Store";
            Text = "Store";
            ((System.ComponentModel.ISupportInitialize)pbBis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTapioca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMilho).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCola).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbBis;
        private PictureBox pbTapioca;
        private PictureBox pbMilho;
        private PictureBox pbCola;
        private PictureBox pbBook;
        private Label lblBisValor;
        private Label lblMilhoValor;
        private Label lblTapiocaValor;
        private Label lblColaValor;
        private Label lblBookValor;
    }
}