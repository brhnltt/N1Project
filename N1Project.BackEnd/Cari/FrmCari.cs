using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using N1Project.Entities.Context;
using N1Project.Entities.Data_Access;

namespace N1Project.BackEnd.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        N1ProjectContext context = new N1ProjectContext();
        CariDAL cariDal = new CariDAL();
        private string secilen = null;
        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }
        public FrmCari()
        {
            InitializeComponent();
        }

        private void grpmenu_Paint(object sender, PaintEventArgs e)
        {

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
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
                cariDal.Delete(context, c => c.CariKodu == secilen);
                cariDal.Save(context);
                GetAll();
            }

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmCariIslem form = new FrmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            FrmCariIslem form = new FrmCariIslem(cariDal.GetByFilter(context, c => c.CariKodu == secilen));
            form.ShowDialog();
        }

        private void btnkpy_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCariKodu).ToString();
            Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
            cariEntity = cariDal.GetByFilter(context, c => c.CariKodu == secilen);
            cariEntity.Id = -1;
            cariEntity.CariKodu = null;
            FrmCariIslem form = new FrmCariIslem(cariEntity);
            form.ShowDialog();
        }
    }
}