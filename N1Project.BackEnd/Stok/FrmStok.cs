using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using N1Project.Entities.Context;
using N1Project.Entities.Data_Access;

namespace N1Project.BackEnd.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        private N1ProjectContext context = new N1ProjectContext();
        private StokDAL stokDal = new StokDAL();
        private string secilen;
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void GetAll()
        {
            gridControl1.DataSource=stokDal.GetAllJoin(context);
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfiltre_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnfiltreiptal_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void btnfiltrekapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnguncl_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstiyor Musunuz ?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
                stokDal.Delete(context,c=>c.StokKodu==secilen);
                stokDal.Save(context);
                GetAll();
            }
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmStokİslem form = new FrmStokİslem(new Entities.Tables.Stok());
            form.ShowDialog();
        }

        private void btnkpy_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
            stokEntity = stokDal.GetByFilter(context, c => c.StokKodu == secilen);
            stokEntity.Id = -1;
            stokEntity.StokKodu = null;
            FrmStokİslem form = new FrmStokİslem(stokEntity);
            form.ShowDialog();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokİslem form = new FrmStokİslem(stokDal.GetByFilter(context, c => c.StokKodu == secilen));
            form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colStokKodu).ToString();
            FrmStokHareket form = new FrmStokHareket(secilen);
            form.ShowDialog();
        }
    }
}