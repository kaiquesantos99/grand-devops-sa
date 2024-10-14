namespace GrandDevOpsSanAndreas
{
    partial class MissaoConcluida
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
            lblAcertos = new Label();
            lblErros = new Label();
            SuspendLayout();
            // 
            // lblAcertos
            // 
            lblAcertos.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcertos.Location = new Point(104, 240);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(149, 23);
            lblAcertos.TabIndex = 0;
            lblAcertos.Text = "0";
            lblAcertos.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblErros
            // 
            lblErros.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErros.Location = new Point(360, 240);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(149, 23);
            lblErros.TabIndex = 1;
            lblErros.Text = "0";
            lblErros.TextAlign = ContentAlignment.TopCenter;
            // 
            // MissaoConcluida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tela_final;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(613, 314);
            Controls.Add(lblErros);
            Controls.Add(lblAcertos);
            DoubleBuffered = true;
            Name = "MissaoConcluida";
            Text = "MissaoConcluida";
            ResumeLayout(false);
        }

        #endregion

        private Label lblAcertos;
        private Label lblErros;
    }
}