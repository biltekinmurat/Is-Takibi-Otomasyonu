using DevExpress.XtraEditors;
using İşTakip.Entity;
using İşTakip.Formlar;
using İşTakip.PersonelGörevFormlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşTakip.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Form1 fr = new Form1();
            fr.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel3.BackColor=SystemColors.Control; 
            panel4.BackColor=Color.White;

        }
        DbişTakipEntities db=new DbişTakipEntities();
        private void btnadmin_Click(object sender, EventArgs e)
        {
            var adminvalue=db.TblAdmin.Where(x=>x.Kullanici==TxtKullanıcı.Text && x.Sifre==TxtSifre.Text).FirstOrDefault();

            if (adminvalue !=null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 fr =new Form1 ();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş");
            }
        }

        private void btnpersonel_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblPersonel.Where(x => x.Mail == TxtKullanıcı.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();

            if (adminvalue != null)
            {
                FrmPersonelFormu fr = new FrmPersonelFormu();
                fr.mail = TxtKullanıcı.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                XtraMessageBox.Show("Hatalı giriş");
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Yardım için 0434 827 1313 numaralı hattımızdan bize ulaşabilirisiniz");
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {

            XtraMessageBox.Show("Hesap Açmak İçin Yöneticiye başvurunuz");
        }
    }
}
