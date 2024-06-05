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

namespace İşTakip.Formlar
{
    public partial class FrmPersonelEkle : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.Ad = TxtAd.Text;
            t.Soyad = TxtSoyad.Text;
            t.Mail = TxtMail.Text;
            t.Sifre = TxtSifre.Text;
            t.Durum = true;
            t.Departman = int.Parse(DepartmanList.EditValue.ToString());

            db.TblPersonel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            var departmanlar = (from c in db.TblDepartmanlar
                                select new
                                {
                                    c.ID,
                                    c.Ad,
                                }).ToList();

            DepartmanList.Properties.ValueMember = "ID";
            DepartmanList.Properties.DisplayMember = "Ad";
            DepartmanList.Properties.DataSource = departmanlar;
        }
    }
}
