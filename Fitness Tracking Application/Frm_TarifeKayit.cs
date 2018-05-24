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
    public partial class Frm_TarifeKayit : Form
    {
        db d = new db();
        string id;
        public Frm_TarifeKayit(string gelen_id)
        {
            InitializeComponent();
            id = gelen_id;
        }

        private void txt_Fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if(id == "0")
            {
                if (txt_TarifeAdi.Text.Length == 0 && txt_TarifeAdi.Text == "")
                {
                    MessageBox.Show("Dikkat!", "Tarife adı boş bırakılamaz.", MessageBoxButtons.OK);
                }
                else if (txt_Fiyat.Text.Length == 0 && txt_Fiyat.Text == "")
                {
                    MessageBox.Show("Dikkat!", "Tarife fiyatı  boş bırakılamaz.", MessageBoxButtons.OK);
                }
                else
                {
                    string tarife_adi = txt_TarifeAdi.Text;
                    int fiyat = int.Parse(txt_Fiyat.Text);
                    try
                    {
                        d.myConnection.Open();
                        string sql = "INSERT INTO TBL_Tarifeler(tarife_adi,fiyat) VALUES(@ad,@fiyat)";
                        SQLiteCommand insert_tarifeler = new SQLiteCommand(sql, d.myConnection);
                        insert_tarifeler.Parameters.AddWithValue("@ad", tarife_adi);
                        insert_tarifeler.Parameters.AddWithValue("@fiyat", fiyat);
                        int result = insert_tarifeler.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Tarife Kaydı Başarılı.");
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        Frm_TarifeGoruntule frm = (Frm_TarifeGoruntule)Application.OpenForms["Frm_TarifeGoruntule"];
                        string aranacak = "";
                        frm.doldur(aranacak);
                        this.Close();
                    }
                }
            }
            else
            {
                if (txt_TarifeAdi.Text.Length == 0 && txt_TarifeAdi.Text == "")
                {
                    MessageBox.Show("Tarife adı  boş bırakılamaz.", "Dikkat!", MessageBoxButtons.OK);
                }
                else if (txt_Fiyat.Text.Length == 0 && txt_Fiyat.Text == "")
                {
                    MessageBox.Show("Tarife fiyatı  boş bırakılamaz.", "Dikkat!", MessageBoxButtons.OK);
                }
                else
                {
                    string tarife_adi = txt_TarifeAdi.Text;
                    int fiyat = int.Parse(txt_Fiyat.Text);
                    try
                    {
                        d.myConnection.Open();
                        string sql = "update TBL_Tarifeler set tarife_adi = @ad ,fiyat = @fiyat where id = @id";
                        SQLiteCommand update_tarifeler = new SQLiteCommand(sql,d.myConnection);
                        update_tarifeler.Parameters.AddWithValue("@ad",tarife_adi);
                        update_tarifeler.Parameters.AddWithValue("@fiyat",fiyat);
                        update_tarifeler.Parameters.AddWithValue("@id",id);
                        int result = update_tarifeler.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Tarife başarı ile güncellendi.");
                            Frm_TarifeGoruntule frm = (Frm_TarifeGoruntule)Application.OpenForms["Frm_TarifeGoruntule"];
                            string aranacak = "";
                            frm.doldur(aranacak);
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
        public void doldur()
        {
            try
            {
                d.myConnection.Open();
                string sql = "select * from TBL_Tarifeler where id = @id";
                SQLiteCommand select_tarifeler = new SQLiteCommand(sql, d.myConnection);
                select_tarifeler.Parameters.AddWithValue("@id",id);
                SQLiteDataReader dr = select_tarifeler.ExecuteReader();
                while (dr.Read())
                {
                    txt_TarifeAdi.Text = dr["tarife_adi"].ToString();
                    txt_Fiyat.Text = dr["fiyat"].ToString();
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
        private void Frm_TarifeKayit_Load(object sender, EventArgs e)
        {
            if (id != "0")
            {
                btn_Kaydet.Text = "Güncelle";
                doldur();
            }
        }
    }
}
