using System.Windows.Forms;

namespace c_Projesi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Patlama = new System.Windows.Forms.PictureBox();
            this.Ödül = new System.Windows.Forms.PictureBox();
            this.YZ2 = new System.Windows.Forms.PictureBox();
            this.YZ1 = new System.Windows.Forms.PictureBox();
            this.Oyuncu = new System.Windows.Forms.PictureBox();
            this.Yol2 = new System.Windows.Forms.PictureBox();
            this.Yol1 = new System.Windows.Forms.PictureBox();
            this.Başlabuton = new System.Windows.Forms.Button();
            this.Skor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OyunZamanlayıcısı = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Patlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ödül)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YZ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yol1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Patlama);
            this.panel1.Controls.Add(this.Ödül);
            this.panel1.Controls.Add(this.YZ2);
            this.panel1.Controls.Add(this.YZ1);
            this.panel1.Controls.Add(this.Oyuncu);
            this.panel1.Controls.Add(this.Yol2);
            this.panel1.Controls.Add(this.Yol1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 495);
            this.panel1.TabIndex = 0;
            // 
            // Patlama
            // 
            this.Patlama.Image = global::c_Projesi.Properties.Resources.explosion;
            this.Patlama.Location = new System.Drawing.Point(71, 335);
            this.Patlama.Name = "Patlama";
            this.Patlama.Size = new System.Drawing.Size(72, 67);
            this.Patlama.TabIndex = 6;
            this.Patlama.TabStop = false;
            this.Patlama.Click += new System.EventHandler(this.Patlama_Click);
            // 
            // Ödül
            // 
            this.Ödül.Image = global::c_Projesi.Properties.Resources.bronze;
            this.Ödül.Location = new System.Drawing.Point(118, 192);
            this.Ödül.Name = "Ödül";
            this.Ödül.Size = new System.Drawing.Size(252, 102);
            this.Ödül.TabIndex = 5;
            this.Ödül.TabStop = false;
            // 
            // YZ2
            // 
            this.YZ2.Image = global::c_Projesi.Properties.Resources.carGrey;
            this.YZ2.Location = new System.Drawing.Point(253, 49);
            this.YZ2.Name = "YZ2";
            this.YZ2.Size = new System.Drawing.Size(51, 101);
            this.YZ2.TabIndex = 4;
            this.YZ2.TabStop = false;
            this.YZ2.Tag = "solAraba";
            this.YZ2.Click += new System.EventHandler(this.YZ2_Click);
            this.YZ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // YZ1
            // 
            this.YZ1.Image = global::c_Projesi.Properties.Resources.carYellow;
            this.YZ1.Location = new System.Drawing.Point(91, 49);
            this.YZ1.Name = "YZ1";
            this.YZ1.Size = new System.Drawing.Size(52, 101);
            this.YZ1.TabIndex = 3;
            this.YZ1.TabStop = false;
            this.YZ1.Tag = "sağAraba";
            this.YZ1.Click += new System.EventHandler(this.YZ1_Click);
            this.YZ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // Oyuncu
            // 
            this.Oyuncu.Image = global::c_Projesi.Properties.Resources.carPink;
            this.Oyuncu.Location = new System.Drawing.Point(237, 361);
            this.Oyuncu.Name = "Oyuncu";
            this.Oyuncu.Size = new System.Drawing.Size(51, 101);
            this.Oyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Oyuncu.TabIndex = 2;
            this.Oyuncu.TabStop = false;
            this.Oyuncu.Click += new System.EventHandler(this.Oyuncu_Click);
            // 
            // Yol2
            // 
            this.Yol2.Image = global::c_Projesi.Properties.Resources.roadTrack;
            this.Yol2.Location = new System.Drawing.Point(3, -7);
            this.Yol2.Name = "Yol2";
            this.Yol2.Size = new System.Drawing.Size(479, 502);
            this.Yol2.TabIndex = 1;
            this.Yol2.TabStop = false;
            // 
            // Yol1
            // 
            this.Yol1.Image = global::c_Projesi.Properties.Resources.roadTrack;
            this.Yol1.Location = new System.Drawing.Point(0, -519);
            this.Yol1.Name = "Yol1";
            this.Yol1.Size = new System.Drawing.Size(479, 495);
            this.Yol1.TabIndex = 0;
            this.Yol1.TabStop = false;
            // 
            // Başlabuton
            // 
            this.Başlabuton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Başlabuton.Location = new System.Drawing.Point(206, 542);
            this.Başlabuton.Name = "Başlabuton";
            this.Başlabuton.Size = new System.Drawing.Size(94, 45);
            this.Başlabuton.TabIndex = 0;
            this.Başlabuton.Text = "Başla!";
            this.Başlabuton.UseVisualStyleBackColor = true;
            this.Başlabuton.Click += new System.EventHandler(this.Start_Click);
            // 
            // Skor
            // 
            this.Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor.Location = new System.Drawing.Point(12, 510);
            this.Skor.Name = "Skor";
            this.Skor.Size = new System.Drawing.Size(479, 19);
            this.Skor.TabIndex = 1;
            this.Skor.Text = "Skor: 0";
            this.Skor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 174);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlamak için butona bas!\r\n\r\n\r\nOyundaki başka arabalara çarpma ve yapabildiğin ka" +
    "dar hayatta kalmaya çalış.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OyunZamanlayıcısı
            // 
            this.OyunZamanlayıcısı.Interval = 20;
            this.OyunZamanlayıcısı.Tick += new System.EventHandler(this.OyunZamanlayıcıOlay);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Skor);
            this.Controls.Add(this.Başlabuton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Patlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ödül)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YZ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yol1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Başlabuton;
        private System.Windows.Forms.Label Skor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Yol1;
        private System.Windows.Forms.PictureBox Yol2;
        private System.Windows.Forms.PictureBox Oyuncu;
        private System.Windows.Forms.PictureBox Patlama;
        private System.Windows.Forms.PictureBox Ödül;
        private System.Windows.Forms.PictureBox YZ2;
        private System.Windows.Forms.PictureBox YZ1;
        private System.Windows.Forms.Timer OyunZamanlayıcısı;
    }
}

