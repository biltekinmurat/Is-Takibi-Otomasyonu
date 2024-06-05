using İşTakip.Formlar;
using İşTakip.FirmaFormlari;
using İşTakip.PersonelGörevFormlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanlar frm = new Formlar.FrmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }
        Formlar.FrmPersoneller frmpersonel;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmpersonel == null || frmpersonel.IsDisposed)
            {
                frmpersonel = new Formlar.FrmPersoneller();
                frmpersonel.MdiParent = this;
                frmpersonel.Show();

            }

        }
        Formlar.FrmPersonelIstatistik personelIstatık;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelIstatık == null || personelIstatık.IsDisposed)
            {
                personelIstatık = new Formlar.FrmPersonelIstatistik();
                personelIstatık.MdiParent = this;
                personelIstatık.Show();
            }

        }
        Formlar.FrmGörevListesi görevlistesli;
        private void BtnGörevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (görevlistesli == null || görevlistesli.IsDisposed)
            {
                görevlistesli = new Formlar.FrmGörevListesi();
                görevlistesli.MdiParent = this;
                görevlistesli.Show();
            }

        }

        private void BtnGorevTanımla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorev f = new Formlar.FrmGorev();
            f.Show();
        }

        private void FrmGörevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGörevDetay f = new Formlar.FrmGörevDetay();
            f.MdiParent = this;
            f.Show();
        }
        Formlar.FrmAnaForm anasayfa;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new Formlar.FrmAnaForm();
                anasayfa.MdiParent = this;
                anasayfa.Show();

            }

        }
        FrmAktifCagrilar fr;
        private void btnaktifcagri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //new FrmAktifCagrilar();
            if (fr == null || fr.IsDisposed)
            {
                fr = new FrmAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new Formlar.FrmAnaForm();
                anasayfa.MdiParent = this;
                anasayfa.Show();

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartmanEkle frm = new FrmDepartmanEkle();
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonelEkle frm = new FrmPersonelEkle();
            frm.Show();

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAktifGörevler frm = new FrmAktifGörevler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPasifGörevler frm = new FrmPasifGörevler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnpasifcagri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesap makinesi açılamadı: " + ex.Message);
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            OpenLink("https://www.youtube.com/");
        }

        private void OpenLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("bağlantı açılamadı: " + ex.Message);
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenLink("https://news.ycombinator.com/");
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenLink("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenLink("https://www.google.com.tr/maps/@38.6183269,34.734558,13z?hl=tr&entry=ttu");
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmaLİstesi frm = new FrmFirmaLİstesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFirmaEkle frm = new FrmFirmaEkle();
            frm.Show();
        }
    }
}
