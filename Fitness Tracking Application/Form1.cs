using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracking_Application
{
    public partial class Frm_AnaForm : Form
    {
        public Frm_AnaForm()
        {
            InitializeComponent();
        }

        private void btn_yeniUye_Click(object sender, EventArgs e)
        {
            string id = "0";
            string parametre = "0";
            Frm_YeniUye frm = new Frm_YeniUye(id,parametre);
            frm.ShowDialog();
        }

        private void Frm_AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_TarifeEkle_Click(object sender, EventArgs e)
        {
            string id = "0";
            Frm_TarifeKayit frm = new Frm_TarifeKayit(id);
            frm.ShowDialog();
        }

        private void btn_UyeGoruntule_Click(object sender, EventArgs e)
        {
            Frm_UyeGoruntule frm = new Frm_UyeGoruntule();
            frm.ShowDialog();
        }

        private void btn_Tarifeler_Click(object sender, EventArgs e)
        {
            Frm_TarifeGoruntule frm = new Frm_TarifeGoruntule();
            frm.ShowDialog();
        }
    }
}
