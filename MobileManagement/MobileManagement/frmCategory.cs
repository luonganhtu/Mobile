using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.CategoryLocalhost;
using BusinessLogicLayer.Utilities;
using BusinessLogicLayer;

namespace MobileManagement
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        private enum ACTION : int
        {
            LOADING = 1,
            NONE = 0
        }

        private enum DIEUKHIEN : int
        {
            DONG = 0,
            MO = 1
        }

        #region Điều Khiển
        public void DieuKhien(int dieukhien)
        {
            if (dieukhien == ((int)DIEUKHIEN.DONG))
            {
                panel1.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else if (dieukhien == ((int)DIEUKHIEN.MO))
            {
                panel1.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        #endregion
        int g = 1;

        private int currentAction = (int)ACTION.NONE;
        CategoryBusiness _CategoryBusiness;
        List<CategoryDTO> ListCategory;
        private void frmCategory_Load(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.MO);
            LoadData();
        }
        private void LoadData()
        {
            _CategoryBusiness = new CategoryBusiness();
            currentAction = (int)ACTION.LOADING;
            ListCategory = _CategoryBusiness.GetCategoryList();
            dgvListCategory.Rows.Clear();
            for (int i = 0; i < ListCategory.Count; i++)
            {
                int inDex = dgvListCategory.Rows.Add();
                dgvListCategory.Rows[inDex].Cells[0].Value = ListCategory[i].Id;
                dgvListCategory.Rows[inDex].Cells[1].Value = ListCategory[i].Name;
            }
            currentAction = (int)ACTION.NONE;
            if (ListCategory.Count > 0)
            {
                dgvListCategory.Rows[0].Selected = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            g = 1;
            DieuKhien((int)DIEUKHIEN.DONG);
            txtName.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            g = 2;
            DieuKhien((int)DIEUKHIEN.DONG);
        }

        private void dgvListCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (currentAction == (int)ACTION.NONE)
            {
                var index = dgvListCategory.CurrentCell.RowIndex;
                if (index > -1)
                {
                    txtName.Text = dgvListCategory.Rows[index].Cells[1].Value.ToString().Trim();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.MO);
            g = 0;
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var index = dgvListCategory.CurrentCell.RowIndex;
            bool trung = false;
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên Danh Mục Không Được Trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #region Lưu khi Thêm
            else if (g == 1)
            {
                CategoryDTO category = new CategoryDTO();
                category.Name = txtName.Text.ToString().Trim();
                trung = _CategoryBusiness.ExisCattName(txtName.Text.ToString(), -1);
                if (trung == false)
                {
                    MessageBox.Show("Trùng Tên Danh Mục! Vui Lòng Chọn Tên Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_CategoryBusiness.AddCategory(category))
                    {
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            #endregion

            #region Lưu khi sửa
            else if (g == 2)
            {
                CategoryDTO category = ListCategory.ElementAtOrDefault(index);
                category.Name = txtName.Text.ToString().Trim();
                //category.Id = int.Parse(dgvListCategory.Rows[index].Cells[0].Value.ToString());
                trung = _CategoryBusiness.ExisCattName(txtName.Text.ToString(), int.Parse(dgvListCategory.Rows[index].Cells[0].Value.ToString()));
                if (trung == false)
                {
                    MessageBox.Show("Trùng Tên Danh Mục! Vui Lòng Chọn Tên Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_CategoryBusiness.EditCategory(category))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            #endregion

            DieuKhien((int)DIEUKHIEN.MO);
            g = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            else
            {
                var index = dgvListCategory.CurrentCell.RowIndex;
                bool kiemTra = false;
                kiemTra = _CategoryBusiness.CanDeleteCategory(int.Parse(dgvListCategory.Rows[index].Cells[0].Value.ToString()));
                if (kiemTra == false)
                {
                    MessageBox.Show("Danh mục này chưa thể xóa được! muốn xóa danh mục này xin xóa các phân loại và sản phẩm thuộc danh mục này trước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_CategoryBusiness.DeleteCategory(int.Parse(dgvListCategory.Rows[index].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Xóa Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
