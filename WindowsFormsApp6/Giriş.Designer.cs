namespace WindowsFormsApp6
{
    partial class Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttongırıs = new System.Windows.Forms.Button();
            this.buttonkayıtol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYöneticiGirisi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(253, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttongırıs
            // 
            this.buttongırıs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttongırıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttongırıs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttongırıs.Location = new System.Drawing.Point(178, 269);
            this.buttongırıs.Margin = new System.Windows.Forms.Padding(4);
            this.buttongırıs.Name = "buttongırıs";
            this.buttongırıs.Size = new System.Drawing.Size(119, 38);
            this.buttongırıs.TabIndex = 1;
            this.buttongırıs.Text = "GİRİŞ";
            this.buttongırıs.UseVisualStyleBackColor = false;
            this.buttongırıs.Click += new System.EventHandler(this.buttongırıs_Click);
            // 
            // buttonkayıtol
            // 
            this.buttonkayıtol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonkayıtol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonkayıtol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkayıtol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonkayıtol.Location = new System.Drawing.Point(339, 269);
            this.buttonkayıtol.Margin = new System.Windows.Forms.Padding(4);
            this.buttonkayıtol.Name = "buttonkayıtol";
            this.buttonkayıtol.Size = new System.Drawing.Size(119, 38);
            this.buttonkayıtol.TabIndex = 2;
            this.buttonkayıtol.Text = "KAYIT OL";
            this.buttonkayıtol.UseVisualStyleBackColor = false;
            this.buttonkayıtol.Click += new System.EventHandler(this.buttonkayıtol_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp6.Properties.Resources._2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(217, 159);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 34);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(37, 6);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(168, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Furkan";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp6.Properties.Resources._3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Location = new System.Drawing.Point(217, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 34);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(36, 4);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(168, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "123456";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(104, 201);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 31);
            this.panel6.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifreniz";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(104, 162);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(105, 31);
            this.panel5.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı Adınız";
            // 
            // buttonYöneticiGirisi
            // 
            this.buttonYöneticiGirisi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonYöneticiGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYöneticiGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonYöneticiGirisi.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonYöneticiGirisi.Location = new System.Drawing.Point(267, 327);
            this.buttonYöneticiGirisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonYöneticiGirisi.Name = "buttonYöneticiGirisi";
            this.buttonYöneticiGirisi.Size = new System.Drawing.Size(119, 53);
            this.buttonYöneticiGirisi.TabIndex = 18;
            this.buttonYöneticiGirisi.Text = "Yönetici Girişi";
            this.buttonYöneticiGirisi.UseVisualStyleBackColor = false;
            this.buttonYöneticiGirisi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.yönetici;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(197, 327);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 53);
            this.panel3.TabIndex = 19;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 426);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonYöneticiGirisi);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonkayıtol);
            this.Controls.Add(this.buttongırıs);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giriş";
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttongırıs;
        private System.Windows.Forms.Button buttonkayıtol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button buttonYöneticiGirisi;
        private System.Windows.Forms.Panel panel3;
    }
}