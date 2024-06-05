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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGörevler
                                       select new
                                       {
                                           x.Açıklama,
                                           AdSoyad=x.TblPersonel.Ad+" "+x.TblPersonel.Soyad,
                                           x.Durumu
                                           
                                       }).Where(x=>x.Durumu==true).ToList();
            gridView1.Columns["Durumu"].Visible = false;

            //Bu Gün Yapıln Görevler
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());

            gridControl2.DataSource = (from x in db.TblGörevDetaylar 
                                    select new
                                    {
                                        Görev=x.TblGörevler.Açıklama,
                                        x.Açıklama,
                                        x.Tarih
                                    }).Where(x=>x.Tarih==bugün).ToList();

            //aktif çağrı listesi 

            gridControl3.DataSource = (from x in db.TblCagrilar 
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x=>x.Durum==true).ToList();
            
            gridView3.Columns["Durum"].Visible=false;

            //Fihrist komutları


            gridControl4.DataSource = (from x in db.TblFirmalar 
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail,
                                       }).ToList();


            //çağrı grafikleri 


           int akitif_çagrılar = db.TblCagrilar.Where(x => x.Durum == true).Count();
            int pasif_çağrılar = db.TblCagrilar.Where(x => x.Durum == false).Count();
            

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", akitif_çagrılar);

            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar",pasif_çağrılar);

        }
    }
}
