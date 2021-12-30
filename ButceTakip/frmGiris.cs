using ButceTakip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButceTakip
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            ButceTakipContext db = new ButceTakipContext();

            string eposta, sifre;
            eposta = txtEposta.Text;
            sifre = txtSifre.Text;

            if(eposta=="" || sifre=="")
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            Kullanici k = db.Kullanici.Where(x => x.eposta == eposta && x.sifre == sifre).SingleOrDefault();
            if(k!=null)
            {
                Program.kullanici = k;
                new frmAnasayfa().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eposta veya şifre hatalı");
                txtSifre.Text = "";
                txtSifre.Focus();
            }
                

        }
    }
}
