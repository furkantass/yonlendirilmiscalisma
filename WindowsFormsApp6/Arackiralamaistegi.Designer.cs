namespace WindowsFormsApp6
{
    partial class Arackiralamaistegi
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewKiralama = new System.Windows.Forms.DataGridView();
            this.buttonONAYLA = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonVeriyiCek = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiralama)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.gmailicon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(753, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(282, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 54);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "YÖNETİCİ PANELİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.kullanıcıodaklı1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 66);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewKiralama
            // 
            this.dataGridViewKiralama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKiralama.Location = new System.Drawing.Point(125, 75);
            this.dataGridViewKiralama.Name = "dataGridViewKiralama";
            this.dataGridViewKiralama.RowHeadersWidth = 51;
            this.dataGridViewKiralama.RowTemplate.Height = 24;
            this.dataGridViewKiralama.Size = new System.Drawing.Size(607, 261);
            this.dataGridViewKiralama.TabIndex = 18;
            this.dataGridViewKiralama.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // buttonONAYLA
            // 
            this.buttonONAYLA.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonONAYLA.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.onayiconn;
            this.buttonONAYLA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonONAYLA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonONAYLA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonONAYLA.Location = new System.Drawing.Point(189, 343);
            this.buttonONAYLA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonONAYLA.Name = "buttonONAYLA";
            this.buttonONAYLA.Size = new System.Drawing.Size(99, 52);
            this.buttonONAYLA.TabIndex = 46;
            this.buttonONAYLA.UseVisualStyleBackColor = false;
            this.buttonONAYLA.Click += new System.EventHandler(this.ButtonONAYLA_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRed.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.redicon;
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRed.Location = new System.Drawing.Point(538, 343);
            this.buttonRed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(101, 52);
            this.buttonRed.TabIndex = 47;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.ButtonRed_Click);
            // 
            // buttonVeriyiCek
            // 
            this.buttonVeriyiCek.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonVeriyiCek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVeriyiCek.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVeriyiCek.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonVeriyiCek.Location = new System.Drawing.Point(355, 397);
            this.buttonVeriyiCek.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVeriyiCek.Name = "buttonVeriyiCek";
            this.buttonVeriyiCek.Size = new System.Drawing.Size(119, 38);
            this.buttonVeriyiCek.TabIndex = 48;
            this.buttonVeriyiCek.Text = "GÜNCELLE";
            this.buttonVeriyiCek.UseVisualStyleBackColor = false;
            this.buttonVeriyiCek.Click += new System.EventHandler(this.ButtonVeriyiCek_Click);
            // 
            // Arackiralamaistegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.araçarkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 519);
            this.Controls.Add(this.buttonVeriyiCek);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonONAYLA);
            this.Controls.Add(this.dataGridViewKiralama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Arackiralamaistegi";
            this.Text = "Kiralama İstekleri";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKiralama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewKiralama;
        private System.Windows.Forms.Button buttonONAYLA;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonVeriyiCek;
    }
}