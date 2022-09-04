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

namespace N1Project.BackEnd.Kasa
{
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        public FrmKasaIslem()
        {
            InitializeComponent();
        }

        private void grpgenel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}