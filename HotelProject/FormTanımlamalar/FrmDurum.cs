using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using HotelProject.Entity;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace HotelProject.FormTanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        OtelEntities db = new OtelEntities();
        private void FrmDurum_Load(object sender, EventArgs e)
        {

            db.TBLDURUMLAR.Load();
            bindingSource1.DataSource = db.TBLDURUMLAR.Local;

        }

        private void gridView1_CellValueChanged(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void durumSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
