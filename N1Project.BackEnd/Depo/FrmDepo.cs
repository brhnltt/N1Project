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

namespace N1Project.BackEnd.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        public FrmDepo()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmDepoIslem form = new FrmDepoIslem();
            form.ShowDialog();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}