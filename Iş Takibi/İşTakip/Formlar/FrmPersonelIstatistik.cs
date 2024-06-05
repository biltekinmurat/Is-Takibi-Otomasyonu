using İşTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşTakip.Formlar
{
    public partial class FrmPersonelIstatistik : Form
    {
        public FrmPersonelIstatistik()
        {
            InitializeComponent();
        }
        DbişTakipEntities db=new DbişTakipEntities();
        private void FrmPersonelIstatistik_Load(object sender, EventArgs e)
        {
            LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
            LblToplamFirma.Text=db.TblFirmalar.Count().ToString();
            LblToplamPersonel.Text=db.TblPersonel.Count().ToString();

            LblAktifIş.Text=db.TblGörevler.Count(x=>x.Durumu==true).ToString();
            LblPasifIş.Text=db.TblGörevler.Count(x=>x.Durumu==false).ToString();

            LblSonGörev.Text = db.TblGörevler.OrderByDescending(x=>x.ID).Select(x => x.Açıklama).FirstOrDefault();
            lblGörevDetay.Text = db.TblGörevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();

            LblŞehir.Text = db.TblFirmalar.Select(x=>x.il).Distinct().Count().ToString();
            LblSektör.Text=db.TblFirmalar.Select(x=>x.Sektör).Distinct().Count().ToString();   

            LblBugünAçılanGÖREV.Text=db.TblGörevler.Count(x=>x.Tarih==DateTime.Today).ToString();


            var d1 = db.TblGörevler.GroupBy(x => x.GörevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            LblAyınPersoneli.Text=db.TblPersonel.Where(x=>x.ID==d1).Select(y=>y.Ad+y.Soyad).FirstOrDefault().ToString();

            LblAyınDepartmani.Text = db.TblDepartmanlar.Where(x => x.ID == db.TblPersonel.Where(t=>t.ID==d1).Select(z=>z.Departman).FirstOrDefault()).Select(y=>y.Ad).FirstOrDefault().ToString();




        }
    }
}
