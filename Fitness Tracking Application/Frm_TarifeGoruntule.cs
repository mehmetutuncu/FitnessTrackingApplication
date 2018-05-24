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
    public partial class Frm_TarifeGoruntule : Form
    {
        db d = new db();
        public Frm_TarifeGoruntule()
        {
            InitializeComponent();
        }

        private void txt_Arama_KeyUp(object sender, KeyEventArgs e)
        {
            string aranan = "";
            if(txt_Arama.Text != "")
            {
                aranan = "%" + txt_Arama.Text + "%";
            }
            doldur(aranan);
        }
        string sql;
        public void doldur(string aranan)
        {
            try
            {
                d.myConnection.Open();
                if(aranan == "")
                {
                    sql = "select * from TBL_Tarifeler";
                }
                else
                {
                    sql = "select * from TBL_Tarifeler WHERE tarife_adi LIKE @ad";
                }
                SQLiteCommand select_tarifeler = new SQLiteCommand(sql, d.myConnection);
                select_tarifeler.Parameters.AddWithValue("@ad",aranan);
                SQLiteDataAdapter da = new SQLiteDataAdapter(select_tarifeler);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Tarifeler.DataSource = dt;
                dgv_Tarifeler.Columns["id"].Visible = false;
                dgv_Tarifeler.Columns["tarife_adi"].HeaderText = "Tarife Adı";
                dgv_Tarifeler.Columns["tarife_adi"].Width = 120;
                dgv_Tarifeler.Columns["fiyat"].HeaderText = "Fiyat";
                dgv_Tarifeler.Columns["fiyat"].Width = 120;
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

        private void Frm_TarifeGoruntule_Load(object sender, EventArgs e)
        {
            string aranacak = "";
            doldur(aranacak);
            if(dgv_Tarifeler.Rows.Count != 0)
            {
                
                
            }
            
        }

        private void btn_TarifeEkle_Click(object sender, EventArgs e)
        {
            string id = "0";
            Frm_TarifeKayit frm = new Frm_TarifeKayit(id);
            frm.ShowDialog();
        }

        private void btn_TarifeDuzenle_Click(object sender, EventArgs e)
        {
            if(dgv_Tarifeler.CurrentCell == null)
            {
                MessageBox.Show("Tarife seçmediğiniz için işleminizi gerçekleştiremiyorum.");
            }
            else
            {
                string id = dgv_Tarifeler.CurrentRow.Cells["id"].Value.ToString();
                Frm_TarifeKayit frm = new Frm_TarifeKayit(id);
                frm.ShowDialog();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_Tarifeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tarife seçmediğiniz için işleminizi gerçekleştiremiyorum.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        string id = dgv_Tarifeler.CurrentRow.Cells["id"].Value.ToString();
                        d.myConnection.Open();
                        string sql = "delete from TBL_Tarifeler where id = @id";
                        SQLiteCommand delete_tarifeler = new SQLiteCommand(sql,d.myConnection);
                        delete_tarifeler.Parameters.AddWithValue("@id",id);
                        int result = delete_tarifeler.ExecuteNonQuery();
                        if(result > 0)
                        {
                            MessageBox.Show("Kayıt başarı ile silindi.");
                            
                        }
                            
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        d.myConnection.Close();
                        Frm_TarifeGoruntule frm = (Frm_TarifeGoruntule)Application.OpenForms["Frm_TarifeGoruntule"];
                        string aranacak = "";
                        frm.doldur(aranacak);
                    }
                }
                
            }
        }
    }
}
