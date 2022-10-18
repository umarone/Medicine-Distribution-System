using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.BLL;
using MetroFramework.Forms;
using Accounts.Common;
namespace Accounts.UI
{
    public partial class frmTrackBatchNo : MetroForm
    {
        public frmTrackBatchNo()
        {
            InitializeComponent();
        }

        private void frmTrackBatchNo_Load(object sender, EventArgs e)
        {
            this.grdBatchNo.AutoGenerateColumns = false;
        }

        private void btnLoadHistory_Click(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            decimal DebitStock = 0, CreditStock = 0, Balance = 0, Qty = 0;
            List<VoucherDetailEL> list = manager.TrackBatchNo(txtBatchNo.Text);
            if (list.Count > 0)
            {
                grdBatchNo.DataSource = list;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].AccountType == "In")
                    {
                        DebitStock = Validation.GetSafeDecimal(grdBatchNo.Rows[i].Cells["colUnits"].Value);
                        Balance += DebitStock;
                        grdBatchNo.Rows[i].Cells["colAvailableStock"].Value = Balance;
                        Qty += Validation.GetSafeDecimal(grdBatchNo.Rows[i].Cells["colUnits"].Value);

                    }
                    if (list[i].AccountType == "Out")
                    {
                        CreditStock = Validation.GetSafeDecimal(grdBatchNo.Rows[i].Cells["colUnits"].Value);
                        Balance -= CreditStock;
                        grdBatchNo.Rows[i].Cells["colAvailableStock"].Value = Balance.ToString();
                        Qty -= Validation.GetSafeDecimal(grdBatchNo.Rows[i].Cells["colUnits"].Value);
                    }
                }
            }
            else
            {
                grdBatchNo.DataSource = null;
                MessageBox.Show("Record Not Found....");
            }
        }
    }
}
