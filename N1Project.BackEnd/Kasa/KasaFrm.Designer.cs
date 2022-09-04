namespace N1Project.BackEnd.Kasa
{
    partial class KasaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaFrm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnfiltre = new DevExpress.XtraEditors.SimpleButton();
            this.ımgmenu = new System.Windows.Forms.ImageList(this.components);
            this.btnfiltreiptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnfiltrekapat = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpmenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnara = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncl = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslık = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmenu)).BeginInit();
            this.grpmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 60);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltre);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltreiptal);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnfiltrekapat);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1106, 487);
            this.splitContainerControl1.SplitterPosition = 203;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // btnfiltre
            // 
            this.btnfiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltre.ImageOptions.ImageIndex = 2;
            this.btnfiltre.ImageOptions.ImageList = this.ımgmenu;
            this.btnfiltre.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltre.Location = new System.Drawing.Point(955, 155);
            this.btnfiltre.Name = "btnfiltre";
            this.btnfiltre.Size = new System.Drawing.Size(42, 38);
            this.btnfiltre.TabIndex = 9;
            // 
            // ımgmenu
            // 
            this.ımgmenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımgmenu.ImageStream")));
            this.ımgmenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ımgmenu.Images.SetKeyName(0, "add.png");
            this.ımgmenu.Images.SetKeyName(1, "delete.png");
            this.ımgmenu.Images.SetKeyName(2, "funnel.png");
            this.ımgmenu.Images.SetKeyName(3, "funnel_delete.png");
            this.ımgmenu.Images.SetKeyName(4, "KasaDuzenle.png");
            this.ımgmenu.Images.SetKeyName(5, "KasaEkle.png");
            this.ımgmenu.Images.SetKeyName(6, "KasaHareket.png");
            this.ımgmenu.Images.SetKeyName(7, "KasaSil.png");
            this.ımgmenu.Images.SetKeyName(8, "pencil.png");
            this.ımgmenu.Images.SetKeyName(9, "refresh.png");
            this.ımgmenu.Images.SetKeyName(10, "replace2.png");
            this.ımgmenu.Images.SetKeyName(11, "view.png");
            this.ımgmenu.Images.SetKeyName(12, "folder_out.png");
            // 
            // btnfiltreiptal
            // 
            this.btnfiltreiptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltreiptal.ImageOptions.ImageIndex = 3;
            this.btnfiltreiptal.ImageOptions.ImageList = this.ımgmenu;
            this.btnfiltreiptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltreiptal.Location = new System.Drawing.Point(1003, 155);
            this.btnfiltreiptal.Name = "btnfiltreiptal";
            this.btnfiltreiptal.Size = new System.Drawing.Size(47, 38);
            this.btnfiltreiptal.TabIndex = 8;
            // 
            // btnfiltrekapat
            // 
            this.btnfiltrekapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfiltrekapat.ImageOptions.ImageIndex = 12;
            this.btnfiltrekapat.ImageOptions.ImageList = this.ımgmenu;
            this.btnfiltrekapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnfiltrekapat.Location = new System.Drawing.Point(1056, 155);
            this.btnfiltrekapat.Name = "btnfiltrekapat";
            this.btnfiltrekapat.Size = new System.Drawing.Size(47, 38);
            this.btnfiltrekapat.TabIndex = 7;
            this.btnfiltrekapat.Click += new System.EventHandler(this.btnfiltrekapat_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.NodeSeparatorHeight = 2;
            this.filterControl1.Size = new System.Drawing.Size(1106, 203);
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1106, 274);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kasa Kodu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kasa Adı";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Yetkili Kodu";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Açıklama";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Kasa Giriş";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Kasa Çıkış";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Bakiye";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // grpmenu
            // 
            this.grpmenu.Controls.Add(this.simpleButton1);
            this.grpmenu.Controls.Add(this.btnkapat);
            this.grpmenu.Controls.Add(this.btnara);
            this.grpmenu.Controls.Add(this.btnguncl);
            this.grpmenu.Controls.Add(this.btnsil);
            this.grpmenu.Controls.Add(this.btnduzenle);
            this.grpmenu.Controls.Add(this.btnekle);
            this.grpmenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpmenu.Location = new System.Drawing.Point(0, 547);
            this.grpmenu.Name = "grpmenu";
            this.grpmenu.Size = new System.Drawing.Size(1106, 74);
            this.grpmenu.TabIndex = 4;
            this.grpmenu.Text = "Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 6;
            this.simpleButton1.ImageOptions.ImageList = this.ımgmenu;
            this.simpleButton1.Location = new System.Drawing.Point(295, 32);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(83, 38);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Kasa\r\nHareket";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 12;
            this.btnkapat.ImageOptions.ImageList = this.ımgmenu;
            this.btnkapat.Location = new System.Drawing.Point(1011, 32);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(83, 38);
            this.btnkapat.TabIndex = 6;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnara
            // 
            this.btnara.ImageOptions.ImageIndex = 11;
            this.btnara.ImageOptions.ImageList = this.ımgmenu;
            this.btnara.Location = new System.Drawing.Point(473, 32);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(83, 38);
            this.btnara.TabIndex = 5;
            this.btnara.Text = "Ara";
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnguncl
            // 
            this.btnguncl.ImageOptions.ImageIndex = 9;
            this.btnguncl.ImageOptions.ImageList = this.ımgmenu;
            this.btnguncl.Location = new System.Drawing.Point(384, 32);
            this.btnguncl.Name = "btnguncl";
            this.btnguncl.Size = new System.Drawing.Size(83, 38);
            this.btnguncl.TabIndex = 4;
            this.btnguncl.Text = "Güncelle";
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.ImageIndex = 7;
            this.btnsil.ImageOptions.ImageList = this.ımgmenu;
            this.btnsil.Location = new System.Drawing.Point(206, 32);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 38);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            // 
            // btnduzenle
            // 
            this.btnduzenle.ImageOptions.ImageIndex = 4;
            this.btnduzenle.ImageOptions.ImageList = this.ımgmenu;
            this.btnduzenle.Location = new System.Drawing.Point(117, 32);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(83, 38);
            this.btnduzenle.TabIndex = 1;
            this.btnduzenle.Text = "Düzenle";
            // 
            // btnekle
            // 
            this.btnekle.ImageOptions.ImageIndex = 5;
            this.btnekle.ImageOptions.ImageList = this.ımgmenu;
            this.btnekle.Location = new System.Drawing.Point(28, 31);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(83, 38);
            this.btnekle.TabIndex = 0;
            this.btnekle.Text = "Ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
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
            this.lblBaslık.Location = new System.Drawing.Point(0, 0);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(1106, 60);
            this.lblBaslık.TabIndex = 3;
            this.lblBaslık.Text = "Kasa Kartları";
            // 
            // KasaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 621);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.grpmenu);
            this.Controls.Add(this.lblBaslık);
            this.Name = "KasaFrm";
            this.Text = "KasaFrm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpmenu)).EndInit();
            this.grpmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnfiltre;
        private System.Windows.Forms.ImageList ımgmenu;
        private DevExpress.XtraEditors.SimpleButton btnfiltreiptal;
        private DevExpress.XtraEditors.SimpleButton btnfiltrekapat;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpmenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnara;
        private DevExpress.XtraEditors.SimpleButton btnguncl;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private DevExpress.XtraEditors.LabelControl lblBaslık;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}