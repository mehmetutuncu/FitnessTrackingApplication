namespace Fitness_Tracking_Application
{
    partial class Frm_YeniUye
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Yas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_Erkek = new System.Windows.Forms.RadioButton();
            this.rb_Kadin = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxt_CepNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(329, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // cmb_Yas
            // 
            this.cmb_Yas.FormattingEnabled = true;
            this.cmb_Yas.Location = new System.Drawing.Point(154, 97);
            this.cmb_Yas.Name = "cmb_Yas";
            this.cmb_Yas.Size = new System.Drawing.Size(81, 24);
            this.cmb_Yas.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(329, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cinsiyet :";
            // 
            // rb_Erkek
            // 
            this.rb_Erkek.AutoSize = true;
            this.rb_Erkek.ForeColor = System.Drawing.Color.Blue;
            this.rb_Erkek.Location = new System.Drawing.Point(407, 72);
            this.rb_Erkek.Name = "rb_Erkek";
            this.rb_Erkek.Size = new System.Drawing.Size(66, 20);
            this.rb_Erkek.TabIndex = 5;
            this.rb_Erkek.TabStop = true;
            this.rb_Erkek.Text = "Erkek";
            this.rb_Erkek.UseVisualStyleBackColor = true;
            // 
            // rb_Kadin
            // 
            this.rb_Kadin.AutoSize = true;
            this.rb_Kadin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rb_Kadin.Location = new System.Drawing.Point(479, 72);
            this.rb_Kadin.Name = "rb_Kadin";
            this.rb_Kadin.Size = new System.Drawing.Size(65, 20);
            this.rb_Kadin.TabIndex = 6;
            this.rb_Kadin.TabStop = true;
            this.rb_Kadin.Text = "Kadın";
            this.rb_Kadin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Doğum Tarihi :";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(154, 41);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(153, 22);
            this.txt_Ad.TabIndex = 8;
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ad_KeyPress);
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(407, 38);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(137, 22);
            this.txt_Soyad.TabIndex = 9;
            this.txt_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(265, 211);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(90, 23);
            this.btn_Kaydet.TabIndex = 11;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_dogumTarihi
            // 
            this.txt_dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_dogumTarihi.Location = new System.Drawing.Point(154, 69);
            this.txt_dogumTarihi.Name = "txt_dogumTarihi";
            this.txt_dogumTarihi.Size = new System.Drawing.Size(115, 22);
            this.txt_dogumTarihi.TabIndex = 12;
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(154, 127);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(341, 62);
            this.txt_Adres.TabIndex = 13;
            this.txt_Adres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Adres_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(329, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cep No :";
            // 
            // mtxt_CepNo
            // 
            this.mtxt_CepNo.Location = new System.Drawing.Point(405, 100);
            this.mtxt_CepNo.Mask = "(999) 000-0000";
            this.mtxt_CepNo.Name = "mtxt_CepNo";
            this.mtxt_CepNo.Size = new System.Drawing.Size(106, 22);
            this.mtxt_CepNo.TabIndex = 16;
            // 
            // Frm_YeniUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 311);
            this.Controls.Add(this.mtxt_CepNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.txt_dogumTarihi);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rb_Kadin);
            this.Controls.Add(this.rb_Erkek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Yas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_YeniUye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOLİ FİTNESS CENTER";
            this.Load += new System.EventHandler(this.Frm_YeniUye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Yas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_Erkek;
        private System.Windows.Forms.RadioButton rb_Kadin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.DateTimePicker txt_dogumTarihi;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxt_CepNo;
    }
}