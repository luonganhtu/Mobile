using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.ItemLocalhost;
using BusinessLogicLayer.CategoryLocalhost;
using BusinessLogicLayer.SubCategoryLocalhost;
using BusinessLogicLayer;
using BusinessLogicLayer.Business;

namespace MobileManagement
{
    public partial class frmManagerCategory : Form
    {
        public frmManagerCategory()
        {
            InitializeComponent();
            LoadComboBoxCategory();
        }
        CategoryBusiness _CategoryBusiness;
        private List<CategoryDTO> _lstCategory = new List<CategoryDTO>();
        SubCategoryBusiness _SubCategoryBusiness;
        private List<SubCategoryDTO> _lstSubCategory = new List<SubCategoryDTO>();
        ItemBusiness _ItemBusiness;
        private List<ItemDTO> _lstItem = new List<ItemDTO>();
       
        private enum ACTION : int
        {
            LOADING = 1,
            NONE = 0
        }

        private int currentAction = (int)ACTION.NONE;

        private void frmManagerCategory_Load(object sender, EventArgs e)
        {

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
            cbCategory.DataSource = lstCategory;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            #endregion
        }



        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ItemBusiness = new ItemBusiness();
            _CategoryBusiness = new CategoryBusiness();
            _SubCategoryBusiness = new SubCategoryBusiness();
            if (cbCategory.Items.Count > 0)
            {
                int index = cbCategory.SelectedIndex;
                if (index == 0)
                {
                    dgvSubCategory.Rows.Clear();
                    dgvItem.Rows.Clear();
                }
                else
                {
                    _lstSubCategory = _SubCategoryBusiness.GetListSubCategoryWhenIdCategory((int)cbCategory.SelectedValue);
                    dgvSubCategory.Rows.Clear();
                    for(int i = 0; i< _lstSubCategory.Count; i++)
                    {
                        var c = dgvSubCategory.Rows.Add();
                        dgvSubCategory.Rows[c].Cells[0].Value = _lstSubCategory[i].Id;
                        dgvSubCategory.Rows[c].Cells[1].Value = _lstSubCategory[i].Name;
                    }
                     _lstItem = _ItemBusiness.GetListItemWhenCategoryId((int)cbCategory.SelectedValue);
                    dgvItem.Rows.Clear();
                    for(int j = 0; j < _lstItem.Count; j++)
                    {
                        var d = dgvItem.Rows.Add();
                        dgvItem.Rows[d].Cells[0].Value = _lstItem[j].Id;
                        dgvItem.Rows[d].Cells[1].Value = _ItemBusiness.SelectNameItem(_lstItem[j].Id);
                    }
                }
            }
        }
    }
}
