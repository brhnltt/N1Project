namespace N1Project.BackEnd.Kasa
{
    partial class FrmKasaIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaIslem));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grpkdv = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.grpfiyatlar = new DevExpress.XtraEditors.GroupControl();
            this.memoaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.grpgenel = new DevExpress.XtraEditors.GroupControl();
            this.txtureticikodu = new DevExpress.XtraEditors.TextEdit();
            this.txtgaranti = new DevExpress.XtraEditors.TextEdit();
            this.txtstokadi = new DevExpress.XtraEditors.TextEdit();
            this.txtstokkodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.grpmenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslık = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpkdv)).BeginInit();
            this.grpkdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpfiyatlar)).BeginInit();
            this.grpfiyatlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpgenel)).BeginInit();
            this.grpgenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtureticikodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgaranti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmenu)).BeginInit();
            this.grpmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(5, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // grpkdv
            // 
            this.grpkdv.Controls.Add(this.memoaciklama);
            this.grpkdv.Controls.Add(this.labelControl11);
            this.grpkdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpkdv.Location = new System.Drawing.Point(0, 242);
            this.grpkdv.Name = "grpkdv";
            this.grpkdv.Size = new System.Drawing.Size(501, 118);
            this.grpkdv.TabIndex = 11;
            this.grpkdv.Text = "Diğer Bilgiler";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(5, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 23);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Kasa Adı : ";
            // 
            // grpfiyatlar
            // 
            this.grpfiyatlar.Controls.Add(this.labelControl6);
            this.grpfiyatlar.Controls.Add(this.labelControl7);
            this.grpfiyatlar.Controls.Add(this.txtureticikodu);
            this.grpfiyatlar.Controls.Add(this.txtgaranti);
            this.grpfiyatlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpfiyatlar.Location = new System.Drawing.Point(0, 152);
            this.grpfiyatlar.Name = "grpfiyatlar";
            this.grpfiyatlar.Size = new System.Drawing.Size(501, 90);
            this.grpfiyatlar.TabIndex = 12;
            this.grpfiyatlar.Text = "Diğer Bilgiler";
            // 
            // memoaciklama
            // 
            this.memoaciklama.Location = new System.Drawing.Point(113, 27);
            this.memoaciklama.Name = "memoaciklama";
            this.memoaciklama.Size = new System.Drawing.Size(376, 81);
            this.memoaciklama.TabIndex = 23;
            // 
            // grpgenel
            // 
            this.grpgenel.Controls.Add(this.txtstokadi);
            this.grpgenel.Controls.Add(this.txtstokkodu);
            this.grpgenel.Controls.Add(this.labelControl4);
            this.grpgenel.Controls.Add(this.labelControl2);
            this.grpgenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpgenel.Location = new System.Drawing.Point(0, 60);
            this.grpgenel.Name = "grpgenel";
            this.grpgenel.Size = new System.Drawing.Size(501, 92);
            this.grpgenel.TabIndex = 9;
            this.grpgenel.Text = "Kasa Bilgisi";
            this.grpgenel.Paint += new System.Windows.Forms.PaintEventHandler(this.grpgenel_Paint);
            // 
            // txtureticikodu
            // 
            this.txtureticikodu.Location = new System.Drawing.Point(113, 29);
            this.txtureticikodu.Name = "txtureticikodu";
            this.txtureticikodu.Size = new System.Drawing.Size(376, 20);
            this.txtureticikodu.TabIndex = 16;
            // 
            // txtgaranti
            // 
            this.txtgaranti.Location = new System.Drawing.Point(113, 57);
            this.txtgaranti.Name = "txtgaranti";
            this.txtgaranti.Size = new System.Drawing.Size(376, 20);
            this.txtgaranti.TabIndex = 15;
            // 
            // txtstokadi
            // 
            this.txtstokadi.Location = new System.Drawing.Point(110, 57);
            this.txtstokadi.Name = "txtstokadi";
            this.txtstokadi.Size = new System.Drawing.Size(379, 20);
            this.txtstokadi.TabIndex = 14;
            // 
            // txtstokkodu
            // 
            this.txtstokkodu.Location = new System.Drawing.Point(110, 28);
            this.txtstokkodu.Name = "txtstokkodu";
            this.txtstokkodu.Size = new System.Drawing.Size(236, 20);
            this.txtstokkodu.TabIndex = 12;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.Location = new System.Drawing.Point(8, 26);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(99, 82);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Açıklama :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(8, 55);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 23);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Yetkili Adı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(8, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(99, 23);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Yetkili Kodu :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "safe.png");
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.BorderColor = System.Drawing.Color.White;
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl28.Appearance.Options.UseBorderColor = true;
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Appearance.Options.UseTextOptions = true;
            this.labelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl28.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl28.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl28.Location = new System.Drawing.Point(2, 23);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(187, 71);
            this.labelControl28.TabIndex = 7;
            this.labelControl28.Text = "N1Project";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 1;
            this.btnkapat.ImageOptions.ImageList = this.ımageList1;
            this.btnkapat.Location = new System.Drawing.Point(394, 31);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(94, 58);
            this.btnkapat.TabIndex = 6;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // grpmenu
            // 
            this.grpmenu.Controls.Add(this.labelControl28);
            this.grpmenu.Controls.Add(this.btnkapat);
            this.grpmenu.Controls.Add(this.btnkaydet);
            this.grpmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpmenu.Location = new System.Drawing.Point(0, 360);
            this.grpmenu.Name = "grpmenu";
            this.grpmenu.Size = new System.Drawing.Size(501, 96);
            this.grpmenu.TabIndex = 8;
            this.grpmenu.Text = " ";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkaydet.ImageOptions.ImageIndex = 0;
            this.btnkaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnkaydet.Location = new System.Drawing.Point(295, 31);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(94, 58);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "Kaydet";
            // 
            // lblBaslık
            // 
            this.lblBaslık.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.Appearance.Options.UseFont = true;
            this.lblBaslık.Appearance.Options.UseTextOptions = true;
            this.lblBaslık.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslık.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslık.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslık.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslık.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslık.ImageOptions.Image")));
            this.lblBaslık.ImageOptions.ImageIndex = 2;
            this.lblBaslık.ImageOptions.Images = this.ımageList1;
            this.lblBaslık.Location = new System.Drawing.Point(0, 0);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(501, 60);
            this.lblBaslık.TabIndex = 7;
            this.lblBaslık.Text = "Kasa İşlemleri";
            // 
            // FrmKasaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 456);
            this.Controls.Add(this.grpkdv);
            this.Controls.Add(this.grpfiyatlar);
            this.Controls.Add(this.grpgenel);
            this.Controls.Add(this.grpmenu);
            this.Controls.Add(this.lblBaslık);
            this.Name = "FrmKasaIslem";
            this.Text = "FrmKasaIslem";
            ((System.ComponentModel.ISupportInitialize)(this.grpkdv)).EndInit();
            this.grpkdv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpfiyatlar)).EndInit();
            this.grpfiyatlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpgenel)).EndInit();
            this.grpgenel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtureticikodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgaranti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstokkodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmenu)).EndInit();
            this.grpmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grpkdv;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl grpfiyatlar;
        private DevExpress.XtraEditors.MemoEdit memoaciklama;
        private DevExpress.XtraEditors.GroupControl grpgenel;
        private DevExpress.XtraEditors.TextEdit txtureticikodu;
        private DevExpress.XtraEditors.TextEdit txtgaranti;
        private DevExpress.XtraEditors.TextEdit txtstokadi;
        private DevExpress.XtraEditors.TextEdit txtstokkodu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.GroupControl grpmenu;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl lblBaslık;
    }
}