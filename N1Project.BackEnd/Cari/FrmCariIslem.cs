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
    public partial class FrmCariIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.Cari _entity;
        private CariDAL cariDal = new CariDAL();
        private N1ProjectContext context = new N1ProjectContext();
        public FrmCariIslem(Entities.Tables.Cari entity)
        {
            
            InitializeComponent();
            _entity = entity;
            toogleDurum.DataBindings.Add("EditValue", _entity, "Durumu");
            txtCarikodu.DataBindings.Add("Text", _entity, "CariKodu");
            txtCariAdi.DataBindings.Add("Text", _entity, "CariAdi");
            cmbxCariTuru.DataBindings.Add("Text", _entity, "CariTuru");
            txtYetkilikisi.DataBindings.Add("Text", _entity, "YetkiliKisi");
            txtFaturaunvani.DataBindings.Add("Text", _entity, "FaturaUnvani");
            txtVergiDairesi.DataBindings.Add("Text", _entity, "VergiDairesi");
            memoaciklama.DataBindings.Add("Text", _entity, "Aciklama");
            txtCepTelefonu.DataBindings.Add("Text", _entity, "CepTelefonu");
            txtSabitTel.DataBindings.Add("Text", _entity, "Telefon");
            txtFax.DataBindings.Add("Text", _entity, "Fax");
            txtEmail.DataBindings.Add("Text", _entity, "Email");
            txtWeb.DataBindings.Add("Text", _entity, "Web");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            memoAdres.DataBindings.Add("Text", _entity, "Adres");
            btnCarigrubu.DataBindings.Add("Text", _entity, "CariGrubu");
            btnCariAltGrubu.DataBindings.Add("Text", _entity, "CariAltGrubu");
            btnOzelKod1.DataBindings.Add("Text", _entity, "OzelKod1");
            btnOzelKod2.DataBindings.Add("Text", _entity, "OzelKod2");
            buttonEdit1.DataBindings.Add("Text", _entity, "OzelKod3");
            buttonEdit4.DataBindings.Add("Text", _entity, "OzelKod4");
            cmbxAlisOzelFiyat.DataBindings.Add("Text", _entity, "AlisOzelFiyati");
            cmbxSatisOzelFiyat.DataBindings.Add("Text", _entity, "SatisOzelFiyati");

            cmbxIskonto.DataBindings.Add("Text", _entity, "IskontoOrani");
            cmbxIskonto.DataBindings[0].FormattingEnabled = true;
            cmbxIskonto.DataBindings[0].FormatString = "'%'0";
            cmbxIskonto.DataBindings[0].DataSourceNullValue = "0";

            cmbxRiskLimit.DataBindings.Add("Text", _entity, "RiskLimiti");
            cmbxRiskLimit.DataBindings[0].FormattingEnabled = true;
            cmbxRiskLimit.DataBindings[0].FormatString = "C2";
            cmbxRiskLimit.DataBindings[0].DataSourceNullValue = "0";
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (cariDal.AddOrUpdate(context, _entity))
            {
                cariDal.Save(context);
                this.Close();
            }
        }
    }
}