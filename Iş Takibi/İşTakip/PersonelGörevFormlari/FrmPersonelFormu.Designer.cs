namespace İşTakip.PersonelGörevFormlari
{
    partial class FrmPersonelFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelFormu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAktifGörevler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPasifGörev = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCagriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnAktifGörevler,
            this.BtnPasifGörev,
            this.BtnCagriListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1084, 150);
            // 
            // BtnAktifGörevler
            // 
            this.BtnAktifGörevler.Caption = "Aktif Görevler";
            this.BtnAktifGörevler.Id = 1;
            this.BtnAktifGörevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAktifGörevler.ImageOptions.Image")));
            this.BtnAktifGörevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAktifGörevler.ImageOptions.LargeImage")));
            this.BtnAktifGörevler.Name = "BtnAktifGörevler";
            this.BtnAktifGörevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAktifGörevler_ItemClick);
            // 
            // BtnPasifGörev
            // 
            this.BtnPasifGörev.Caption = "Pasif Görevler";
            this.BtnPasifGörev.Id = 2;
            this.BtnPasifGörev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPasifGörev.ImageOptions.Image")));
            this.BtnPasifGörev.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPasifGörev.ImageOptions.LargeImage")));
            this.BtnPasifGörev.Name = "BtnPasifGörev";
            this.BtnPasifGörev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPasifGörev_ItemClick);
            // 
            // BtnCagriListesi
            // 
            this.BtnCagriListesi.Caption = "Çağrı Listesi";
            this.BtnCagriListesi.Id = 3;
            this.BtnCagriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCagriListesi.ImageOptions.Image")));
            this.BtnCagriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCagriListesi.ImageOptions.LargeImage")));
            this.BtnCagriListesi.Name = "BtnCagriListesi";
            this.BtnCagriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCagriListesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Personel Bilgileri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAktifGörevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPasifGörev);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCagriListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmPersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmPersonelFormu";
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.FrmPersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem BtnAktifGörevler;
        private DevExpress.XtraBars.BarButtonItem BtnPasifGörev;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnCagriListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}