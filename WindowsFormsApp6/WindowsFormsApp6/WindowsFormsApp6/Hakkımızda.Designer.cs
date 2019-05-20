namespace WindowsFormsApp6
{
    partial class Hakkımızda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakkımızda));
            this.button4 = new System.Windows.Forms.Button();
            this.button_Hakkımızda = new System.Windows.Forms.Button();
            this.button_Araclarımız = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(698, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "İLETİŞİM";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button_Hakkımızda
            // 
            this.button_Hakkımızda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Hakkımızda.Location = new System.Drawing.Point(578, 9);
            this.button_Hakkımızda.Name = "button_Hakkımızda";
            this.button_Hakkımızda.Size = new System.Drawing.Size(89, 35);
            this.button_Hakkımızda.TabIndex = 7;
            this.button_Hakkımızda.Text = "HAKKIMIZDA";
            this.button_Hakkımızda.UseVisualStyleBackColor = false;
            this.button_Hakkımızda.Click += new System.EventHandler(this.Button_Hakkımızda_Click);
            // 
            // button_Araclarımız
            // 
            this.button_Araclarımız.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Araclarımız.Location = new System.Drawing.Point(129, 9);
            this.button_Araclarımız.Name = "button_Araclarımız";
            this.button_Araclarımız.Size = new System.Drawing.Size(87, 35);
            this.button_Araclarımız.TabIndex = 6;
            this.button_Araclarımız.Text = "ARAÇLARIMIZ";
            this.button_Araclarımız.UseVisualStyleBackColor = false;
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAnasayfa.Location = new System.Drawing.Point(5, 9);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(83, 35);
            this.buttonAnasayfa.TabIndex = 5;
            this.buttonAnasayfa.Text = "ANA SAYFA";
            this.buttonAnasayfa.UseVisualStyleBackColor = false;
            this.buttonAnasayfa.Click += new System.EventHandler(this.ButtonAnasayfa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(231, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Hakkımızda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.araçarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_Hakkımızda);
            this.Controls.Add(this.button_Araclarımız);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hakkımızda";
            this.Text = "Hakkımızda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Hakkımızda;
        private System.Windows.Forms.Button button_Araclarımız;
        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}