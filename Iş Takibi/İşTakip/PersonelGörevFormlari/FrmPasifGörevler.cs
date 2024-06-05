using DevExpress.XtraEditors;
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
    public partial class FrmPasifGörevler : Form
    {
        public FrmPasifGörevler()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();
        public string mail2;
        private void FrmPasifGörevler_Load(object sender, EventArgs e)
        {
            var personelId=db.TblPersonel.Where(x=>x.Mail==mail2).Select(x=>x.ID).FirstOrDefault();
            int sayı = gridView1.RowCount;
            if (sayı>=1)
            { var görevler = (from x in db.TblGörevler
                            select new
                            {
                                x.ID,
                                x.Açıklama,
                                x.Tarih,
                                x.GörevAlan,
                                x.Durumu

                            }).Where(x => x.GörevAlan == personelId && x.Durumu == false).ToList();

            gridControl1.DataSource = görevler;
            gridView1.Columns["GörevAlan"].Visible = false;
            gridView1.Columns["Durumu"].Visible = false;

            }
            else if(sayı<1)
            {
                XtraMessageBox.Show("Pasif Göreviniz Bulunmamaktadır",Text,MessageBoxButtons.OKCancel);
            }
           

        }
    }
}
