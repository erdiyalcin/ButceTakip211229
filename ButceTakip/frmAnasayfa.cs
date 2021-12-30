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
    public partial class frmAnasayfa : Form
    {
        ButceTakipContext db = new ButceTakipContext();

        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            Kullanici k = Program.kullanici;
            lblKullanici.Text = k.Yetki.ad + " : " + k.ad + " " + k.soyad;
            Doldur();
        }

        public void Doldur()
        {
            if (Program.kullanici.yetkiID == 1)
            {
                var liste = db.Islem.Select(x => new
                {
                    x.islemID,
                    kullanici = x.Kullanici.ad + " " + x.Kullanici.soyad,
                    x.aciklama,
                    x.tarih,
                    x.IslemTur.ad,
                    x.tutar
                }).ToList();
                dataListe.DataSource = liste;
            }
            else
            {
                var liste = db.Islem
                    .Where(x=> x.kullaniciID == Program.kullanici.kullaniciID)
                    .Select(x => new
                    {
                        x.islemID,
                        x.aciklama,
                        x.tarih,
                        x.IslemTur.ad,
                        x.tutar
                    }).ToList();
                dataListe.DataSource = liste;
            }

           
        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            frmIslemEkle frm = new frmIslemEkle();
            DialogResult sonuc = frm.ShowDialog();
            if(sonuc == DialogResult.OK)
                Doldur();
            else
                MessageBox.Show("İşlem iptal edildi.");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int islemID = (int)dataListe.SelectedRows[0].Cells[0].Value;
            Islem islem = db.Islem.Where(x => x.islemID == islemID).SingleOrDefault();
            if(islem != null)
            {
                DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "İşlem Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(sonuc==DialogResult.Yes)
                {
                    db.Islem.Remove(islem);
                    db.SaveChanges();
                    Doldur();
                }
                else
                    MessageBox.Show("Silme işlemi iptal edildi.");
            }
            else
                MessageBox.Show("İşlem bulunamadı.");
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int islemID = (int)dataListe.SelectedRows[0].Cells[0].Value;
            Islem islem = db.Islem.Where(x => x.islemID == islemID).SingleOrDefault();
            frmIslemDuzenle frm = new frmIslemDuzenle();
            frm.islem = islem;
            DialogResult sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
                Doldur();
            else
                MessageBox.Show("İptal edildi.");
        }
    }
}
