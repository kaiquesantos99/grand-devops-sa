namespace GrandDevOpsSanAndreas
{
    partial class CheatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheatWindow));
            txtPalavraChave = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            lblQuestaoBuscada = new Label();
            lblRespostaCorreta = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPalavraChave
            // 
            txtPalavraChave.Location = new Point(108, 12);
            txtPalavraChave.Name = "txtPalavraChave";
            txtPalavraChave.Size = new Size(463, 23);
            txtPalavraChave.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Palavra Chave:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.busca;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Location = new Point(577, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(23, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(lblQuestaoBuscada, 0, 1);
            tableLayoutPanel1.Controls.Add(lblRespostaCorreta, 1, 1);
            tableLayoutPanel1.Location = new Point(18, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81F));
            tableLayoutPanel1.Size = new Size(660, 241);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(4, 1);
            label2.Name = "label2";
            label2.Size = new Size(322, 45);
            label2.TabIndex = 0;
            label2.Text = "QUESTÃO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(333, 1);
            label3.Name = "label3";
            label3.Size = new Size(323, 45);
            label3.TabIndex = 1;
            label3.Text = "RESPOSTA";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQuestaoBuscada
            // 
            lblQuestaoBuscada.AutoSize = true;
            lblQuestaoBuscada.Dock = DockStyle.Fill;
            lblQuestaoBuscada.Location = new Point(4, 47);
            lblQuestaoBuscada.Name = "lblQuestaoBuscada";
            lblQuestaoBuscada.Size = new Size(322, 193);
            lblQuestaoBuscada.TabIndex = 2;
            lblQuestaoBuscada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRespostaCorreta
            // 
            lblRespostaCorreta.AutoSize = true;
            lblRespostaCorreta.Dock = DockStyle.Fill;
            lblRespostaCorreta.Location = new Point(333, 47);
            lblRespostaCorreta.Name = "lblRespostaCorreta";
            lblRespostaCorreta.Size = new Size(323, 193);
            lblRespostaCorreta.TabIndex = 3;
            lblRespostaCorreta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheatWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 312);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(txtPalavraChave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CheatWindow";
            Text = "CheatWindow";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalavraChave;
        private Label label1;
        private Button btnBuscar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label lblQuestaoBuscada;
        private Label lblRespostaCorreta;
    }
}