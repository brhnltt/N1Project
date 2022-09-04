using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using N1Project.Entities.Context;
using N1Project.Entities.Data_Access;

namespace N1Project.BackEnd.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        private N1ProjectContext context = new N1ProjectContext();
        private string _stokKodu;
        public FrmStokHareket(string stokKodu)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
        }

        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            gridcontStokHareket.DataSource = stokHareketDal.GetAll(context, c => c.StokKodu == _stokKodu);
            gridcontGenelStok.DataSource = stokDal.GetGenelStok(context, _stokKodu);
            gridcontDepoStok.DataSource = stokDal.GetDepoStok(context, _stokKodu);
        }

        private void gridcontStokHareket_Click(object sender, EventArgs e)
        {

        }
    }
}