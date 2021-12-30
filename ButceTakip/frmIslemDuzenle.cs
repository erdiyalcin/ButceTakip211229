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
    public partial class frmIslemDuzenle : Form
    {
        ButceTakipContext db = new ButceTakipContext();
        public Islem islem = new Islem();
        public frmIslemDuzenle()
        {
            InitializeComponent();
        }

        private void btnIslemDuzenle_Click(object sender, EventArgs e)
        {
            Islem i = db.Islem.Where(x => x.islemID == islem.islemID).SingleOrDefault();
            i.aciklama = txtAciklama.Text;
            i.tutar = Convert.ToDecimal(txtTutar.Text);
            i.islemTurID = (int)cmbIslemTur.SelectedValue;
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmIslemDuzenle_Load(object sender, EventArgs e)
        {
            cmbIslemTur.DataSource = db.IslemTur.ToList();
            cmbIslemTur.DisplayMember = "ad";
            cmbIslemTur.ValueMember = "islemTurID";
            txtAciklama.Text = islem.aciklama;
            txtTutar.Text = islem.tutar.ToString();
            cmbIslemTur.SelectedItem = islem.IslemTur;
        }
    }
}
