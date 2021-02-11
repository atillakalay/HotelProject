using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelProject.Entity;
using HotelProject.FormTanımlamalar;


namespace HotelProject.FormTanımlamalar
{
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }
        OtelEntities dbEntities=new OtelEntities();
        private void FrmBirim_Load(object sender, EventArgs e)
        {
            dbEntities.TBLBIRIMLER.Load();
            bindingSource1.DataSource = dbEntities.TBLBIRIMLER.Local;
            repositoryItemLookUpEdit1.DataSource = (from x in dbEntities.TBLDURUMLAR
                select new
                {
                    x.DURUMID,
                    x.DURUMAD
                }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            dbEntities.SaveChanges();
        }
    }
}
