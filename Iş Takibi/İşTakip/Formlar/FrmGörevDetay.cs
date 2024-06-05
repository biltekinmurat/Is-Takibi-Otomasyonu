﻿using İşTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşTakip.Formlar
{
    public partial class FrmGörevDetay : Form
    {
        public FrmGörevDetay()
        {
            InitializeComponent();
        }
        DbişTakipEntities db=new DbişTakipEntities();
        private void FrmGörevDetay_Load(object sender, EventArgs e)
        {
            db.TblGörevDetaylar.Load();
            bindingSource1.DataSource = db.TblGörevDetaylar.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void görevDetaySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
