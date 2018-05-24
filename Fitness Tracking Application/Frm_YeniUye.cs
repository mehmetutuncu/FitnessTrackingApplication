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
    public partial class Frm_YeniUye : Form
    {
        string uyelik_tarihi;
        string id;
        string parametre;
        public Frm_YeniUye(string gelen_id,string gelen_parametre)
        {
            InitializeComponent();
            id = gelen_id;
            parametre = gelen_parametre;
        }

        private void Frm_YeniUye_Load(object sender, EventArgs e)
        {
            if(id != "0")
            {
                btn_Kaydet.Text = "Güncelle";
                cmb_doldur();
                doldur();
                
            }
            else
            {
                rb_Erkek.Checked = true;
                cmb_doldur();
                cmb_Yas.SelectedText = "Seçiniz!";
            }
            
        }
        int index;
        public void doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "select * from TBL_Uyeler where id = '" + id + "'";
                SQLiteCommand select_uyeler = new SQLiteCommand(sql,d.myConnection);
                SQLiteDataReader dr = select_uyeler.ExecuteReader();
                while (dr.Read())
                {
                    txt_Ad.Text = dr["ad"].ToString();
                    txt_Soyad.Text = dr["soyad"].ToString();
                    DateTime dt = DateTime.Parse(dr["dogum_tarihi"].ToString());
                    txt_dogumTarihi.Text = dt.ToShortDateString();
                    if(dr["cinsiyet"].ToString() == "Erkek")
                    {
                        rb_Erkek.Checked = true;
                    }
                    else
                    {
                        rb_Kadin.Checked = true;
                    }
                    mtxt_CepNo.Text = dr["cepno"].ToString();
                    txt_Adres.Text = dr["adres"].ToString();
                    string yas = dr["yas"].ToString();
                    
                    for(int i = 0; i<cmb_Yas.Items.Count; i++)
                    {
                        cmb_Yas.SelectedIndex = i;
                        if(cmb_Yas.SelectedIndex.ToString() == yas)
                        {
                            index = i;
                        }
                    }
                    cmb_Yas.SelectedIndex = index;
                    uyelik_tarihi = dr["uyelik_tarihi"].ToString();
                    
                }
                dr.Close();

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
        public void cmb_doldur()
        {
            for(int i = 0; i < 99; i++)
            {
                cmb_Yas.Items.Add(i);
            }
        }
        db d = new db();
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(id != "0")
            {
                if (txt_Ad.Text == "" && txt_Ad.Text.Length == 0)
                {
                    MessageBox.Show("Ad boş bırakılamaz.");
                }
                else if (txt_Soyad.Text == "" && txt_Soyad.Text.Length == 0)
                {
                    MessageBox.Show("Soyad boş bırakılamaz.");
                }
                else if (txt_Adres.Text == "" && txt_Adres.Text.Length == 0)
                {
                    MessageBox.Show("Adres boş bırakılamaz.");
                }

                else if (mtxt_CepNo.Text.Length < 14)
                {
                    MessageBox.Show("Cep Telefonu boş bırakılamaz.");
                }
                else
                {
                    txt_Ad.CharacterCasing = CharacterCasing.Upper;
                    string ad = txt_Ad.Text;
                    txt_Soyad.CharacterCasing = CharacterCasing.Upper;
                    string soyad = txt_Soyad.Text;
                    string adres = txt_Adres.Text;

                    string yas = cmb_Yas.SelectedItem.ToString();
                    string cinsiyet;
                    if (rb_Erkek.Checked == true)
                    {
                        cinsiyet = rb_Erkek.Text;
                    }
                    else
                    {
                        cinsiyet = rb_Kadin.Text;
                    }
                    string dogumTarihi = txt_dogumTarihi.Text;
                    
                    string cepno = mtxt_CepNo.Text;
                    try
                    {
                        d.myConnection.Open();
                        string sql = "UPDATE TBL_Uyeler set ad = @ad , soyad = @soyad , yas = @yas," +
                            "cinsiyet = @cinsiyet,dogum_tarihi = @dogum_tarihi,uyelik_tarihi = @uyelik_tarihi,adres = @adres,cepno = @cepno where id = @id";
                        SQLiteCommand update_uyeler = new SQLiteCommand(sql, d.myConnection);
                        update_uyeler.Parameters.AddWithValue("@ad",ad);
                        update_uyeler.Parameters.AddWithValue("@soyad",soyad);
                        update_uyeler.Parameters.AddWithValue("@yas",yas);
                        update_uyeler.Parameters.AddWithValue("@cinsiyet",cinsiyet);
                        update_uyeler.Parameters.AddWithValue("@dogum_tarihi",dogumTarihi);
                        update_uyeler.Parameters.AddWithValue("@uyelik_tarihi",uyelik_tarihi);
                        update_uyeler.Parameters.AddWithValue("@adres",adres);
                        update_uyeler.Parameters.AddWithValue("@cepno",cepno);
                        update_uyeler.Parameters.AddWithValue("@id",id);
                        int result = update_uyeler.ExecuteNonQuery();
                        if(result > 0)
                        {
                            MessageBox.Show("Başarı ile güncellendi.");
                            Frm_UyeGoruntule frm = (Frm_UyeGoruntule)Application.OpenForms["Frm_UyeGoruntule"];
                            string aranacak = "1";
                            
                            frm.doldur(aranacak,parametre);
                            
                            
                            
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        
                        this.Close();
                    }
                }
            }
            else
            {
                if (txt_Ad.Text == "" && txt_Ad.Text.Length == 0)
                {
                    MessageBox.Show("Ad boş bırakılamaz.");
                }
                else if (txt_Soyad.Text == "" && txt_Soyad.Text.Length == 0)
                {
                    MessageBox.Show("Soyad boş bırakılamaz.");
                }
                else if (txt_Adres.Text == "" && txt_Adres.Text.Length == 0)
                {
                    MessageBox.Show("Adres boş bırakılamaz.");
                }

                else if (mtxt_CepNo.Text.Length < 14)
                {
                    MessageBox.Show("Cep Telefonu boş bırakılamaz.");
                }
                else
                {
                    txt_Ad.CharacterCasing = CharacterCasing.Upper;
                    string ad = txt_Ad.Text;
                    txt_Soyad.CharacterCasing = CharacterCasing.Upper;
                    string soyad = txt_Soyad.Text;
                    string adres = txt_Adres.Text;

                    string yas = cmb_Yas.SelectedItem.ToString();
                    string cinsiyet;
                    if (rb_Erkek.Checked == true)
                    {
                        cinsiyet = rb_Erkek.Text;
                    }
                    else
                    {
                        cinsiyet = rb_Kadin.Text;
                    }
                    string dogumTarihi = txt_dogumTarihi.Text;
                    string kayitTarihi = DateTime.Now.ToShortDateString();
                    string cepno = mtxt_CepNo.Text;
                    try
                    {
                        d.myConnection.Open();
                        string sql = "insert into TBL_Uyeler(ad,soyad,yas,cinsiyet,dogum_tarihi,uyelik_tarihi,adres,cepno) VALUES(@ad,@soyad,@yas,@cinsiyet,@dogum,@uyelik,@adres,@cep)";
                        SQLiteCommand insert_uyeler = new SQLiteCommand(sql, d.myConnection);
                        insert_uyeler.Parameters.AddWithValue("@ad", ad);
                        insert_uyeler.Parameters.AddWithValue("@soyad", soyad);
                        insert_uyeler.Parameters.AddWithValue("@yas", yas);
                        insert_uyeler.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        insert_uyeler.Parameters.AddWithValue("@dogum", dogumTarihi);
                        insert_uyeler.Parameters.AddWithValue("@uyelik", kayitTarihi);
                        insert_uyeler.Parameters.AddWithValue("@adres", adres);
                        insert_uyeler.Parameters.AddWithValue("@cep", cepno);
                        int result = insert_uyeler.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarılı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        this.Close();
                    }
                }
            }

            
        }

        private void txt_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_Adres_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
