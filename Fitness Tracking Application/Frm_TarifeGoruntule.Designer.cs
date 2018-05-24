namespace Fitness_Tracking_Application
{
    partial class Frm_TarifeGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TarifeGoruntule));
            this.txt_Arama = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Tarifeler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_TarifeDuzenle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TarifeEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tarifeler)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Arama
            // 
            this.txt_Arama.Location = new System.Drawing.Point(13, 13);
            this.txt_Arama.Multiline = true;
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.Size = new System.Drawing.Size(130, 33);
            this.txt_Arama.TabIndex = 0;
            this.txt_Arama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Arama_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Tarifeler
            // 
            this.dgv_Tarifeler.AllowUserToAddRows = false;
            this.dgv_Tarifeler.AllowUserToDeleteRows = false;
            this.dgv_Tarifeler.AllowUserToResizeColumns = false;
            this.dgv_Tarifeler.AllowUserToResizeRows = false;
            this.dgv_Tarifeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tarifeler.Location = new System.Drawing.Point(13, 53);
            this.dgv_Tarifeler.Name = "dgv_Tarifeler";
            this.dgv_Tarifeler.ReadOnly = true;
            this.dgv_Tarifeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tarifeler.Size = new System.Drawing.Size(282, 340);
            this.dgv_Tarifeler.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(334, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Düzenle";
            // 
            // btn_TarifeDuzenle
            // 
            this.btn_TarifeDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btn_TarifeDuzenle.Image")));
            this.btn_TarifeDuzenle.Location = new System.Drawing.Point(326, 192);
            this.btn_TarifeDuzenle.Name = "btn_TarifeDuzenle";
            this.btn_TarifeDuzenle.Size = new System.Drawing.Size(87, 87);
            this.btn_TarifeDuzenle.TabIndex = 8;
            this.btn_TarifeDuzenle.UseVisualStyleBackColor = true;
            this.btn_TarifeDuzenle.Click += new System.EventHandler(this.btn_TarifeDuzenle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(324, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tarife Ekle";
            // 
            // btn_TarifeEkle
            // 
            this.btn_TarifeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_TarifeEkle.Image")));
            this.btn_TarifeEkle.Location = new System.Drawing.Point(326, 71);
            this.btn_TarifeEkle.Name = "btn_TarifeEkle";
            this.btn_TarifeEkle.Size = new System.Drawing.Size(87, 87);
            this.btn_TarifeEkle.TabIndex = 10;
            this.btn_TarifeEkle.UseVisualStyleBackColor = true;
            this.btn_TarifeEkle.Click += new System.EventHandler(this.btn_TarifeEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(326, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tarifeyi Sil";
            // 
            // btn_sil
            // 
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.Location = new System.Drawing.Point(327, 310);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(87, 83);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Frm_TarifeGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(446, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_TarifeEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_TarifeDuzenle);
            this.Controls.Add(this.dgv_Tarifeler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Arama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TarifeGoruntule";
            this.Text = "SOLİ FİTNESS CENTER";
            this.Load += new System.EventHandler(this.Frm_TarifeGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tarifeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Arama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Tarifeler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_TarifeDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TarifeEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sil;
    }
}