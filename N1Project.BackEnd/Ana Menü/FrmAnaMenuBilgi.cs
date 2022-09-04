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
using N1Project.BackEnd.Cari;
using N1Project.BackEnd.Stok;
using N1Project.Entities.Context;

namespace N1Project.BackEnd.Ana_Menü
{
    public partial class FrmAnaMenuBilgi : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenuBilgi()
        {
            InitializeComponent();
            
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmCari form = new FrmCari();
            form.MdiParent = this;
            form.Show();
        }
    }
}