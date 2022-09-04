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

namespace N1Project.BackEnd.Kasa
{
    public partial class KasaFrm : DevExpress.XtraEditors.XtraForm
    {
        private N1ProjectContext context = new N1ProjectContext();
        private KasaDAL kasaDal = new KasaDAL();
        public KasaFrm()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form = new FrmKasaIslem();
            form.ShowDialog();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnfiltrekapat_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}