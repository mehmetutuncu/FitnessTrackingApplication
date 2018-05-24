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

    public partial class Frm_UyeTarifeEkle : Form
    {
        string id;
        db d = new db();
        DateTime baslangic_tarihi2 = DateTime.Today;
        DateTime bitis_tarihi2;
        double kalan;
        string parametre;
        public Frm_UyeTarifeEkle(string gelen_id,string gelen_parametre)
        {
            InitializeComponent();
            id = gelen_id;
            parametre = gelen_parametre;
        }
        public void uye_doldur(string id)
        {
            try
            {
                d.myConnection.Open();
                string sql = "select id,ad,soyad from TBL_Uyeler where id = @id";
                SQLiteCommand select_uye = new SQLiteCommand(sql, d.myConnection);
                select_uye.Parameters.AddWithValue("@id", id);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_uye);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Uye.DataSource = dt;
                dgv_Uye.Columns["id"].Visible = false;
                dgv_Uye.Columns["ad"].HeaderText = "Ad";
                dgv_Uye.Columns["soyad"].HeaderText = "Soyad";
                dgv_Uye.Columns["ad"].Width = 200;
                dgv_Uye.Columns["soyad"].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
                tarife_doldur(id);
            }
        }
        public void tarife_doldur(string id)
        {
            try
            {
                d.myConnection.Open();
                string sql = "select tt.id,tt.tarife_adi,tt.fiyat from TBL_Tarifeler as tt , TBL_Uyeler as tu WHERE tu.id = @id and NOT exists(select * from TBL_Uye_Tarifeler as tut WHERE tt.id = tut.tarife_id and tu.id = tut.uye_id)";
                SQLiteCommand select_tarife = new SQLiteCommand(sql, d.myConnection);
                select_tarife.Parameters.AddWithValue("@id", id);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_tarife);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Tarifeler.DataSource = dt;
                dgv_Tarifeler.Columns["id"].Visible = false;
                dgv_Tarifeler.Columns["tarife_adi"].HeaderText = "Tarife Adı";
                dgv_Tarifeler.Columns["fiyat"].HeaderText = "Fiyat";
                dgv_Tarifeler.Columns["tarife_adi"].Width = 150;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
            }
        }
        public void uye_tarife_doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "SELECT tut.id,tt.tarife_adi,tut.alinacak_tutar,tut.baslangic_tarihi,tut.bitis_tarihi,tut.alindi_mi ,tut.durum FROM TBL_Uye_Tarifeler as tut , TBL_Tarifeler as tt WHERE tut.uye_id = @id and  tut.tarife_id = tt.id";
                SQLiteCommand select_uye_tarife = new SQLiteCommand(sql, d.myConnection);
                select_uye_tarife.Parameters.AddWithValue("@id", id);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_uye_tarife);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Uye_Tarifeler.DataSource = dt;
                dgv_Uye_Tarifeler.Columns["id"].Visible = false;
                dgv_Uye_Tarifeler.Columns["tarife_adi"].HeaderText = "Tarife Adı";
                dgv_Uye_Tarifeler.Columns["alinacak_tutar"].HeaderText = "Hizmet Bedeli";
                dgv_Uye_Tarifeler.Columns["tarife_adi"].Width = 150;
                dgv_Uye_Tarifeler.Columns["alinacak_tutar"].Width = 150;
                dgv_Uye_Tarifeler.Columns["alindi_mi"].HeaderText = "Tahsil Edildi Mi?";
                dgv_Uye_Tarifeler.Columns["baslangic_tarihi"].HeaderText = "Başlangıç Tarihi";
                dgv_Uye_Tarifeler.Columns["bitis_tarihi"].HeaderText = "Bitiş Tarihi";
                dgv_Uye_Tarifeler.Columns["durum"].HeaderText = "Üyelik Durumu";
                dgv_Uye_Tarifeler.Columns["durum"].Width = 150;
                dgv_Uye_Tarifeler.Columns["alindi_mi"].Width = 150;
                dgv_Uye_Tarifeler.Columns["bitis_tarihi"].Width = 150;
                dgv_Uye_Tarifeler.Columns["baslangic_tarihi"].Width = 150;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                d.myConnection.Close();
            }
        }
        private void Frm_UyeTarifeEkle_Load(object sender, EventArgs e)
        {
            uye_doldur(id);
            uye_tarife_doldur();
            


        }
        DateTime baslangic_tarihi = DateTime.Now;
        DateTime bitis_tarihi;
        int tutar;
        string odendi_mi;
        int ay;
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Tarifeler.CurrentRow == null)
                {
                    MessageBox.Show("Tarife seçiniz!");
                }

                else
                {
                    if (rb_1Ay.Checked == true && txt_Ay.Text != "")
                    {
                        MessageBox.Show("1 aylık seçeneğini işaretledikten sonra elle değer giremezsiniz.");
                        rb_1Ay.Checked = false;
                        txt_Ay.Text = "";
                    }
                    else if (rb_3Ay.Checked == true && txt_Ay.Text != "")
                    {
                        MessageBox.Show("3 aylık seçeneğini işaretledikten sonra elle değer giremezsiniz.");
                        rb_3Ay.Checked = false;
                        txt_Ay.Text = "";
                    }
                    else if (rb_6Ay.Checked == true && txt_Ay.Text != "")
                    {
                        MessageBox.Show("6 aylık seçeneğini işaretledikten sonra elle değer giremezsiniz.");
                        rb_6Ay.Checked = false;
                        txt_Ay.Text = "";
                    }
                    else if (rb_12Ay.Checked == true && txt_Ay.Text != "")
                    {
                        MessageBox.Show("12 aylık seçeneğini işaretledikten sonra elle değer giremezsiniz.");
                        rb_12Ay.Checked = false;
                        txt_Ay.Text = "";
                    }
                    else
                    {
                        if (rb_1Ay.Checked == true)
                        {
                            bitis_tarihi = baslangic_tarihi.AddDays(1 * 30);
                            ay = 1;

                        }
                        else if (rb_3Ay.Checked == true)
                        {
                            bitis_tarihi = baslangic_tarihi.AddDays(3 * 30);
                            ay = 3;

                        }
                        else if (rb_6Ay.Checked == true)
                        {
                            bitis_tarihi = baslangic_tarihi.AddDays(6 * 30);
                            ay = 6;

                        }
                        else if (rb_12Ay.Checked == true)
                        {
                            bitis_tarihi = baslangic_tarihi.AddDays(12 * 30);
                            ay = 12;

                        }
                        else if (txt_Ay.Text != "")
                        {
                            int sayi = int.Parse(txt_Ay.Text);
                            bitis_tarihi = baslangic_tarihi.AddDays(sayi * 30);
                            ay = sayi;


                        }

                        DialogResult dr = MessageBox.Show("Parası tahsil edildi mi?", "Dikkat!", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            odendi_mi = "Evet";
                        }
                        else
                        {
                            odendi_mi = "Hayır";
                        }
                        tutar = ay * int.Parse(dgv_Tarifeler.CurrentRow.Cells["fiyat"].Value.ToString());
                        string uye_id = dgv_Uye.CurrentRow.Cells["id"].Value.ToString();
                        string tarife_id = dgv_Tarifeler.CurrentRow.Cells["id"].Value.ToString();
                        d.myConnection.Open();
                        string sql = "insert into TBL_Uye_Tarifeler(uye_id,tarife_id,baslangic_tarihi,bitis_tarihi,alinacak_tutar,alindi_mi,durum) " +
                            "VALUES(@u_id,@t_id,@bas,@bit,@tutar,@alindi_mi,@durum)";
                        SQLiteCommand insert_uye_tarifeler = new SQLiteCommand(sql, d.myConnection);
                        insert_uye_tarifeler.Parameters.AddWithValue("@u_id", uye_id);
                        insert_uye_tarifeler.Parameters.AddWithValue("@t_id", tarife_id);
                        insert_uye_tarifeler.Parameters.AddWithValue("@bas", baslangic_tarihi.ToShortDateString());
                        insert_uye_tarifeler.Parameters.AddWithValue("@bit", bitis_tarihi.ToShortDateString());
                        insert_uye_tarifeler.Parameters.AddWithValue("@tutar", tutar);
                        insert_uye_tarifeler.Parameters.AddWithValue("@alindi_mi", odendi_mi);
                        insert_uye_tarifeler.Parameters.AddWithValue("@durum", "Aktif");
                        int result = insert_uye_tarifeler.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Üyeye tarife başarı ile tanımlandı.");
                        }


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
                tarife_doldur(id);
                uye_tarife_doldur();
            }
        }

        private void txt_Ay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Islem_Click(object sender, EventArgs e)
        {
            //
            if (rb_Dondur.Checked == true)
            {
                //
                if (dgv_Uye_Tarifeler.CurrentRow == null)
                {
                    MessageBox.Show("Dondurulacak tarifeyi seçiniz.");
                }
                else
                {
                    DateTime bitis;
                    string uye_tarifeler_id = dgv_Uye_Tarifeler.CurrentRow.Cells["id"].Value.ToString();
                    string bitis_tarihi = dgv_Uye_Tarifeler.CurrentRow.Cells["bitis_tarihi"].Value.ToString();
                    string durum = dgv_Uye_Tarifeler.CurrentRow.Cells["durum"].Value.ToString();
                    DateTime now = DateTime.Today;
                    DateTime.TryParse(bitis_tarihi.ToString(), out bitis);
                    //
                    if (now > bitis)
                    {
                        MessageBox.Show("Üyelik sona ermiştir.");
                        try
                        {
                            d.myConnection.Open();
                            string sql = "update TBL_Uye_Tarifeler durum = @durum where id = @id";
                            SQLiteCommand update_uye_tarifeler = new SQLiteCommand(sql, d.myConnection);
                            update_uye_tarifeler.Parameters.AddWithValue("@durum", "Pasif");
                            update_uye_tarifeler.Parameters.AddWithValue("@id", uye_tarifeler_id);
                            update_uye_tarifeler.ExecuteNonQuery();
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
                    else if (durum == "Donduruldu") 
                    {
                        MessageBox.Show("Bu üyelik zaten hali hazırda dondurulmuş.");
                    }
                    //
                    else
                    {
                        
                        try
                        {
                            TimeSpan sonuc = bitis - now;
                            d.myConnection.Open();
                            string sql = "insert into TBL_Uyelik_Dondurma(uye_tarifeler_id,kalan_gun) VALUES(@id,@sonuc)";
                            SQLiteCommand insert_uyelik_dondurma = new SQLiteCommand(sql, d.myConnection);
                            insert_uyelik_dondurma.Parameters.AddWithValue("@id",uye_tarifeler_id);
                            insert_uyelik_dondurma.Parameters.AddWithValue("@sonuc",sonuc);
                           int result =  insert_uyelik_dondurma.ExecuteNonQuery();
                            d.myConnection.Close();
                            d.myConnection.Open();
                            string sql2 = "update TBL_Uye_Tarifeler set durum = @durum where id = @id";
                            SQLiteCommand update = new SQLiteCommand(sql2, d.myConnection);
                            update.Parameters.AddWithValue("@durum", "Donduruldu");
                            update.Parameters.AddWithValue("@id", uye_tarifeler_id);
                            int result2 = update.ExecuteNonQuery();
                            if(result > 0 && result2 > 0)
                            {
                                MessageBox.Show("Üyenin tarifesi başarı ile donduruldu.");
                                
                            }
                            
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            d.myConnection.Close();
                            uye_tarife_doldur();
                        }
                        
                    }
                    //
                }
                //
            }
            else if (rb_AktifEt.Checked == true)
            {
                if(dgv_Uye_Tarifeler.CurrentRow == null)
                {
                    MessageBox.Show("Üyenin aktif edilecek tarifesini seçiniz.");
                }
                else
                {
                    
                    string uye_tarife_id = dgv_Uye_Tarifeler.CurrentRow.Cells["id"].Value.ToString();
                    string durum = dgv_Uye_Tarifeler.CurrentRow.Cells["durum"].Value.ToString();
                    
                    
                    if(durum == "Donduruldu")
                    {
                        try
                        {
                            d.myConnection.Open();
                            string sql = "select kalan_gun FROM TBL_Uyelik_Dondurma where uye_tarifeler_id = @id";
                            SQLiteCommand select_kalan_gun = new SQLiteCommand(sql, d.myConnection);
                            select_kalan_gun.Parameters.AddWithValue("@id", uye_tarife_id);
                            SQLiteDataReader dr = select_kalan_gun.ExecuteReader();
                            
                            while (dr.Read())
                            {
                                kalan = Double.Parse(dr["kalan_gun"].ToString());
                            }
                            dr.Close();
                            d.myConnection.Close();
                            bitis_tarihi2 = baslangic_tarihi2.AddDays(kalan);
                            //--------------
                            d.myConnection.Open();
                            string sql2 = "update TBL_Uye_Tarifeler set baslangic_tarihi = @bas,bitis_tarihi = @bit ,durum = @durum where id = @id";
                            SQLiteCommand update_uye_tarifeler = new SQLiteCommand(sql2,d.myConnection);
                            update_uye_tarifeler.Parameters.AddWithValue("@bas",baslangic_tarihi2.ToShortDateString());
                            update_uye_tarifeler.Parameters.AddWithValue("@bit",bitis_tarihi2.ToShortDateString());
                            update_uye_tarifeler.Parameters.AddWithValue("@durum", "Aktif");
                            update_uye_tarifeler.Parameters.AddWithValue("@id",uye_tarife_id);
                            int result = update_uye_tarifeler.ExecuteNonQuery();
                            d.myConnection.Close();
                            if(result > 0)
                            {
                                d.myConnection.Open();
                                string sql3 = "DELETE  FROM TBL_Uyelik_Dondurma WHERE uye_tarifeler_id = @id";
                                SQLiteCommand delete_dondurma = new SQLiteCommand(sql3, d.myConnection);
                                delete_dondurma.Parameters.AddWithValue("@id", uye_tarife_id);
                                int result2 = delete_dondurma.ExecuteNonQuery();
                                if(result2 > 0)
                                {
                                    MessageBox.Show("Üyenin tarifesi başarı ile aktif edilmiştir.");
                                }
                            }


                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            d.myConnection.Close();
                            uye_tarife_doldur();
                        }
                    }
                    else if (durum == "Aktif")
                    {
                        MessageBox.Show("Seçilen tarife hali hazırda aktif durumdadır.");
                    }
                    else if (durum == "Pasif")
                    {
                        MessageBox.Show("Seçilen tarife üyelik süresi dolduğu için pasif durumdadır.");
                    }
                }
            }
        }

    
        bool kapansinmi = false;
        private void Frm_UyeTarifeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_UyeGoruntule frm = (Frm_UyeGoruntule)Application.OpenForms["Frm_UyeGoruntule"];
            string  aranacak;
           
            aranacak = "";
            frm.doldur(aranacak,parametre);
            frm.kalan_gun_hesap();
            frm.doldur(aranacak, parametre);
            frm.renklendir();
            frm.sifirla();



        }

        
    }
}
