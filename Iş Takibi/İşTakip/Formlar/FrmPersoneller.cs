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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();
        public void listele()
        {
            var liste = from x in db.TblPersonel
                         select new
                         {
                             x.ID,
                             x.Ad,
                             x.Soyad,
                             x.Mail,
                             departman=x.TblDepartmanlar.Ad,
                             x.Durum
                         };
            gridControl1.DataSource = liste.Where(x => x.Durum == true).ToList();

         }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            listele();

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

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frm = new FrmPersonelEkle();
            frm.Show();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtId.Text);
            var deger=db.TblPersonel.Find(x);
            deger.Durum=false;
            db.SaveChanges();

            XtraMessageBox.Show(" Personel Silme İşlemi Başarılı Bir Şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            
            int x=int.Parse(TxtId.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Ad=TxtAd.Text;
            deger.Soyad=TxtSoyad.Text;
            deger.Mail=TxtMail.Text;
            deger.Görsel=TxtGörsel.Text;
            deger.Departman=int.Parse(DepartmanList.EditValue.ToString());
            
            XtraMessageBox.Show("Personel Bilgileri Başarılı Bir Şekilde Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            db.SaveChanges();
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
           // TxtGörsel.Text = gridView1.GetFocusedRowCellValue("Görsel").ToString();
            DepartmanList.Text = gridView1.GetFocusedRowCellValue("departman").ToString();
            
        }
    }
}
