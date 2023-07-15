namespace SecimUygulamasi
{
    partial class OyGirisFormu
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
            label1 = new Label();
            tbxIlce = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            tbxA = new TextBox();
            label4 = new Label();
            tbxB = new TextBox();
            label5 = new Label();
            tbxC = new TextBox();
            label6 = new Label();
            tbxD = new TextBox();
            label7 = new Label();
            tbxE = new TextBox();
            btnYolla = new Button();
            btnGrafik = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "İlçe Adı : ";
            // 
            // tbxIlce
            // 
            tbxIlce.Location = new Point(110, 21);
            tbxIlce.Name = "tbxIlce";
            tbxIlce.Size = new Size(125, 27);
            tbxIlce.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "A Parti :";
            // 
            // tbxA
            // 
            tbxA.Location = new Point(110, 86);
            tbxA.Name = "tbxA";
            tbxA.Size = new Size(125, 27);
            tbxA.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 122);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "B Parti :";
            // 
            // tbxB
            // 
            tbxB.Location = new Point(110, 119);
            tbxB.Name = "tbxB";
            tbxB.Size = new Size(125, 27);
            tbxB.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 155);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 2;
            label5.Text = "C Parti :";
            // 
            // tbxC
            // 
            tbxC.Location = new Point(110, 152);
            tbxC.Name = "tbxC";
            tbxC.Size = new Size(125, 27);
            tbxC.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 188);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 2;
            label6.Text = "D Parti :";
            // 
            // tbxD
            // 
            tbxD.Location = new Point(110, 185);
            tbxD.Name = "tbxD";
            tbxD.Size = new Size(125, 27);
            tbxD.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 221);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 2;
            label7.Text = "E Parti :";
            // 
            // tbxE
            // 
            tbxE.Location = new Point(110, 218);
            tbxE.Name = "tbxE";
            tbxE.Size = new Size(125, 27);
            tbxE.TabIndex = 3;
            // 
            // btnYolla
            // 
            btnYolla.Location = new Point(110, 251);
            btnYolla.Name = "btnYolla";
            btnYolla.Size = new Size(125, 29);
            btnYolla.TabIndex = 4;
            btnYolla.Text = "Yolla";
            btnYolla.UseVisualStyleBackColor = true;
            btnYolla.Click += btnYolla_Click;
            // 
            // btnGrafik
            // 
            btnGrafik.Location = new Point(24, 286);
            btnGrafik.Name = "btnGrafik";
            btnGrafik.Size = new Size(100, 29);
            btnGrafik.TabIndex = 4;
            btnGrafik.Text = "Grafikler";
            btnGrafik.UseVisualStyleBackColor = true;
            btnGrafik.Click += btnGrafik_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(135, 286);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(100, 29);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // OyGirisFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 332);
            Controls.Add(btnCikis);
            Controls.Add(btnGrafik);
            Controls.Add(btnYolla);
            Controls.Add(tbxE);
            Controls.Add(label7);
            Controls.Add(tbxD);
            Controls.Add(label6);
            Controls.Add(tbxC);
            Controls.Add(label5);
            Controls.Add(tbxB);
            Controls.Add(label4);
            Controls.Add(tbxA);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(tbxIlce);
            Controls.Add(label1);
            Name = "OyGirisFormu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxIlce;
        private TextBox textBox2;
        private Label label2;
        private TextBox tbxA;
        private Label label4;
        private TextBox tbxB;
        private Label label5;
        private TextBox tbxC;
        private Label label6;
        private TextBox tbxD;
        private Label label7;
        private TextBox tbxE;
        private Button btnYolla;
        private Button btnGrafik;
        private Button btnCikis;
    }
}