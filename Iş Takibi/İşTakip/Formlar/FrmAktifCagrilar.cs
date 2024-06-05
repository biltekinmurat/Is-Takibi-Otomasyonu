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
    public partial class FrmAktifCagrilar : Form
    {
        public FrmAktifCagrilar()
        {
            InitializeComponent();
        }

        private void FrmAktifCagrilar_Load(object sender, EventArgs e)
        {
            DbişTakipEntities db = new DbişTakipEntities();

            var değerler = (from x in db.TblCagrilar
                            select new
                            {
                                x.ID,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Konu,
                                x.Acıklama,
                                personel = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
                                x.Durum
                            }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource = değerler;


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama fr=new FrmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
