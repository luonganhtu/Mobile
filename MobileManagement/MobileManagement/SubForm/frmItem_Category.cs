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
using BusinessLogicLayer.ItemLocalhost;
using BusinessLogicLayer;
using BusinessLogicLayer.Business;

namespace MobileManagement.SubForm
{
    public partial class frmItem_Category : Form
    {
        public frmItem_Category()
        {
            InitializeComponent();
            LoadComboBoxCategory();
        }
        private enum ACTION : int
        {
            LOADING = 1,
            NONE = 0
        }
        private int currentAction = (int)ACTION.NONE;
        CategoryBusiness _CategoryBusiness;
        ItemBusiness _ItemBusiness;
        private List<CategoryDTO> _lstCategory = new List<CategoryDTO>();
        private List<ItemDTO> _lstItem = new List<ItemDTO>();
        private List<ItemDTO> lstItemDTO = new List<ItemDTO>();
        private ItemDTO Item = new ItemDTO();

        private void frmItem_Category_Load(object sender, EventArgs e)
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

        #region  Load Data
        private void LoadData()
        {
            currentAction = (int)ACTION.LOADING;
            _ItemBusiness = new ItemBusiness();
            _lstItem = _ItemBusiness.GetListItemNoRelationItemCategory((int)cbCategory.SelectedValue);
            dgvListItem.Rows.Clear();
            for (int i = 0; i < _lstItem.Count; i++)
            {
                var d = dgvListItem.Rows.Add();
                dgvListItem.Rows[d].Cells[0].Value = _lstItem[i].Id;
                dgvListItem.Rows[d].Cells[1].Value = _ItemBusiness.SelectNameItem(_lstItem[i].Id);
            }
        }
        #endregion

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ItemBusiness = new ItemBusiness();
            _CategoryBusiness = new CategoryBusiness();

            if (cbCategory.Items.Count > 0)
            {
                int index = cbCategory.SelectedIndex;
                if(index == 0)
                {
                    dgvListItem.Rows.Clear();
                }
                else
                {
                    _ItemBusiness = new ItemBusiness();
                    _lstItem = _ItemBusiness.GetListItemNoRelationItemCategory((int)cbCategory.SelectedValue);
                    dgvListItem.Rows.Clear();
                    for (int i = 0; i < _lstItem.Count; i++)
                    {
                        var d = dgvListItem.Rows.Add();
                        dgvListItem.Rows[d].Cells[0].Value = _lstItem[i].Id;
                        dgvListItem.Rows[d].Cells[1].Value = _ItemBusiness.SelectNameItem(_lstItem[i].Id);
                    }
                }
            }
        }

        #region Chọn Sản phẩm add vào listbox
        private void tSMISelect_Click(object sender, EventArgs e)
        {
            if (lbSelectItem.Items.Count == 0)
            {
                groupBox3.Enabled = true;
                _ItemBusiness = new ItemBusiness();
                int index = dgvListItem.CurrentCell.RowIndex;          
                lbSelectItem.Items.Add(_ItemBusiness.SelectNameItem(int.Parse(dgvListItem.Rows[index].Cells[0].Value.ToString())));
                groupBox3.Enabled = false;
                Item.Id = int.Parse(dgvListItem.Rows[index].Cells[0].Value.ToString());
                lstItemDTO.Add(Item);
            }
            else
            {
                groupBox3.Enabled = false;
                _ItemBusiness = new ItemBusiness();
                int index = dgvListItem.CurrentCell.RowIndex;
                for (int i = 0; i < lbSelectItem.Items.Count; i++)
                {
                    if (lbSelectItem.Items[i].Equals(_ItemBusiness.SelectNameItem(int.Parse(dgvListItem.Rows[index].Cells[0].Value.ToString()))))
                    {
                        MessageBox.Show("Sản phẩm này đã được thêm vào danh sách sản phẩm được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                lbSelectItem.Items.Add(_ItemBusiness.SelectNameItem(int.Parse(dgvListItem.Rows[index].Cells[0].Value.ToString())));
                groupBox3.Enabled = false;
                Item.Id = int.Parse(dgvListItem.Rows[index].Cells[0].Value.ToString());
                lstItemDTO.Add(Item);
            }
           
        }
        #endregion


        #region Xóa sản phẩm trong listbox
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = lbSelectItem.SelectedIndex;
            if (index > -1)
            {
                lbSelectItem.Items.RemoveAt(index);
            }
            if (lbSelectItem.Items.Count == 0)
            {
                groupBox3.Enabled = true;
            }
        }
        #endregion

        #region Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        #endregion

        #region Lưu
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
