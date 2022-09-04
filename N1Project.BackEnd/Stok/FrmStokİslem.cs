using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N1Project.Entities.Context;
using N1Project.Entities.Data_Access;

namespace N1Project.BackEnd.Stok
{
    public partial class FrmStokİslem : Form
    {
        private Entities.Tables.Stok _entity;
        private StokDAL stokDal = new StokDAL();
        private N1ProjectContext context = new N1ProjectContext();
        public FrmStokİslem(Entities.Tables.Stok entity)
        {
            InitializeComponent();
            _entity = entity;
            toogleDurum.DataBindings.Add("EditValue", _entity, "Durumu");
            txtstokkodu.DataBindings.Add("Text", _entity, "StokKodu");
            txtbarkod.DataBindings.Add("Text", _entity, "Barkod");
            cmbxbarkodturu.DataBindings.Add("Text", _entity, "BarkodTuru");
            txtstokadi.DataBindings.Add("Text", _entity, "StokAdi");
            btnbirim.DataBindings.Add("Text", _entity, "Birimi");
            txtureticikodu.DataBindings.Add("Text", _entity, "UreticiKodu");
            txtgaranti.DataBindings.Add("Text", _entity, "GarantiSuresi");

            calcmaxstok.DataBindings.Add("Text", _entity, "MaxStokMiktari");
            calcmaxstok.DataBindings[0].FormattingEnabled = true;
            calcmaxstok.DataBindings[0].FormatString = "N3";

            calcminstok.DataBindings.Add("Text", _entity, "MinStokMiktari");
            calcminstok.DataBindings[0].FormattingEnabled = true;
            calcminstok.DataBindings[0].FormatString = "N3";

            memoaciklama.DataBindings.Add("Text", _entity, "Aciklama");
            btnstokgrubu.DataBindings.Add("Text", _entity, "StokGrubu");
            btnStokAltGrubu.DataBindings.Add("Text", _entity, "StokAltGrubu");
            btnmarka.DataBindings.Add("Text", _entity, "Marka");
            btnmodel.DataBindings.Add("Text", _entity, "Modeli");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            btnOzelKod3.DataBindings.Add("Text", _entity, "OzelKod3");
            btnOzelKod4.DataBindings.Add("Text", _entity, "OzelKod4");

            calcAliskdv.DataBindings.Add("Text", _entity, "AlisKdv");
            calcAliskdv.DataBindings[0].FormattingEnabled = true;
            calcAliskdv.DataBindings[0].FormatString = "'%'0";

            calcsatiskdv.DataBindings.Add("Text", _entity, "SatisKdv");
            calcsatiskdv.DataBindings[0].FormattingEnabled = true;
            calcsatiskdv.DataBindings[0].FormatString = "'%'0";

            calcAlisfiyati1.DataBindings.Add("Text", _entity, "AlisFiyati1");
            calcAlisfiyati1.DataBindings[0].FormattingEnabled = true;
            calcAlisfiyati1.DataBindings[0].FormatString = "C2";

            calcAlisfiyati2.DataBindings.Add("Text", _entity, "AlisFiyati2");
            calcAlisfiyati2.DataBindings[0].FormattingEnabled = true;
            calcAlisfiyati2.DataBindings[0].FormatString = "C2";

            calcAlisfiyati3.DataBindings.Add("Text", _entity, "AlisFiyati3");
            calcAlisfiyati3.DataBindings[0].FormattingEnabled = true;
            calcAlisfiyati3.DataBindings[0].FormatString = "C2";

            calcSatisfiyati1.DataBindings.Add("Text", _entity, "SatisFiyati1");
            calcSatisfiyati1.DataBindings[0].FormattingEnabled = true;
            calcSatisfiyati1.DataBindings[0].FormatString = "C2";

            calcSatisfiyati2.DataBindings.Add("Text", _entity, "SatisFiyati2");
            calcSatisfiyati2.DataBindings[0].FormattingEnabled = true;
            calcSatisfiyati2.DataBindings[0].FormatString = "C2";

            calcSatisfiyati3.DataBindings.Add("Text", _entity, "SatisFiyati3");
            calcSatisfiyati3.DataBindings[0].FormattingEnabled = true;
            calcSatisfiyati3.DataBindings[0].FormatString = "C2";


        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            stokDal.AddOrUpdate(context, _entity);
            stokDal.Save(context);
            this.Close();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmStokİslem_Load(object sender, EventArgs e)
        {

        }
    }
}
