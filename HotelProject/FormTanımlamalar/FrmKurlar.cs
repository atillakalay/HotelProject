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
    public partial class FrmKurlar : Form
    {
        OtelEntities dbEntities=new OtelEntities();
        public FrmKurlar()
        {
            InitializeComponent();
        }

        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            dbEntities.TBLKURLAR.Load();
            bindingSource1.DataSource = dbEntities.TBLKURLAR.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            dbEntities.SaveChanges();
        }
    }
}
