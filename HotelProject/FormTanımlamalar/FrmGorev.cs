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
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        OtelEntities dbEntities = new OtelEntities();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            dbEntities.TBLGOREVLER.Load();
            bindingSource1.DataSource = dbEntities.TBLGOREVLER.Local;

            repositoryItemLookUpEdit1.DataSource = (from x in dbEntities.TBLDEPARTMANLAR
                                                    select new
                                                    {
                                                        x.DEPARTMANID,
                                                        x.DEPARTMANAD
                                                    }).ToList();

            repositoryItemLookUpEdit2.DataSource = (from x in dbEntities.TBLDURUMLAR
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
