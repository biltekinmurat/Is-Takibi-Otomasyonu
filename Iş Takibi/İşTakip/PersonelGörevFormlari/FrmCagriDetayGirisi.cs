using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Filtering.Templates;
using İşTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşTakip.PersonelGörevFormlari
{
    public partial class FrmCagriDetayGirisi : Form
    {
        public FrmCagriDetayGirisi()
        {
            InitializeComponent();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int id;
        private void FrmCagriDetayGirisi_Load(object sender, EventArgs e)
        {
            TxtCagriId.Text = id.ToString();
            TxtCagriId.Enabled = false;
            string tarih = DateTime.Now.ToShortDateString();
            string saat = DateTime.Now.ToShortTimeString();

            TxtTarih.Text = tarih;
            txtsaat.Text = saat;
        }
        DbişTakipEntities db = new DbişTakipEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(TxtCagriId.Text);
            t.Saat=txtsaat.Text;
            t.Tarih=DateTime.Parse(TxtTarih.Text);  
            t.Aciklama=TxtAçıklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Başarılı Bir Şekilde Kayıt Edildi", Text, MessageBoxButtons.OK);


        }
    }
}
