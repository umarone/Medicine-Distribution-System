namespace Accounts.UI
{
    partial class frmTrackBatchNo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBatchNo = new MetroFramework.Controls.MetroTextBox();
            this.grdBatchNo = new System.Windows.Forms.DataGridView();
            this.btnLoadHistory = new MetroFramework.Controls.MetroButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailableStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBatchNo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBatchNo
            // 
            // 
            // 
            // 
            this.txtBatchNo.CustomButton.Image = null;
            this.txtBatchNo.CustomButton.Location = new System.Drawing.Point(364, 1);
            this.txtBatchNo.CustomButton.Name = "";
            this.txtBatchNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBatchNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBatchNo.CustomButton.TabIndex = 1;
            this.txtBatchNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBatchNo.CustomButton.UseSelectable = true;
            this.txtBatchNo.CustomButton.Visible = false;
            this.txtBatchNo.Lines = new string[0];
            this.txtBatchNo.Location = new System.Drawing.Point(28, 55);
            this.txtBatchNo.MaxLength = 32767;
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.PasswordChar = '\0';
            this.txtBatchNo.PromptText = "Enter Batch No";
            this.txtBatchNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBatchNo.SelectedText = "";
            this.txtBatchNo.SelectionLength = 0;
            this.txtBatchNo.SelectionStart = 0;
            this.txtBatchNo.ShortcutsEnabled = true;
            this.txtBatchNo.Size = new System.Drawing.Size(386, 23);
            this.txtBatchNo.TabIndex = 1;
            this.txtBatchNo.UseSelectable = true;
            this.txtBatchNo.WaterMark = "Enter Batch No";
            this.txtBatchNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBatchNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grdBatchNo
            // 
            this.grdBatchNo.AllowUserToAddRows = false;
            this.grdBatchNo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.grdBatchNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBatchNo.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBatchNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBatchNo.ColumnHeadersHeight = 25;
            this.grdBatchNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescription,
            this.colDate,
            this.colVoucherNo,
            this.colAccountName,
            this.colProductName,
            this.colUnits,
            this.colAvailableStock});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBatchNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdBatchNo.EnableHeadersVisualStyles = false;
            this.grdBatchNo.Location = new System.Drawing.Point(28, 81);
            this.grdBatchNo.Name = "grdBatchNo";
            this.grdBatchNo.ReadOnly = true;
            this.grdBatchNo.RowHeadersVisible = false;
            this.grdBatchNo.Size = new System.Drawing.Size(950, 275);
            this.grdBatchNo.TabIndex = 11;
            // 
            // btnLoadHistory
            // 
            this.btnLoadHistory.Location = new System.Drawing.Point(416, 55);
            this.btnLoadHistory.Name = "btnLoadHistory";
            this.btnLoadHistory.Size = new System.Drawing.Size(116, 23);
            this.btnLoadHistory.TabIndex = 12;
            this.btnLoadHistory.Text = "Load Batch History";
            this.btnLoadHistory.UseSelectable = true;
            this.btnLoadHistory.Click += new System.EventHandler(this.btnLoadHistory_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Discription";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VDate";
            dataGridViewCellStyle7.Format = "d";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VoucherNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vocuher #";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Closing";
            this.dataGridViewTextBoxColumn7.HeaderText = "Available Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Discription";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 130;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "VDate";
            dataGridViewCellStyle4.Format = "d";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.DataPropertyName = "VoucherNo";
            this.colVoucherNo.HeaderText = "Vocuher #";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 160;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ItemName";
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 200;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Qty";
            this.colUnits.HeaderText = "Qty";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // colAvailableStock
            // 
            this.colAvailableStock.DataPropertyName = "Closing";
            this.colAvailableStock.HeaderText = "Available Stock";
            this.colAvailableStock.Name = "colAvailableStock";
            this.colAvailableStock.ReadOnly = true;
            this.colAvailableStock.Width = 150;
            // 
            // frmTrackBatchNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(996, 390);
            this.Controls.Add(this.btnLoadHistory);
            this.Controls.Add(this.grdBatchNo);
            this.Controls.Add(this.txtBatchNo);
            this.MaximizeBox = false;
            this.Name = "frmTrackBatchNo";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Track Your Batch No.";
            this.Load += new System.EventHandler(this.frmTrackBatchNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBatchNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBatchNo;
        private System.Windows.Forms.DataGridView grdBatchNo;
        private MetroFramework.Controls.MetroButton btnLoadHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}