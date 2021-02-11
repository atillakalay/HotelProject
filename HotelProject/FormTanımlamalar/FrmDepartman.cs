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
using DevExpress.XtraEditors;
using HotelProject.Entity;
using HotelProject.FormTanımlamalar;

namespace HotelProject.FormTanımlamalar
{

    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        OtelEntities dbEntities = new OtelEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            dbEntities.TBLDEPARTMANLAR.Load();
            bindingSource1.DataSource = dbEntities.TBLDEPARTMANLAR.Local;
            repositoryItemLookUpEdit1.DataSource = (from x in dbEntities.TBLDURUMLAR
                                                    select new
                                                    {
                                                        x.DURUMID,
                                                        x.DURUMAD
                                                    }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                dbEntities.SaveChanges();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata oluştu tekrar deneyin !","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
