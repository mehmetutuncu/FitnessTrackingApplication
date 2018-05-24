namespace Fitness_Tracking_Application
{
    partial class Frm_UyeGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UyeGoruntule));
            this.dgv_Uyeler = new System.Windows.Forms.DataGridView();
            this.txt_Aranacak = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_yeniUye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_UyeyeTarifeEkle = new System.Windows.Forms.Button();
            this.rb_Tarifeli = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Uyeler
            // 
            this.dgv_Uyeler.AllowUserToAddRows = false;
            this.dgv_Uyeler.AllowUserToDeleteRows = false;
            this.dgv_Uyeler.AllowUserToResizeColumns = false;
            this.dgv_Uyeler.AllowUserToResizeRows = false;
            this.dgv_Uyeler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Uyeler.GridColor = System.Drawing.Color.Red;
            this.dgv_Uyeler.Location = new System.Drawing.Point(12, 56);
            this.dgv_Uyeler.Name = "dgv_Uyeler";
            this.dgv_Uyeler.ReadOnly = true;
            this.dgv_Uyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Uyeler.Size = new System.Drawing.Size(1043, 456);
            this.dgv_Uyeler.TabIndex = 0;
            // 
            // txt_Aranacak
            // 
            this.txt_Aranacak.Location = new System.Drawing.Point(12, 17);
            this.txt_Aranacak.Multiline = true;
            this.txt_Aranacak.Name = "txt_Aranacak";
            this.txt_Aranacak.Size = new System.Drawing.Size(126, 33);
            this.txt_Aranacak.TabIndex = 1;
            this.txt_Aranacak.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Aranacak_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_yeniUye
            // 
            this.btn_yeniUye.Image = ((System.Drawing.Image)(resources.GetObject("btn_yeniUye.Image")));
            this.btn_yeniUye.Location = new System.Drawing.Point(1085, 66);
            this.btn_yeniUye.Name = "btn_yeniUye";
            this.btn_yeniUye.Size = new System.Drawing.Size(96, 83);
            this.btn_yeniUye.TabIndex = 3;
            this.btn_yeniUye.UseVisualStyleBackColor = true;
            this.btn_yeniUye.Click += new System.EventHandler(this.btn_yeniUye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1091, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni Üye";
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_duzenle.Image")));
            this.btn_duzenle.Location = new System.Drawing.Point(1085, 194);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(96, 83);
            this.btn_duzenle.TabIndex = 5;
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1097, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Düzenle";
            // 
            // btn_sil
            // 
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.Location = new System.Drawing.Point(1085, 313);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(96, 83);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1098, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Üyeyi Sil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1061, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Üyeye Tarife Ekle";
            // 
            // btn_UyeyeTarifeEkle
            // 
            this.btn_UyeyeTarifeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_UyeyeTarifeEkle.Image")));
            this.btn_UyeyeTarifeEkle.Location = new System.Drawing.Point(1085, 429);
            this.btn_UyeyeTarifeEkle.Name = "btn_UyeyeTarifeEkle";
            this.btn_UyeyeTarifeEkle.Size = new System.Drawing.Size(96, 83);
            this.btn_UyeyeTarifeEkle.TabIndex = 9;
            this.btn_UyeyeTarifeEkle.UseVisualStyleBackColor = true;
            this.btn_UyeyeTarifeEkle.Click += new System.EventHandler(this.btn_UyeyeTarifeEkle_Click);
            // 
            // rb_Tarifeli
            // 
            this.rb_Tarifeli.AutoSize = true;
            this.rb_Tarifeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_Tarifeli.ForeColor = System.Drawing.Color.Red;
            this.rb_Tarifeli.Location = new System.Drawing.Point(203, 17);
            this.rb_Tarifeli.Name = "rb_Tarifeli";
            this.rb_Tarifeli.Size = new System.Drawing.Size(130, 22);
            this.rb_Tarifeli.TabIndex = 11;
            this.rb_Tarifeli.TabStop = true;
            this.rb_Tarifeli.Text = "Tarifeli Üyeler";
            this.rb_Tarifeli.UseVisualStyleBackColor = true;
            this.rb_Tarifeli.CheckedChanged += new System.EventHandler(this.rb_Tarifeli_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.Color.Red;
            this.radioButton2.Location = new System.Drawing.Point(343, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(144, 22);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tarifesiz Üyeler";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Frm_UyeGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 524);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb_Tarifeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_UyeyeTarifeEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_yeniUye);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Aranacak);
            this.Controls.Add(this.dgv_Uyeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_UyeGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOLİ FİTNESS CENTER";
            this.Load += new System.EventHandler(this.Frm_UyeGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Uyeler;
        private System.Windows.Forms.TextBox txt_Aranacak;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_yeniUye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_UyeyeTarifeEkle;
        private System.Windows.Forms.RadioButton rb_Tarifeli;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}