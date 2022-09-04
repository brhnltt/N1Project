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
    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal=new CariDAL();
        N1ProjectContext context=new N1ProjectContext();
        private string _carikodu = null;
        public FrmCariHareket(string carikodu)
        {
            InitializeComponent();
            _carikodu = carikodu;
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
           gridcontFisToplam.DataSource= cariDal.CariFisGenelToplam(context, _carikodu);
           gridcontCariEks.DataSource = cariDal.CariGenelToplam(context, _carikodu);
           gridcontCariHareket.DataSource = cariDal.CariFisAyrinti(context, _carikodu);
        }
    }
}