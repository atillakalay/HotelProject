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

namespace HotelProject.FormTanımlamalar
{
    public partial class FrmIslemler : Form
    {
        OtelEntities dbEntities=new OtelEntities();
        public FrmIslemler()
        {
            InitializeComponent();
        }

        private void FrmIslemler_Load(object sender, EventArgs e)
        {
            dbEntities.TBLISLEMLER.Load();
            bindingSource1.DataSource = dbEntities.TBLISLEMLER.Local;
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
