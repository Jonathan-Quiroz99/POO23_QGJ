namespace POO23A_QGJ
{
    partial class DlgPrinicpal
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
            LblPractica1 = new Label();
            PbPractica1 = new PictureBox();
            PbPractica2 = new PictureBox();
            PbPractica3 = new PictureBox();
            PbBackground = new PictureBox();
            LblPractica2 = new Label();
            LblPractica3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PbPractica1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPractica2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPractica3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbBackground).BeginInit();
            SuspendLayout();
            // 
            // LblPractica1
            // 
            LblPractica1.AutoSize = true;
            LblPractica1.BackColor = Color.Transparent;
            LblPractica1.ForeColor = Color.White;
            LblPractica1.Location = new Point(32, 328);
            LblPractica1.Name = "LblPractica1";
            LblPractica1.Size = new Size(0, 15);
            LblPractica1.TabIndex = 3;
            // 
            // PbPractica1
            // 
            PbPractica1.BackColor = Color.Transparent;
            PbPractica1.BackgroundImageLayout = ImageLayout.Stretch;
            PbPractica1.Location = new Point(25, 339);
            PbPractica1.Name = "PbPractica1";
            PbPractica1.Size = new Size(51, 166);
            PbPractica1.TabIndex = 13;
            PbPractica1.TabStop = false;
            PbPractica1.Click += BtnPractica1_Click;
            PbPractica1.MouseEnter += PnlPractica1_MouseEnter;
            PbPractica1.MouseLeave += PnlPractica1_MouseLeave;
            // 
            // PbPractica2
            // 
            PbPractica2.BackColor = Color.Transparent;
            PbPractica2.BackgroundImageLayout = ImageLayout.Stretch;
            PbPractica2.Location = new Point(55, 329);
            PbPractica2.Name = "PbPractica2";
            PbPractica2.Size = new Size(67, 187);
            PbPractica2.TabIndex = 14;
            PbPractica2.TabStop = false;
            PbPractica2.Click += PbPractica2_Click;
            PbPractica2.MouseEnter += PbPractica2_MouseEnter;
            PbPractica2.MouseLeave += PbPractica2_MouseLeave;
            // 
            // PbPractica3
            // 
            PbPractica3.BackColor = Color.Transparent;
            PbPractica3.BackgroundImageLayout = ImageLayout.Stretch;
            PbPractica3.Location = new Point(108, 345);
            PbPractica3.Name = "PbPractica3";
            PbPractica3.Size = new Size(63, 188);
            PbPractica3.TabIndex = 15;
            PbPractica3.TabStop = false;
            PbPractica3.MouseEnter += PbPractica3_MouseEnter;
            PbPractica3.MouseLeave += PbPractica3_MouseLeave;
            // 
            // PbBackground
            // 
            PbBackground.BackColor = Color.White;
            PbBackground.BackgroundImageLayout = ImageLayout.Stretch;
            PbBackground.Dock = DockStyle.Fill;
            PbBackground.Image = Properties.Resources.neon_city_3_0;
            PbBackground.Location = new Point(0, 0);
            PbBackground.Name = "PbBackground";
            PbBackground.Size = new Size(800, 691);
            PbBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            PbBackground.TabIndex = 16;
            PbBackground.TabStop = false;
            // 
            // LblPractica2
            // 
            LblPractica2.AutoSize = true;
            LblPractica2.BackColor = Color.Transparent;
            LblPractica2.ForeColor = Color.White;
            LblPractica2.Location = new Point(72, 328);
            LblPractica2.Name = "LblPractica2";
            LblPractica2.Size = new Size(0, 15);
            LblPractica2.TabIndex = 17;
            // 
            // LblPractica3
            // 
            LblPractica3.AutoSize = true;
            LblPractica3.BackColor = Color.Transparent;
            LblPractica3.ForeColor = Color.White;
            LblPractica3.Location = new Point(120, 335);
            LblPractica3.Name = "LblPractica3";
            LblPractica3.Size = new Size(0, 15);
            LblPractica3.TabIndex = 18;
            // 
            // DlgPrinicpal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.neon_city_3_0;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 691);
            Controls.Add(LblPractica3);
            Controls.Add(LblPractica2);
            Controls.Add(PbPractica2);
            Controls.Add(PbPractica1);
            Controls.Add(PbPractica3);
            Controls.Add(LblPractica1);
            Controls.Add(PbBackground);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DlgPrinicpal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programacion Orientada a Objetos 2023A";
            ((System.ComponentModel.ISupportInitialize)PbPractica1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPractica2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPractica3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblPractica1;
        private PictureBox PbPractica1;
        private PictureBox PbPractica2;
        private PictureBox PbPractica3;
        private PictureBox PbBackground;
        private Label LblPractica2;
        private Label LblPractica3;
    }
}