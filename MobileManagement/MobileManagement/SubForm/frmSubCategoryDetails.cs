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
using BusinessLogicLayer;
using BusinessLogicLayer.Business;

namespace MobileManagement.SubForm
{
    public partial class frmSubCategoryDetails : Form
    {
        public frmSubCategoryDetails()
        {
            InitializeComponent();
        }
        int subCategoryId;
        public frmSubCategoryDetails(int subCategoryId)
        {
            InitializeComponent();
            this.subCategoryId = subCategoryId;
        }

        private enum ACTION : int
        {
            LOADING = 1,
            NONE = 0
        }
        private int currentAction = (int)ACTION.NONE;
        ItemBusiness _ItemBusiness;
        private List<ItemDTO> _lstItemDTO = new List<ItemDTO>();
        private void frmSubCategoryDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            currentAction = (int)ACTION.LOADING;
            _ItemBusiness = new ItemBusiness();
            _lstItemDTO = _ItemBusiness.GetListItemWhenSubCategoryId(subCategoryId);
            dgvSubCategoryDetails.Rows.Clear();
            for (int i = 0; i < _lstItemDTO.Count; i++)
            {
                var d = dgvSubCategoryDetails.Rows.Add();
                dgvSubCategoryDetails.Rows[d].Cells[0].Value = _lstItemDTO[i].Id;
                dgvSubCategoryDetails.Rows[d].Cells[1].Value = _ItemBusiness.SelectNameItem(_lstItemDTO[i].Id);
            }
        }
    }
}
