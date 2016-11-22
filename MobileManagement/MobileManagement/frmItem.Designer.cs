namespace MobileManagement
{
    partial class frmItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaHinh = new System.Windows.Forms.Button();
            this.btnThayDoiHinh = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.txtCamera = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListItem = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cameras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddSubCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbHinhAnh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnXoaHinh);
            this.panel1.Controls.Add(this.btnThayDoiHinh);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.txtPin);
            this.panel1.Controls.Add(this.txtRam);
            this.panel1.Controls.Add(this.txtCpu);
            this.panel1.Controls.Add(this.txtCamera);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 257);
            this.panel1.TabIndex = 0;
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.BackgroundImage = global::MobileManagement.Properties.Resources.no_image;
            this.pbHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHinhAnh.Location = new System.Drawing.Point(13, 14);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(161, 144);
            this.pbHinhAnh.TabIndex = 14;
            this.pbHinhAnh.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "VNĐ";
            // 
            // btnXoaHinh
            // 
            this.btnXoaHinh.Location = new System.Drawing.Point(97, 164);
            this.btnXoaHinh.Name = "btnXoaHinh";
            this.btnXoaHinh.Size = new System.Drawing.Size(61, 23);
            this.btnXoaHinh.TabIndex = 12;
            this.btnXoaHinh.Text = "Xóa";
            this.btnXoaHinh.UseVisualStyleBackColor = true;
            this.btnXoaHinh.Click += new System.EventHandler(this.btnXoaHinh_Click);
            // 
            // btnThayDoiHinh
            // 
            this.btnThayDoiHinh.Location = new System.Drawing.Point(13, 165);
            this.btnThayDoiHinh.Name = "btnThayDoiHinh";
            this.btnThayDoiHinh.Size = new System.Drawing.Size(61, 23);
            this.btnThayDoiHinh.TabIndex = 11;
            this.btnThayDoiHinh.Text = "Thay Đổi";
            this.btnThayDoiHinh.UseVisualStyleBackColor = true;
            this.btnThayDoiHinh.Click += new System.EventHandler(this.btnThayDoiHinh_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(402, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(183, 217);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(585, 113);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(585, 65);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(585, 17);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 8;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(293, 167);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(116, 20);
            this.txtRam.TabIndex = 8;
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(293, 113);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(116, 20);
            this.txtCpu.TabIndex = 8;
            // 
            // txtCamera
            // 
            this.txtCamera.Location = new System.Drawing.Point(293, 65);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(116, 20);
            this.txtCamera.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(293, 17);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(149, 20);
            this.txtTen.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(497, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số Lượng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Đơn Giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ram :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPU :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Camera :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sản Phẩm :";
            // 
            // dgvListItem
            // 
            this.dgvListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameItem,
            this.Cameras,
            this.Cpus,
            this.Rams,
            this.Pins,
            this.Price,
            this.Quantity});
            this.dgvListItem.Location = new System.Drawing.Point(12, 318);
            this.dgvListItem.Name = "dgvListItem";
            this.dgvListItem.ReadOnly = true;
            this.dgvListItem.Size = new System.Drawing.Size(595, 188);
            this.dgvListItem.TabIndex = 1;
            this.dgvListItem.SelectionChanged += new System.EventHandler(this.dgvListItem_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Mã";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameItem
            // 
            this.NameItem.HeaderText = "Tên Sản Phẩm";
            this.NameItem.Name = "NameItem";
            this.NameItem.ReadOnly = true;
            this.NameItem.Width = 200;
            // 
            // Cameras
            // 
            this.Cameras.HeaderText = "Camera";
            this.Cameras.Name = "Cameras";
            this.Cameras.ReadOnly = true;
            // 
            // Cpus
            // 
            this.Cpus.HeaderText = "Cpu";
            this.Cpus.Name = "Cpus";
            this.Cpus.ReadOnly = true;
            this.Cpus.Width = 200;
            // 
            // Rams
            // 
            this.Rams.HeaderText = "Ram";
            this.Rams.Name = "Rams";
            this.Rams.ReadOnly = true;
            // 
            // Pins
            // 
            this.Pins.HeaderText = "Pin";
            this.Pins.Name = "Pins";
            this.Pins.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(95, 276);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(305, 276);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(502, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(27, 32);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 53);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Thêm Vào Danh Mục";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddSubCategory
            // 
            this.btnAddSubCategory.Location = new System.Drawing.Point(27, 105);
            this.btnAddSubCategory.Name = "btnAddSubCategory";
            this.btnAddSubCategory.Size = new System.Drawing.Size(75, 53);
            this.btnAddSubCategory.TabIndex = 6;
            this.btnAddSubCategory.Text = "Thêm Vào Phân Loại";
            this.btnAddSubCategory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.btnAddSubCategory);
            this.groupBox1.Location = new System.Drawing.Point(624, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 188);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvListItem);
            this.Controls.Add(this.panel1);
            this.Name = "frmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItem";
            this.Load += new System.EventHandler(this.frmItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListItem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.TextBox txtCamera;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cameras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnXoaHinh;
        private System.Windows.Forms.Button btnThayDoiHinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddSubCategory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}