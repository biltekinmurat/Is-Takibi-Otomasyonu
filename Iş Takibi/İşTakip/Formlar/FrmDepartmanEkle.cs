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

namespace İşTakip.Formlar
{
    public partial class FrmDepartmanEkle : Form
    {
        public FrmDepartmanEkle()
        {
            InitializeComponent();
        }
        DbişTakipEntities db = new DbişTakipEntities();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.Ad = TxtAd.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Başarılı Bir Şekilde Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmDepartmanlar frm = new FrmDepartmanlar();

            this.Close();
            frm.Listele();
        }
    }
}
