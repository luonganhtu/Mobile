namespace MobileManagement.SubForm
{
    partial class frmSubCategoryDetails
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
            this.dgvSubCategoryDetails = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoryDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubCategoryDetails
            // 
            this.dgvSubCategoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategoryDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameItem});
            this.dgvSubCategoryDetails.Location = new System.Drawing.Point(18, 19);
            this.dgvSubCategoryDetails.Name = "dgvSubCategoryDetails";
            this.dgvSubCategoryDetails.Size = new System.Drawing.Size(436, 218);
            this.dgvSubCategoryDetails.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Mã";
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Tên Sản Phẩm";
            this.NameItem.Name = "NameItem";
            this.NameItem.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSubCategoryDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm Thuộc Phân Loại";
            // 
            // frmSubCategoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSubCategoryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSubCategoryDetails";
            this.Load += new System.EventHandler(this.frmSubCategoryDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategoryDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubCategoryDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}