
namespace VİZE2011011014
{
    partial class SENCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SENCE));
            this.bt_kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ad = new System.Windows.Forms.Label();
            this.lb_soyad = new System.Windows.Forms.Label();
            this.lb_no = new System.Windows.Forms.Label();
            this.lb_bolum = new System.Windows.Forms.Label();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.bt_onayla = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelanket = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelanket.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_kapat
            // 
            this.bt_kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_kapat.BackgroundImage")));
            this.bt_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_kapat.Location = new System.Drawing.Point(929, 2);
            this.bt_kapat.Name = "bt_kapat";
            this.bt_kapat.Size = new System.Drawing.Size(54, 36);
            this.bt_kapat.TabIndex = 0;
            this.bt_kapat.UseVisualStyleBackColor = true;
            this.bt_kapat.Click += new System.EventHandler(this.bt_kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Süleyman Demirel Üniversitesi Mühendislik Fakültesi Öğrencileri\r\n İçin Geliştiril" +
    "en \'SENCE\' Anket Sistemine Hoşgeldiniz\r\n";
            // 
            // lb_ad
            // 
            this.lb_ad.AutoSize = true;
            this.lb_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_ad.Location = new System.Drawing.Point(6, 27);
            this.lb_ad.Name = "lb_ad";
            this.lb_ad.Size = new System.Drawing.Size(65, 20);
            this.lb_ad.TabIndex = 2;
            this.lb_ad.Text = "Adınız: ";
            // 
            // lb_soyad
            // 
            this.lb_soyad.AutoSize = true;
            this.lb_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_soyad.Location = new System.Drawing.Point(5, 65);
            this.lb_soyad.Name = "lb_soyad";
            this.lb_soyad.Size = new System.Drawing.Size(91, 20);
            this.lb_soyad.TabIndex = 3;
            this.lb_soyad.Text = "Soyadınız: ";
            // 
            // lb_no
            // 
            this.lb_no.AutoSize = true;
            this.lb_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_no.Location = new System.Drawing.Point(5, 101);
            this.lb_no.Name = "lb_no";
            this.lb_no.Size = new System.Drawing.Size(100, 20);
            this.lb_no.TabIndex = 4;
            this.lb_no.Text = "Numaranız: ";
            // 
            // lb_bolum
            // 
            this.lb_bolum.AutoSize = true;
            this.lb_bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_bolum.Location = new System.Drawing.Point(6, 138);
            this.lb_bolum.Name = "lb_bolum";
            this.lb_bolum.Size = new System.Drawing.Size(103, 20);
            this.lb_bolum.TabIndex = 5;
            this.lb_bolum.Text = "Bölümünüz: ";
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(114, 25);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(183, 22);
            this.tb_ad.TabIndex = 6;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(114, 63);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(183, 22);
            this.tb_soyad.TabIndex = 7;
            
            // 
            // tb_no
            // 
            this.tb_no.Location = new System.Drawing.Point(114, 99);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(183, 22);
            this.tb_no.TabIndex = 8;
          
            // 
            // bt_onayla
            // 
            this.bt_onayla.BackColor = System.Drawing.SystemColors.Info;
            this.bt_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_onayla.ForeColor = System.Drawing.Color.Black;
            this.bt_onayla.Location = new System.Drawing.Point(17, 15);
            this.bt_onayla.Name = "bt_onayla";
            this.bt_onayla.Size = new System.Drawing.Size(291, 76);
            this.bt_onayla.TabIndex = 10;
            this.bt_onayla.Text = "Anketi Başlat";
            this.bt_onayla.UseVisualStyleBackColor = false;
            this.bt_onayla.Click += new System.EventHandler(this.bt_onayla_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bilgisayar Mühendisliği ",
            "Bilgisayar Mühendisliği (İÖ)",
            "Çevre Mühendisliği",
            "Elektrik-Elektronik Mühendisliği",
            "Elektrik-Elektronik Mühendisliği (İÖ)",
            "Endüstri Mühendisliği",
            "Endüstri Mühendisliği (İÖ)",
            "Gıda Mühendisliği",
            "İnşaat Mühendisliği",
            "Jeoloji Mühendisliği",
            "Kimya Mühendisliği",
            "Maden Mühendisliği",
            "Makine Mühendisliği ",
            "Otomotiv Mühendisliği"});
            this.comboBox1.Location = new System.Drawing.Point(115, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sınıfınız: ";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hazırlık",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox2.Location = new System.Drawing.Point(115, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 26);
            this.label4.TabIndex = 15;
            // 
            // panelanket
            // 
            this.panelanket.Controls.Add(this.bt_onayla);
            this.panelanket.Location = new System.Drawing.Point(50, 420);
            this.panelanket.Name = "panelanket";
            this.panelanket.Size = new System.Drawing.Size(330, 105);
            this.panelanket.TabIndex = 17;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(33, 141);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(306, 21);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Süleyman Demirel Üniversitesi Öğrencisiyim";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tb_no);
            this.panel1.Controls.Add(this.tb_soyad);
            this.panel1.Controls.Add(this.tb_ad);
            this.panel1.Controls.Add(this.lb_bolum);
            this.panel1.Controls.Add(this.lb_no);
            this.panel1.Controls.Add(this.lb_soyad);
            this.panel1.Controls.Add(this.lb_ad);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(7, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 219);
            this.panel1.TabIndex = 19;
            // 
            // SENCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(980, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.panelanket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_kapat);
            this.DoubleBuffered = true;
            this.Name = "SENCE";
            this.Text = "Form1";
            this.panelanket.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ad;
        private System.Windows.Forms.Label lb_soyad;
        private System.Windows.Forms.Label lb_no;
        private System.Windows.Forms.Label lb_bolum;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.Button bt_onayla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelanket;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

