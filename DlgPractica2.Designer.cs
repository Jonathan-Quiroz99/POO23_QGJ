namespace POO23A_QGJ
{
    partial class DlgPractica2
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
            panel2 = new Panel();
            BtnColision = new Button();
            BtnZombieRomero = new Button();
            BtnZombie = new Button();
            panel1 = new Panel();
            PnlArea = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(BtnColision);
            panel2.Controls.Add(BtnZombieRomero);
            panel2.Controls.Add(BtnZombie);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 450);
            panel2.TabIndex = 3;
            // 
            // BtnColision
            // 
            BtnColision.Location = new Point(3, 162);
            BtnColision.Name = "BtnColision";
            BtnColision.Size = new Size(75, 48);
            BtnColision.TabIndex = 4;
            BtnColision.Text = "Colision";
            BtnColision.UseVisualStyleBackColor = true;
            BtnColision.Click += BtnColision_Click;
            // 
            // BtnZombieRomero
            // 
            BtnZombieRomero.Location = new Point(3, 97);
            BtnZombieRomero.Name = "BtnZombieRomero";
            BtnZombieRomero.Size = new Size(75, 48);
            BtnZombieRomero.TabIndex = 3;
            BtnZombieRomero.Text = "ZR";
            BtnZombieRomero.UseVisualStyleBackColor = true;
            BtnZombieRomero.Click += BtnZombieRomero_Click;
            // 
            // BtnZombie
            // 
            BtnZombie.Location = new Point(3, 34);
            BtnZombie.Name = "BtnZombie";
            BtnZombie.Size = new Size(75, 48);
            BtnZombie.TabIndex = 2;
            BtnZombie.Text = "Z";
            BtnZombie.UseVisualStyleBackColor = true;
            BtnZombie.Click += BtnZombie_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(86, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 66);
            panel1.TabIndex = 4;
            // 
            // PnlArea
            // 
            PnlArea.BackColor = Color.Transparent;
            PnlArea.BackgroundImageLayout = ImageLayout.Stretch;
            PnlArea.Dock = DockStyle.Fill;
            PnlArea.Location = new Point(86, 66);
            PnlArea.Name = "PnlArea";
            PnlArea.Size = new Size(714, 384);
            PnlArea.TabIndex = 5;
            // 
            // DlgPractica2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Practica2_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlArea);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "DlgPractica2";
            Text = "DlgPractica2";
            TransparencyKey = Color.Transparent;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BtnZombie;
        private Panel panel2;
        private Button BtnZombieRomero;
        private Button BtnColision;
        private Panel panel1;
        private Panel PnlArea;
    }
}