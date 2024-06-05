using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using İşTakip.Entity;

namespace İşTakip.Formlar
{
    public partial class FrmGorev : DevExpress.XtraEditors.XtraForm
    {
        public FrmGorev()
        {
            InitializeComponent();
        }

        private void BtnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbişTakipEntities db=new DbişTakipEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblGörevler t=new TblGörevler();
            t.Açıklama = TxtAçıklama.Text;
            t.Durumu=true;
            t.Tarih=Convert.ToDateTime(TxtGörevTarih.Text);
            t.GörevVeren = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GörevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblGörevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt işlemi başarıyla Tanımlandı ","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
             
        }

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            var degerler = (from c in db.TblPersonel
                                select new
                                {
                                    c.ID,
                                    AdSoyad=c.Ad+" "+c.Soyad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;
            var degerler2 = (from c in db.TblAdmin
                            select new
                            {
                                c.ID,
                                c.Kullanici
                            }).ToList();

            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "Kullanici";
            lookUpEdit2.Properties.DataSource = degerler2;



        }
    }
}
