using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.OData;
using N1Project.BackEnd.Ana_Menü;
using N1Project.BackEnd.Cari;
using N1Project.BackEnd.Depo;
using N1Project.BackEnd.Fiş_Ve_Fatura;
using N1Project.BackEnd.Kasa;
using N1Project.BackEnd.Stok;
using N1Project.Entities.Context;
using N1Project.Entities.Data_Access;
using N1Project.Entities.Tables;

namespace N1Project.BackEnd
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            using (var context = new N1ProjectContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmAnaMenuBilgi form = new FrmAnaMenuBilgi();
            form.MdiParent = this;
            form.Show();
            N1ProjectContext context = new N1ProjectContext();
            CariDAL cariDal = new CariDAL();
            /*
            Entities.Tables.Cari entity = new Entities.Tables.Cari {
                CariKodu = "123456789",
                CariAdi = "Samet Erkök",
                YetkiliKisi = "Burhan",
                FaturaUnvani = "Samet"
            };
            
            cariDal.AddOrUpdate(context, entity);
            cariDal.Save(context);
            */

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStok form = new FrmStok();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KasaFrm form = new KasaFrm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisveFaturaFrm form = new FisveFaturaFrm();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepo form = new FrmDepo();
            form.MdiParent = this;
            form.Show();
        }
    }
}
