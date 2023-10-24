namespace POO23A_QGJ
{
    partial class DlgPractica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica1));
            BtnCalculadora3V = new Button();
            BtnCalculadora100I = new Button();
            BtnFigura = new Button();
            ExitBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            SuspendLayout();
            // 
            // BtnCalculadora3V
            // 
            BtnCalculadora3V.Location = new Point(32, 42);
            BtnCalculadora3V.Name = "BtnCalculadora3V";
            BtnCalculadora3V.Size = new Size(236, 61);
            BtnCalculadora3V.TabIndex = 0;
            BtnCalculadora3V.Text = "Calculadora de 3 V";
            BtnCalculadora3V.UseVisualStyleBackColor = true;
            BtnCalculadora3V.Click += BtnCalculadora_Click;
            // 
            // BtnCalculadora100I
            // 
            BtnCalculadora100I.Location = new Point(32, 155);
            BtnCalculadora100I.Name = "BtnCalculadora100I";
            BtnCalculadora100I.Size = new Size(236, 51);
            BtnCalculadora100I.TabIndex = 1;
            BtnCalculadora100I.Text = "calculadora de 100 - I";
            BtnCalculadora100I.UseVisualStyleBackColor = true;
            BtnCalculadora100I.Click += BtnCalculadora100I_Click;
            // 
            // BtnFigura
            // 
            BtnFigura.Location = new Point(32, 241);
            BtnFigura.Name = "BtnFigura";
            BtnFigura.Size = new Size(236, 53);
            BtnFigura.TabIndex = 2;
            BtnFigura.Text = "Figura";
            BtnFigura.UseVisualStyleBackColor = true;
            BtnFigura.Click += BtnFigura_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Black;
            ExitBtn.BackgroundImage = (Image)resources.GetObject("ExitBtn.BackgroundImage");
            ExitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ExitBtn.Location = new Point(608, 30);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(100, 50);
            ExitBtn.TabIndex = 3;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // DlgPractica1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 417);
            Controls.Add(ExitBtn);
            Controls.Add(BtnFigura);
            Controls.Add(BtnCalculadora100I);
            Controls.Add(BtnCalculadora3V);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DlgPractica1";
            Text = "Practica1";
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCalculadora3V;
        private Button BtnCalculadora100I;
        private Button BtnFigura;
        private PictureBox ExitBtn;
    }
}