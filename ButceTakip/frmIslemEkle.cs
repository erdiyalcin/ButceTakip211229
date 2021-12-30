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
    public partial class frmIslemEkle : Form
    {
        ButceTakipContext db = new ButceTakipContext();
        public frmIslemEkle()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem();
            islem.aciklama = txtAciklama.Text;
            islem.islemTurID = (int)cmbIslemTur.SelectedValue;
            islem.tutar = Convert.ToDecimal(txtTutar.Text);
            islem.kullaniciID = Program.kullanici.kullaniciID;
            islem.tarih = DateTime.Now;
            db.Islem.Add(islem);
            int deger = db.SaveChanges();

            if (deger == 1)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
            this.Close();

        }


        private void frmIslemEkle_Load(object sender, EventArgs e)
        {
            cmbIslemTur.DataSource = db.IslemTur.ToList();
            cmbIslemTur.DisplayMember = "ad";
            cmbIslemTur.ValueMember = "islemTurID";
        }
    }
}
