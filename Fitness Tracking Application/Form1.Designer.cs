namespace Fitness_Tracking_Application
{
    partial class Frm_AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AnaForm));
            this.btn_yeniUye = new System.Windows.Forms.Button();
            this.btn_TarifeEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_UyeGoruntule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Tarifeler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Kasa_Islemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yeniUye
            // 
            this.btn_yeniUye.Image = ((System.Drawing.Image)(resources.GetObject("btn_yeniUye.Image")));
            this.btn_yeniUye.Location = new System.Drawing.Point(12, 30);
            this.btn_yeniUye.Name = "btn_yeniUye";
            this.btn_yeniUye.Size = new System.Drawing.Size(87, 87);
            this.btn_yeniUye.TabIndex = 0;
            this.btn_yeniUye.UseVisualStyleBackColor = true;
            this.btn_yeniUye.Click += new System.EventHandler(this.btn_yeniUye_Click);
            // 
            // btn_TarifeEkle
            // 
            this.btn_TarifeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_TarifeEkle.Image")));
            this.btn_TarifeEkle.Location = new System.Drawing.Point(135, 30);
            this.btn_TarifeEkle.Name = "btn_TarifeEkle";
            this.btn_TarifeEkle.Size = new System.Drawing.Size(87, 87);
            this.btn_TarifeEkle.TabIndex = 1;
            this.btn_TarifeEkle.UseVisualStyleBackColor = true;
            this.btn_TarifeEkle.Click += new System.EventHandler(this.btn_TarifeEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Üye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarife Ekle";
            // 
            // btn_UyeGoruntule
            // 
            this.btn_UyeGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("btn_UyeGoruntule.Image")));
            this.btn_UyeGoruntule.Location = new System.Drawing.Point(12, 155);
            this.btn_UyeGoruntule.Name = "btn_UyeGoruntule";
            this.btn_UyeGoruntule.Size = new System.Drawing.Size(87, 87);
            this.btn_UyeGoruntule.TabIndex = 4;
            this.btn_UyeGoruntule.UseVisualStyleBackColor = true;
            this.btn_UyeGoruntule.Click += new System.EventHandler(this.btn_UyeGoruntule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üyeler";
            // 
            // btn_Tarifeler
            // 
            this.btn_Tarifeler.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tarifeler.Image")));
            this.btn_Tarifeler.Location = new System.Drawing.Point(136, 155);
            this.btn_Tarifeler.Name = "btn_Tarifeler";
            this.btn_Tarifeler.Size = new System.Drawing.Size(87, 87);
            this.btn_Tarifeler.TabIndex = 6;
            this.btn_Tarifeler.UseVisualStyleBackColor = true;
            this.btn_Tarifeler.Click += new System.EventHandler(this.btn_Tarifeler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(149, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tarifeler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kasa İşlemleri";
            // 
            // btn_Kasa_Islemleri
            // 
            this.btn_Kasa_Islemleri.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kasa_Islemleri.Image")));
            this.btn_Kasa_Islemleri.Location = new System.Drawing.Point(15, 276);
            this.btn_Kasa_Islemleri.Name = "btn_Kasa_Islemleri";
            this.btn_Kasa_Islemleri.Size = new System.Drawing.Size(87, 87);
            this.btn_Kasa_Islemleri.TabIndex = 8;
            this.btn_Kasa_Islemleri.UseVisualStyleBackColor = true;
            // 
            // Frm_AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(627, 445);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Kasa_Islemleri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Tarifeler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_UyeGoruntule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TarifeEkle);
            this.Controls.Add(this.btn_yeniUye);
            this.ForeColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AnaForm";
            this.Text = "SOLİ FİTNESS CENTER";
            this.Load += new System.EventHandler(this.Frm_AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yeniUye;
        private System.Windows.Forms.Button btn_TarifeEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_UyeGoruntule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Tarifeler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Kasa_Islemleri;
    }
}

