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
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }
        public string mail;
        private void BtnAktifGörevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGörevFormlari.FrmAktifGörevler frm= new PersonelGörevFormlari.FrmAktifGörevler();

            frm.MdiParent = this;
            frm.mail2=mail;
            frm.Show();
        }
        private void BtnPasifGörev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGörevFormlari.FrmPasifGörevler frm = new PersonelGörevFormlari.FrmPasifGörevler();
            frm.MdiParent = this;
            frm.mail2=mail;
            frm.Show();

        }

        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCagriListesi fr=new FrmCagriListesi();
            fr.MdiParent = this;
            fr.mail2 = mail;
            fr.Show();
        }

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
