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
using BusinessLogicLayer.SubCategoryLocalhost;
using BusinessLogicLayer.Utilities;
using BusinessLogicLayer;
using BusinessLogicLayer.Business;

namespace MobileManagement
{
    public partial class frmSubCategory : Form
    {       
        public frmSubCategory()
        {
            InitializeComponent();
            LoadComboBoxCategory();
        }
        CategoryBusiness _CategoryBusiness;
        SubCategoryBusiness _SubCategoryBusiness;
        private List<SubCategoryDTO> _lstSubCategory;
        private List<CategoryDTO> _lstCategory = new List<CategoryDTO>();
       
        private enum DIEUKHIEN : int
        {
            MO = 1,
            DONG = 0
        }
        private enum ACTION : int
        {
            LOADING = 1,
            NONE = 0
        }
        int g = 0;
        private int currentAction = (int)ACTION.NONE;

        private void DieuKhien(int dieukhien)
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

        private void LoadComboBoxCategory()
        {
            #region combobox Category
            _CategoryBusiness = new CategoryBusiness();
            List<CategoryDTO> lstCategory = new List<CategoryDTO>();
            CategoryDTO category = new CategoryDTO();
            category.Id = -1;
            category.Name = "Chọn Danh Mục";
            lstCategory.Add(category);
            _lstCategory = _CategoryBusiness.GetCategoryList();
            foreach (CategoryDTO item in _lstCategory)
            {
                lstCategory.Add(item);
            }
            cbNameCategory.DataSource = lstCategory;
            cbNameCategory.DisplayMember = "Name";
            cbNameCategory.ValueMember = "Id";
            #endregion
        }
        private void frmSubCategory_Load(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.MO);
            LoadData();
        }
     

        private void LoadData()
        {
            _SubCategoryBusiness = new SubCategoryBusiness();
            _CategoryBusiness = new CategoryBusiness();
            currentAction = (int)ACTION.LOADING;
            _lstSubCategory = _SubCategoryBusiness.GetSubCategoryList();
            dgvListSubCategory.Rows.Clear();
            for (int i = 0; i < _lstSubCategory.Count; i++)
            {
                int inDex = dgvListSubCategory.Rows.Add();
                dgvListSubCategory.Rows[inDex].Cells[0].Value = _lstSubCategory[i].Id;
                dgvListSubCategory.Rows[inDex].Cells[1].Value = _CategoryBusiness.SelectNameCategory(_lstSubCategory[i].CategoryId);
                dgvListSubCategory.Rows[inDex].Cells[2].Value = _lstSubCategory[i].Name;
            }
            currentAction = (int)ACTION.NONE;
            if (_lstSubCategory.Count > 0)
            {
                dgvListSubCategory.Rows[0].Selected = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.DONG);
            g = 1;
            txtName.Text = "";
            LoadComboBoxCategory();
        }

        private void dgvListSubCategory_SelectionChanged(object sender, EventArgs e)
        {
            _CategoryBusiness = new CategoryBusiness();
            if (currentAction == (int)ACTION.NONE)
            {
                var index = dgvListSubCategory.CurrentCell.RowIndex;
                if (index > -1)
                {
                    txtName.Text = dgvListSubCategory.Rows[index].Cells[2].Value.ToString().Trim();
                    cbNameCategory.SelectedValue = _CategoryBusiness.SelectIdCategory(dgvListSubCategory.Rows[index].Cells[1].Value.ToString().Trim());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.DONG);
            g = 2;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.MO);
            LoadData();
            g = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var index = dgvListSubCategory.CurrentCell.RowIndex;
            _SubCategoryBusiness = new SubCategoryBusiness();
            int ma = -1;
            bool kiemTra = false;
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên Loại Không Được Trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((int)cbNameCategory.SelectedValue == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #region Lưu khi thêm
            else if (g == 1)
            {
                SubCategoryDTO subCategory = new SubCategoryDTO();
                subCategory.Name = txtName.Text.ToString().Trim();
                subCategory.CategoryId = (int)cbNameCategory.SelectedValue;
                kiemTra = _SubCategoryBusiness.ExisSubName(txtName.Text.ToString(), ma, (int)cbNameCategory.SelectedValue);
                if(kiemTra == false)
                {
                    MessageBox.Show("Tên loại thuộc danh mục này đã tồn tại! Vui Lòng Chọn Tên Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if(_SubCategoryBusiness.AddSubCategory(subCategory))
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
                SubCategoryDTO subCategory = _lstSubCategory.ElementAtOrDefault(index);
               subCategory.Name = txtName.Text.ToString().Trim();
                subCategory.CategoryId = (int)cbNameCategory.SelectedValue;
                kiemTra = _SubCategoryBusiness.ExisSubName(txtName.Text.ToString(), int.Parse(dgvListSubCategory.Rows[index].Cells[0].Value.ToString()), (int)cbNameCategory.SelectedValue);
                if (kiemTra == false)
                {
                    MessageBox.Show("Tên loại thuộc danh mục này đã tồn tại! Vui Lòng Chọn Tên Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_SubCategoryBusiness.EditSubCategory(subCategory))
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
                _SubCategoryBusiness = new SubCategoryBusiness();
                var index = dgvListSubCategory.CurrentCell.RowIndex;
                bool kiemTra = false;
                kiemTra = _SubCategoryBusiness.CanDeleteSubCategory(int.Parse(dgvListSubCategory.Rows[index].Cells[0].Value.ToString()));
                if (kiemTra == false)
                {
                    MessageBox.Show("Loại điện thoại thuộc danh mục này chưa thể xóa được! muốn xóa loại này xin xóa các sản phẩm của loại điện thoại thuộc danh mục này trước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_SubCategoryBusiness.DeleteSubCategory(int.Parse(dgvListSubCategory.Rows[index].Cells[0].Value.ToString())))
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
