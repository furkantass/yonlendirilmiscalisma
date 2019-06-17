namespace WindowsFormsApp6
{
    partial class KiralamaKosulları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiralamaKosulları));
            this.button4 = new System.Windows.Forms.Button();
            this.button_Araclarımız = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_KİRALAMAKOŞ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(937, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 43);
            this.button4.TabIndex = 13;
            this.button4.Text = "İLETİŞİM";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button_Araclarımız
            // 
            this.button_Araclarımız.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Araclarımız.Location = new System.Drawing.Point(179, 14);
            this.button_Araclarımız.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Araclarımız.Name = "button_Araclarımız";
            this.button_Araclarımız.Size = new System.Drawing.Size(116, 43);
            this.button_Araclarımız.TabIndex = 11;
            this.button_Araclarımız.Text = "ARAÇLARIMIZ";
            this.button_Araclarımız.UseVisualStyleBackColor = false;
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAnasayfa.Location = new System.Drawing.Point(13, 14);
            this.buttonAnasayfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(111, 43);
            this.buttonAnasayfa.TabIndex = 10;
            this.buttonAnasayfa.Text = "ANA SAYFA";
            this.buttonAnasayfa.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(315, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button_KİRALAMAKOŞ
            // 
            this.button_KİRALAMAKOŞ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_KİRALAMAKOŞ.Location = new System.Drawing.Point(792, 14);
            this.button_KİRALAMAKOŞ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_KİRALAMAKOŞ.Name = "button_KİRALAMAKOŞ";
            this.button_KİRALAMAKOŞ.Size = new System.Drawing.Size(119, 43);
            this.button_KİRALAMAKOŞ.TabIndex = 62;
            this.button_KİRALAMAKOŞ.Text = "KİRALAMA KOŞULLARI";
            this.button_KİRALAMAKOŞ.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.KİRALAMAKOŞULLARI;
            this.panel1.Location = new System.Drawing.Point(115, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 262);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.oto_kiralama_kosullari;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(391, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 64;
            // 
            // KiralamaKosulları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.araçarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_KİRALAMAKOŞ);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Araclarımız);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KiralamaKosulları";
            this.Text = "Kiralama Kosulları";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Araclarımız;
        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_KİRALAMAKOŞ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}