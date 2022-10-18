namespace Accounts.UI
{
    partial class frmFindProductByBatchAndExpiry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdFindStock = new Accounts.UI.CustomDataGrid();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFindStock)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFindStock
            // 
            this.grdFindStock.AllowUserToAddRows = false;
            this.grdFindStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdFindStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFindStock.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFindStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdFindStock.ColumnHeadersHeight = 25;
            this.grdFindStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAccount,
            this.colPackingSize,
            this.colBatchNo,
            this.colMfg,
            this.colExpiry,
            this.colUnits});
            this.grdFindStock.EnableHeadersVisualStyles = false;
            this.grdFindStock.Location = new System.Drawing.Point(23, 59);
            this.grdFindStock.MultiSelect = false;
            this.grdFindStock.Name = "grdFindStock";
            this.grdFindStock.ReadOnly = true;
            this.grdFindStock.RowHeadersVisible = false;
            this.grdFindStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFindStock.Size = new System.Drawing.Size(538, 431);
            this.grdFindStock.TabIndex = 3;
            this.grdFindStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFindStock_CellDoubleClick);
            this.grdFindStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdFindStock_KeyPress);
            // 
            // colIdAccount
            // 
            this.colIdAccount.DataPropertyName = "IdItem";
            this.colIdAccount.HeaderText = "IdAccount";
            this.colIdAccount.Name = "colIdAccount";
            this.colIdAccount.ReadOnly = true;
            this.colIdAccount.Visible = false;
            // 
            // colPackingSize
            // 
            this.colPackingSize.DataPropertyName = "PackingSize";
            this.colPackingSize.HeaderText = "PackingSize";
            this.colPackingSize.Name = "colPackingSize";
            this.colPackingSize.ReadOnly = true;
            this.colPackingSize.Width = 130;
            // 
            // colBatchNo
            // 
            this.colBatchNo.DataPropertyName = "BatchNo";
            this.colBatchNo.HeaderText = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.ReadOnly = true;
            // 
            // colMfg
            // 
            this.colMfg.DataPropertyName = "Mfg";
            this.colMfg.HeaderText = "Mfg";
            this.colMfg.Name = "colMfg";
            this.colMfg.ReadOnly = true;
            // 
            // colExpiry
            // 
            this.colExpiry.DataPropertyName = "Expiry";
            this.colExpiry.HeaderText = "Expiry";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.ReadOnly = true;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Qty";
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // frmFindProductByBatchAndExpiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 518);
            this.Controls.Add(this.grdFindStock);
            this.Name = "frmFindProductByBatchAndExpiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindProductByBatchAndExpiry_FormClosing);
            this.Load += new System.EventHandler(this.frmFindProductByBatchAndExpiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFindStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid grdFindStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
    }
}