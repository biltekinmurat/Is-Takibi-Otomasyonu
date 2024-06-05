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

namespace İşTakip.PersonelGörevFormlari
{
    public partial class FrmAktifGörevler : Form
    {
        public FrmAktifGörevler()
        {
            InitializeComponent();
        }

        DbişTakipEntities db = new DbişTakipEntities();
        public string mail2;
        private void FrmAktifGörevler_Load(object sender, EventArgs e)
        {
            var personId=db.TblPersonel.Where(x=>x.Mail==mail2).Select(y=>y.ID).FirstOrDefault();

          
            var görevler = (from x in db.TblGörevler
                            select new
                            {
                                x.ID,
                                x.Açıklama,
                                x.Tarih,
                                x.GörevAlan,
                                x.Durumu

                            }).Where(x => x.GörevAlan == personId && x.Durumu == true).ToList();

            gridControl1.DataSource = görevler;
            gridView1.Columns["GörevAlan"].Visible = false;
            gridView1.Columns["Durumu"].Visible = false;
            
            
        }
    }
}
