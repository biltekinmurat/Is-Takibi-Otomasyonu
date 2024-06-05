using DevExpress.XtraEditors;
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

namespace İşTakip.FirmaFormlari
{
    public partial class FrmFirmaEkle : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmaEkle()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblFirmalar t = new TblFirmalar();
            t.Ad = TxtAd.Text;
            t.Yetkili = txtyetkili.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = Txtmail.Text;
            t.Sifre=TXtŞifre.Text;
            t.Sektör = Sektörlist.EditValue.ToString();
            t.il=TxtIl.Text;
            t.ilçe = TxtIlçe.Text;
            t.Adres = TxtAdres.Text;
            db.TblFirmalar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Firma Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }

        private void FrmFirmaEkle_Load(object sender, EventArgs e)
        {
            var sektör = (from c in db.TblFirmalar
                                select new
                                {
                                    c.ID,
                                    c.Sektör,
                                }).ToList();

            Sektörlist.Properties.ValueMember = "ID";
            Sektörlist.Properties.DisplayMember = "Sektör";
            Sektörlist.Properties.DataSource = sektör;
        }
    }
}
