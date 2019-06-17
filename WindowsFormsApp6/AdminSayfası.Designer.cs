namespace WindowsFormsApp6
{
    partial class AdminSayfası
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
            this.buttonMusteriListele = new System.Windows.Forms.Button();
            this.buttonAracListele = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMusteriListele
            // 
            this.buttonMusteriListele.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMusteriListele.Location = new System.Drawing.Point(551, 357);
            this.buttonMusteriListele.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMusteriListele.Name = "buttonMusteriListele";
            this.buttonMusteriListele.Size = new System.Drawing.Size(111, 59);
            this.buttonMusteriListele.TabIndex = 2;
            this.buttonMusteriListele.Text = "MÜŞTERİ DÜZENLE";
            this.buttonMusteriListele.UseVisualStyleBackColor = false;
            this.buttonMusteriListele.Click += new System.EventHandler(this.ButtonMusteriListele_Click);
            // 
            // buttonAracListele
            // 
            this.buttonAracListele.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAracListele.Location = new System.Drawing.Point(388, 357);
            this.buttonAracListele.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAracListele.Name = "buttonAracListele";
            this.buttonAracListele.Size = new System.Drawing.Size(116, 59);
            this.buttonAracListele.TabIndex = 5;
            this.buttonAracListele.Text = "ARAÇ DÜZENLE";
            this.buttonAracListele.UseVisualStyleBackColor = false;
            this.buttonAracListele.Click += new System.EventHandler(this.ButtonAracListele_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.kullanıcıodaklı1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(388, 80);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 188);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.yönetici;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(497, 293);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 52);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(53, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 50);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "YÖNETİCİ PANELİ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(388, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 54);
            this.panel3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.gmailicon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(990, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AdminSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.araçarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonAracListele);
            this.Controls.Add(this.buttonMusteriListele);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminSayfası";
            this.Text = "AdminSayfası";
            this.Load += new System.EventHandler(this.AdminSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMusteriListele;
        private System.Windows.Forms.Button buttonAracListele;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}