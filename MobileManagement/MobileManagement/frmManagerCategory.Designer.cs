namespace MobileManagement
{
    partial class frmManagerCategory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Mục :";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(147, 33);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(186, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSubCategory);
            this.groupBox2.Location = new System.Drawing.Point(25, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân Loại Thuộc Danh Mục";
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameSubCategory});
            this.dgvSubCategory.Location = new System.Drawing.Point(15, 19);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.Size = new System.Drawing.Size(419, 200);
            this.dgvSubCategory.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvItem);
            this.groupBox3.Location = new System.Drawing.Point(503, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản Phẩm Thuộc Danh Mục";
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdItem,
            this.NameItem});
            this.dgvItem.Location = new System.Drawing.Point(17, 19);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(387, 200);
            this.dgvItem.TabIndex = 0;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(30, 36);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(84, 45);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Danh Mục";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Location = new System.Drawing.Point(156, 36);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(84, 45);
            this.btnSubCategory.TabIndex = 4;
            this.btnSubCategory.Text = "Phân Loại";
            this.btnSubCategory.UseVisualStyleBackColor = true;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(266, 36);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(84, 45);
            this.btnItem.TabIndex = 5;
            this.btnItem.Text = "Sản Phẩm";
            this.btnItem.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCategory);
            this.groupBox4.Controls.Add(this.btnItem);
            this.groupBox4.Controls.Add(this.btnSubCategory);
            this.groupBox4.Location = new System.Drawing.Point(503, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quản Lý";
            // 
            // Id
            // 
            this.Id.HeaderText = "Mã";
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // NameSubCategory
            // 
            this.NameSubCategory.HeaderText = "Tên";
            this.NameSubCategory.Name = "NameSubCategory";
            this.NameSubCategory.Width = 250;
            // 
            // IdItem
            // 
            this.IdItem.HeaderText = "Mã";
            this.IdItem.Name = "IdItem";
            this.IdItem.Width = 150;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Tên";
            this.NameItem.Name = "NameItem";
            this.NameItem.Width = 250;
            // 
            // frmManagerCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 406);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManagerCategory";
            this.Text = "frmManagerCategory";
            this.Load += new System.EventHandler(this.frmManagerCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSubCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
    }
}