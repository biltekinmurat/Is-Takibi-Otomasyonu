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
    public partial class FrmGörevListesi : Form
    {
        public FrmGörevListesi()
        {
            InitializeComponent();
        }

        DbişTakipEntities db = new DbişTakipEntities();
        private void FrmGörevListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGörevler
                                       select new
                                       {
                                           x.Açıklama
                                       }).ToList();

            LblAktifGörev.Text=db.TblGörevler.Where(x => x.Durumu==true).Count().ToString();
            LblPasifGörev.Text=db.TblGörevler.Where(x => x.Durumu==false).Count().ToString();
            LblToplamDepartman.Text=db.TblDepartmanlar.Count().ToString();


        }
    }
}
