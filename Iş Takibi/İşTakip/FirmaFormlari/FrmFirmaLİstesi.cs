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
    public partial class FrmFirmaLİstesi : Form
    {
        public FrmFirmaLİstesi()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();
        private void FrmFirmaLİstesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblFirmalar
                                       select new
                                       {
                                           x.ID,
                                           x.Ad,
                                           x.Yetkili,
                                           x.Telefon,
                                           x.Mail,
                                           x.Sektör,
                                           x.il

                                       }).ToList();
        }
    }
}
