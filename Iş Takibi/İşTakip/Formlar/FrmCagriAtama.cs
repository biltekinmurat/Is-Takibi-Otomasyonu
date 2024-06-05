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
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }
        public int id;
        DbişTakipEntities db=new DbişTakipEntities();
        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            var degerler = (from c in db.TblPersonel
                            select new
                            {
                                c.ID,
                                AdSoyad = c.Ad + " " + c.Soyad
                            }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;

            TxtCagriId.Enabled = false;
            TxtCagriId.Text=id.ToString();
           
            var gelenveri = db.TblCagrilar.Find(id);
            TxtAçıklama.Text = gelenveri.Acıklama;
            TxtTarih.Text = gelenveri.Tarih.ToString();
            txtKonu.Text = gelenveri.Konu;
            

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilar.Find(id);
            gelenveri.Konu = txtKonu.Text;
            gelenveri.Tarih = DateTime.Parse(TxtTarih.Text);
            gelenveri.Acıklama = TxtAçıklama.Text;
            gelenveri.CagriPersonel=int.Parse(lookUpEdit1.EditValue.ToString());

            db.SaveChanges();

        }
    }
}
