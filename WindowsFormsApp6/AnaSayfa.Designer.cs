namespace WindowsFormsApp6
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.button_Araclarimiz = new System.Windows.Forms.Button();
            this.button_KİRALAMAKOŞ = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonARACYONLENDIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAnasayfa.Location = new System.Drawing.Point(12, 12);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(83, 35);
            this.buttonAnasayfa.TabIndex = 0;
            this.buttonAnasayfa.Text = "ANA SAYFA";
            this.buttonAnasayfa.UseVisualStyleBackColor = false;
            this.buttonAnasayfa.Click += new System.EventHandler(this.ButtonAnasayfa_Click);
            // 
            // button_Araclarimiz
            // 
            this.button_Araclarimiz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Araclarimiz.Location = new System.Drawing.Point(136, 12);
            this.button_Araclarimiz.Name = "button_Araclarimiz";
            this.button_Araclarimiz.Size = new System.Drawing.Size(87, 35);
            this.button_Araclarimiz.TabIndex = 1;
            this.button_Araclarimiz.Text = "ARAÇLARIMIZ";
            this.button_Araclarimiz.UseVisualStyleBackColor = false;
            this.button_Araclarimiz.Click += new System.EventHandler(this.Button_Araclarimiz_Click);
            // 
            // button_KİRALAMAKOŞ
            // 
            this.button_KİRALAMAKOŞ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_KİRALAMAKOŞ.Location = new System.Drawing.Point(585, 12);
            this.button_KİRALAMAKOŞ.Name = "button_KİRALAMAKOŞ";
            this.button_KİRALAMAKOŞ.Size = new System.Drawing.Size(89, 35);
            this.button_KİRALAMAKOŞ.TabIndex = 2;
            this.button_KİRALAMAKOŞ.Text = "KİRALAMA KOŞULLARI";
            this.button_KİRALAMAKOŞ.UseVisualStyleBackColor = false;
            this.button_KİRALAMAKOŞ.Click += new System.EventHandler(this.button_Hakkımızda_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(705, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "İLETİŞİM";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.kullanıcıodaklı1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(297, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 153);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.Polo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(27, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 176);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.Honda;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(524, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 176);
            this.panel2.TabIndex = 10;
            // 
            // buttonARACYONLENDIR
            // 
            this.buttonARACYONLENDIR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonARACYONLENDIR.Location = new System.Drawing.Point(324, 274);
            this.buttonARACYONLENDIR.Name = "buttonARACYONLENDIR";
            this.buttonARACYONLENDIR.Size = new System.Drawing.Size(148, 66);
            this.buttonARACYONLENDIR.TabIndex = 11;
            this.buttonARACYONLENDIR.Text = "DAHA FAZLASI İÇİN TIKLAYINIZ";
            this.buttonARACYONLENDIR.UseVisualStyleBackColor = false;
            this.buttonARACYONLENDIR.Click += new System.EventHandler(this.ButtonARACYONLENDIR_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonARACYONLENDIR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_KİRALAMAKOŞ);
            this.Controls.Add(this.button_Araclarimiz);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnaSayfa";
            this.Text = "Furkan Rent A Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.Button button_Araclarimiz;
        private System.Windows.Forms.Button button_KİRALAMAKOŞ;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonARACYONLENDIR;
    }
}

