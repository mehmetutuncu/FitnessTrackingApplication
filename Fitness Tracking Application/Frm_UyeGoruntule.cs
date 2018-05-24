using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Fitness_Tracking_Application
{
    public partial class Frm_UyeGoruntule : Form
    {
        db d = new db();
        TimeSpan day;
        DateTime bugun = DateTime.Today;
        string bitis;
        DateTime bitisTarihi;
        string kalan_gun;
        string parametre;
        public Frm_UyeGoruntule()
        {
            InitializeComponent();
        }

        private void txt_Aranacak_KeyUp(object sender, KeyEventArgs e)
        {
            string aranacak = "";
            if (txt_Aranacak.Text != "")
            {
                aranacak = "%" + txt_Aranacak.Text + "%";
            }
            doldur(aranacak, parametre);
            renklendir();
        }
        string sql;
        public void doldur(string aranacak,string parametre)
        {
           if(parametre == "0")
            {
                try
                {
                    d.myConnection.Open();
                    if (aranacak != "")
                    {
                        sql = "select tu.id,tut.id as id2,tu.ad,tu.soyad,tu.yas,tu.cinsiyet,tt.tarife_adi,tu.dogum_tarihi,tu.uyelik_tarihi,tu.adres,tu.cepno,tut.baslangic_tarihi,tut.bitis_tarihi ,tut.kalan_gun from TBL_Uyeler as tu,TBL_Uye_Tarifeler as tut,TBL_Tarifeler as tt  where tu.ad like '" + aranacak + "' and tu.id = tut.uye_id and tut.tarife_id = tt.id";
                    }
                    else
                    {
                        sql = "select  tu.id,tut.id as id2,tu.ad,tu.soyad,tu.yas,tu.cinsiyet,tt.tarife_adi,tu.dogum_tarihi,tu.uyelik_tarihi,tu.adres,tu.cepno,tut.baslangic_tarihi,tut.bitis_tarihi,tut.kalan_gun from TBL_Uyeler as tu , TBL_Uye_Tarifeler as tut, TBL_Tarifeler as tt where tu.id = tut.uye_id and tut.tarife_id = tt.id";
                    }
                    SQLiteCommand select_uyeler = new SQLiteCommand(sql, d.myConnection);
                    if (aranacak != "")
                    {
                        select_uyeler.Parameters.AddWithValue("@aranacak", aranacak);
                    }
                    SQLiteDataAdapter da = new SQLiteDataAdapter(select_uyeler);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Uyeler.DataSource = dt;
                    dgv_Uyeler.Columns["id"].Visible = false;
                    dgv_Uyeler.Columns["ad"].HeaderText = "Ad";
                    dgv_Uyeler.Columns["soyad"].HeaderText = "Soyad";
                    dgv_Uyeler.Columns["yas"].HeaderText = "Yaş";
                    dgv_Uyeler.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                    dgv_Uyeler.Columns["dogum_tarihi"].HeaderText = "Doğum Tarihi";
                    dgv_Uyeler.Columns["uyelik_tarihi"].HeaderText = "Üyelik Tarihi";
                    dgv_Uyeler.Columns["adres"].HeaderText = "Adres";
                    dgv_Uyeler.Columns["cepno"].HeaderText = "Cep Numarası";
                    dgv_Uyeler.Columns["baslangic_tarihi"].Visible = false;
                    dgv_Uyeler.Columns["bitis_tarihi"].Visible = false;
                    dgv_Uyeler.Columns["tarife_adi"].HeaderText = "Tarife Adı";
                    dgv_Uyeler.Columns["kalan_gun"].HeaderText = "Kalan Gün";
                    dgv_Uyeler.Columns["id2"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    d.myConnection.Close();
                    
                   

                }
            }
            else if (parametre == "1")
            {
                try
                {
                    d.myConnection.Open();
                    if (aranacak != "")
                    {
                        sql = "select * from TBL_Uyeler as tu where tu.ad LIKE @aranacak and not exists(select * from TBL_Uye_Tarifeler as tut where tu.id = tut.uye_id)";
                    }
                    else
                    {
                         sql = "select * from TBL_Uyeler as tu where not exists(select * from TBL_Uye_Tarifeler as tut where tu.id = tut.uye_id)";
                    }
                    
                    SQLiteCommand select_uyeler = new SQLiteCommand(sql,d.myConnection);
                    if(aranacak != "")
                    {
                        select_uyeler.Parameters.AddWithValue("@aranacak",aranacak);
                    }
                    SQLiteDataAdapter da = new SQLiteDataAdapter(select_uyeler);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Uyeler.DataSource = dt;
                    dgv_Uyeler.Columns["id"].Visible = false;
                    dgv_Uyeler.Columns["ad"].HeaderText = "Ad";
                    dgv_Uyeler.Columns["soyad"].HeaderText = "Soyad";
                    dgv_Uyeler.Columns["yas"].HeaderText = "Yaş";
                    dgv_Uyeler.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                    dgv_Uyeler.Columns["dogum_tarihi"].HeaderText = "Doğum Tarihi";
                    dgv_Uyeler.Columns["uyelik_tarihi"].HeaderText = "Üyelik Tarihi";
                    dgv_Uyeler.Columns["adres"].HeaderText = "Adres";
                    dgv_Uyeler.Columns["cepno"].HeaderText = "Cep Numarası";
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    d.myConnection.Close();
                }
            }
        }
        public void kalan_gun_hesap()
        {
            try
            {
                if (dgv_Uyeler.Rows.Count != 0)
                {
                    d.myConnection.Open();
                    for (int i = 0; i < dgv_Uyeler.Rows.Count; i++)
                    {
                        Application.DoEvents();
                        bitis = dgv_Uyeler.Rows[i].Cells["bitis_tarihi"].Value.ToString();
                        bitisTarihi = DateTime.Parse(bitis.ToString());
                        day = bitisTarihi - bugun;
                        kalan_gun = day.TotalDays.ToString();
                        string id = dgv_Uyeler.Rows[i].Cells["id2"].Value.ToString();
                        string sql = "update TBL_Uye_Tarifeler set kalan_gun = @kalan where id = @id";
                        SQLiteCommand update_uye_tarifeler = new SQLiteCommand(sql, d.myConnection);
                        update_uye_tarifeler.Parameters.AddWithValue("@kalan", kalan_gun);
                        update_uye_tarifeler.Parameters.AddWithValue("@id", id);
                        update_uye_tarifeler.ExecuteNonQuery();
                        
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
                
                
                
                
            }
        }
        public void sifirla()
        {
            txt_Aranacak.Text = "";
        }
        public void renklendir()
        {
            try
            {
                for (int i = 0; i < dgv_Uyeler.Rows.Count; i++)
                {
                    if (dgv_Uyeler.Rows[i].Cells["kalan_gun"].Value != null)
                    {
                        Application.DoEvents();
                        DataGridViewCellStyle renk = new DataGridViewCellStyle();
                        int deger = int.Parse(dgv_Uyeler.Rows[i].Cells["kalan_gun"].Value.ToString());
                        if (deger < 0)
                        {
                            dgv_Uyeler.Rows[i].Cells["kalan_gun"].Value = 0;
                            renk.BackColor = Color.DarkRed;
                        }
                        else if (deger <= 5)
                        {
                            renk.BackColor = Color.Green;
                        }
                        else if (deger <= 15)
                        {
                            renk.BackColor = Color.Yellow;

                        }
                        else
                        {
                            renk.BackColor = Color.Green;
                        }
                        dgv_Uyeler.Rows[i].DefaultCellStyle = renk;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
           
                
            
        }
        private void Frm_UyeGoruntule_Load(object sender, EventArgs e)
        {
            rb_Tarifeli.Checked = true;
            
           
          
            
            
        }

        
 

        private void btn_yeniUye_Click(object sender, EventArgs e)
        {
            string id = "0";
            Frm_YeniUye frm = new Frm_YeniUye(id,parametre);
            frm.ShowDialog();
            Frm_UyeGoruntule frm2 = (Frm_UyeGoruntule)Application.OpenForms["Frm_UyeGoruntule"];
            string aranacak2 = "";
            frm2.doldur(aranacak2,parametre);

        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if(dgv_Uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Satır seçmediğiniz için işleminizi gerçekleştiremiyorum.");
            }
            else
            {
                string id = dgv_Uyeler.CurrentRow.Cells["id"].Value.ToString();
                Frm_YeniUye frm = new Frm_YeniUye(id,parametre);
                frm.ShowDialog();
                
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_Uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Satır seçmediğiniz için işleminizi gerçekleştiremiyorum.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    string id = dgv_Uyeler.CurrentRow.Cells["id"].Value.ToString();
                    try
                    {
                        d.myConnection.Open();
                        string sql = "delete from TBL_Uyeler where id = @id";
                        SQLiteCommand delete_uyeler = new SQLiteCommand(sql,d.myConnection);
                        delete_uyeler.Parameters.AddWithValue("@id", id);
                        int result = delete_uyeler.ExecuteNonQuery();
                        if(result > 0)
                        {
                            MessageBox.Show("Kayıt başarı ile silindi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        Frm_UyeGoruntule frm = (Frm_UyeGoruntule)Application.OpenForms["Frm_UyeGoruntule"];
                        string aranacak = "";
                        frm.doldur(aranacak,parametre);
                        frm.Refresh();
                    }
                }

            }
        }

        private void btn_UyeyeTarifeEkle_Click(object sender, EventArgs e)
        {

            if (dgv_Uyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Satır seçmediğiniz için işleminizi gerçekleştiremiyorum.");
            }
            else
            {
                string id = dgv_Uyeler.CurrentRow.Cells["id"].Value.ToString();
                Frm_UyeTarifeEkle frm = new Frm_UyeTarifeEkle(id,parametre);
                frm.ShowDialog();
            }
        }

        private void rb_Tarifeli_CheckedChanged(object sender, EventArgs e)
        {
            string aranacak = "";
            parametre = "0";
            doldur(aranacak, parametre);
            kalan_gun_hesap();
            doldur(aranacak,parametre);
            renklendir();
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string aranacak = "";
            parametre = "1";
            doldur(aranacak, parametre);
        }
    }
}
