namespace GrandDevOpsSanAndreas
{
    partial class Form1
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
            lblCash = new Label();
            lblHour = new Label();
            lblAlt1 = new Label();
            lblAlt2 = new Label();
            lblAlt3 = new Label();
            lblAlt4 = new Label();
            lblQuestion = new Label();
            label7 = new Label();
            pbStars = new PictureBox();
            pictureBox2 = new PictureBox();
            pbHealth = new PictureBox();
            pbVest = new PictureBox();
            pbAlt2 = new PictureBox();
            pbAlt4 = new PictureBox();
            pbAlt3 = new PictureBox();
            pbAlt1 = new PictureBox();
            lblQuestionNum = new Label();
            pbNext = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbStars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHealth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNext).BeginInit();
            SuspendLayout();
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.BackColor = Color.Transparent;
            lblCash.Font = new Font("Pricedown Bl", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCash.Location = new Point(752, 115);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(234, 42);
            lblCash.TabIndex = 5;
            lblCash.Text = "R$0000000000";
            lblCash.TextAlign = ContentAlignment.TopRight;
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.BackColor = Color.Transparent;
            lblHour.Font = new Font("Pricedown Bl", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHour.Location = new Point(856, 24);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(121, 52);
            lblHour.TabIndex = 1;
            lblHour.Text = "09:07";
            // 
            // lblAlt1
            // 
            lblAlt1.BackColor = SystemColors.Control;
            lblAlt1.Font = new Font("Times New Roman", 11.25F);
            lblAlt1.Location = new Point(77, 232);
            lblAlt1.Name = "lblAlt1";
            lblAlt1.Size = new Size(409, 151);
            lblAlt1.TabIndex = 8;
            lblAlt1.Text = "Alternativa 1";
            // 
            // lblAlt2
            // 
            lblAlt2.BackColor = SystemColors.Control;
            lblAlt2.Font = new Font("Times New Roman", 11.25F);
            lblAlt2.Location = new Point(565, 232);
            lblAlt2.Name = "lblAlt2";
            lblAlt2.Size = new Size(409, 151);
            lblAlt2.TabIndex = 9;
            lblAlt2.Text = "Alternativa 2";
            // 
            // lblAlt3
            // 
            lblAlt3.BackColor = SystemColors.Control;
            lblAlt3.Font = new Font("Times New Roman", 11.25F);
            lblAlt3.Location = new Point(77, 423);
            lblAlt3.Name = "lblAlt3";
            lblAlt3.Size = new Size(409, 166);
            lblAlt3.TabIndex = 10;
            lblAlt3.Text = "Alternativa 3";
            // 
            // lblAlt4
            // 
            lblAlt4.BackColor = SystemColors.Control;
            lblAlt4.Font = new Font("Times New Roman", 11.25F);
            lblAlt4.Location = new Point(565, 423);
            lblAlt4.Name = "lblAlt4";
            lblAlt4.Size = new Size(409, 166);
            lblAlt4.TabIndex = 11;
            lblAlt4.Text = "Alternativa 4";
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = SystemColors.Control;
            lblQuestion.Font = new Font("Arial Narrow", 12F);
            lblQuestion.Location = new Point(42, 82);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(681, 120);
            lblQuestion.TabIndex = 12;
            lblQuestion.Text = "PERGUNTA";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 36);
            label7.Name = "label7";
            label7.Size = new Size(152, 42);
            label7.TabIndex = 13;
            label7.Text = "QUESTÃO  - ";
            // 
            // pbStars
            // 
            pbStars.Image = Properties.Resources.police_star_zero;
            pbStars.Location = new Point(761, 154);
            pbStars.Name = "pbStars";
            pbStars.Size = new Size(217, 42);
            pbStars.TabIndex = 18;
            pbStars.TabStop = false;
            pbStars.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.san_andreas_design;
            pictureBox2.Location = new Point(752, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 79);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pbHealth
            // 
            pbHealth.Image = Properties.Resources.energy;
            pbHealth.Location = new Point(858, 105);
            pbHealth.Name = "pbHealth";
            pbHealth.Size = new Size(114, 8);
            pbHealth.TabIndex = 20;
            pbHealth.TabStop = false;
            // 
            // pbVest
            // 
            pbVest.Image = Properties.Resources.vest;
            pbVest.Location = new Point(858, 82);
            pbVest.Name = "pbVest";
            pbVest.Size = new Size(114, 8);
            pbVest.TabIndex = 21;
            pbVest.TabStop = false;
            // 
            // pbAlt2
            // 
            pbAlt2.Image = Properties.Resources.alternative;
            pbAlt2.Location = new Point(517, 217);
            pbAlt2.Name = "pbAlt2";
            pbAlt2.Size = new Size(42, 42);
            pbAlt2.TabIndex = 22;
            pbAlt2.TabStop = false;
            pbAlt2.Click += pbAlt2_Click;
            // 
            // pbAlt4
            // 
            pbAlt4.Image = Properties.Resources.alternative;
            pbAlt4.Location = new Point(517, 409);
            pbAlt4.Name = "pbAlt4";
            pbAlt4.Size = new Size(42, 42);
            pbAlt4.TabIndex = 23;
            pbAlt4.TabStop = false;
            pbAlt4.Click += pbAlt4_Click;
            // 
            // pbAlt3
            // 
            pbAlt3.Image = Properties.Resources.alternative;
            pbAlt3.Location = new Point(29, 409);
            pbAlt3.Name = "pbAlt3";
            pbAlt3.Size = new Size(42, 42);
            pbAlt3.TabIndex = 24;
            pbAlt3.TabStop = false;
            pbAlt3.Click += pbAlt3_Click;
            // 
            // pbAlt1
            // 
            pbAlt1.Image = Properties.Resources.alternative;
            pbAlt1.Location = new Point(29, 217);
            pbAlt1.Name = "pbAlt1";
            pbAlt1.Size = new Size(42, 42);
            pbAlt1.TabIndex = 25;
            pbAlt1.TabStop = false;
            pbAlt1.Click += pbAlt1_Click;
            // 
            // lblQuestionNum
            // 
            lblQuestionNum.BackColor = SystemColors.Control;
            lblQuestionNum.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionNum.Location = new Point(200, 36);
            lblQuestionNum.Name = "lblQuestionNum";
            lblQuestionNum.Size = new Size(123, 42);
            lblQuestionNum.TabIndex = 26;
            lblQuestionNum.Text = "1";
            // 
            // pbNext
            // 
            pbNext.Image = Properties.Resources.next_button;
            pbNext.Location = new Point(840, 622);
            pbNext.Name = "pbNext";
            pbNext.Size = new Size(138, 39);
            pbNext.TabIndex = 27;
            pbNext.TabStop = false;
            pbNext.Visible = false;
            pbNext.Click += pbNext_Click;
            pbNext.MouseEnter += pbNext_MouseEnter;
            pbNext.MouseLeave += pbNext_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 695);
            Controls.Add(pbNext);
            Controls.Add(lblHour);
            Controls.Add(lblQuestionNum);
            Controls.Add(pbAlt1);
            Controls.Add(pbAlt3);
            Controls.Add(pbAlt4);
            Controls.Add(pbHealth);
            Controls.Add(label7);
            Controls.Add(lblQuestion);
            Controls.Add(lblAlt4);
            Controls.Add(lblAlt3);
            Controls.Add(lblAlt2);
            Controls.Add(lblAlt1);
            Controls.Add(lblCash);
            Controls.Add(pbStars);
            Controls.Add(pbVest);
            Controls.Add(pictureBox2);
            Controls.Add(pbAlt2);
            Name = "Form1";
            Text = "Grand DevOps San Andreas v1.0 | ByteGenius Group";
            ((System.ComponentModel.ISupportInitialize)pbStars).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHealth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVest).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAlt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCash;
        private Label lblHour;
        private Label lblAlt1;
        private Label lblAlt2;
        private Label lblAlt3;
        private Label lblAlt4;
        private Label lblQuestion;
        private Label label7;
        private PictureBox pbStars;
        private PictureBox pictureBox2;
        private PictureBox pbHealth;
        private PictureBox pbVest;
        private PictureBox pbAlt2;
        private PictureBox pbAlt4;
        private PictureBox pbAlt3;
        private PictureBox pbAlt1;
        private Label lblQuestionNum;
        private PictureBox pbNext;
    }
}
