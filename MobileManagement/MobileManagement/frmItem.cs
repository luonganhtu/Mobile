using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using BusinessLogicLayer.ItemLocalhost;
using BusinessLogicLayer.Utilities;
using BusinessLogicLayer;
using System.IO;
using BusinessLogicLayer.Business;
using System.Text.RegularExpressions;
using MobileManagement.SubForm;

namespace MobileManagement
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
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
                groupBox1.Enabled = false;
            }
            else if (dieukhien == ((int)DIEUKHIEN.MO))
            {
                panel1.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                groupBox1.Enabled = true;
            }
        }
        #endregion
        int g = 1;

        private int currentAction = (int)ACTION.NONE;
        private string _NewImage = "";
        private const string imagesFolder = @"..\..\hinh mobile\";
        ItemBusiness _ItemBusiness;
        private List<ItemDTO> _lstItemDTO;
        private ItemDTO _itemDTO;
        private void frmItem_Load(object sender, EventArgs e)
        {
            DieuKhien((int)DIEUKHIEN.MO);
            LoadData();
        }

        private void LoadData()
        {
            _ItemBusiness = new ItemBusiness();
            currentAction = (int)ACTION.LOADING;
            _lstItemDTO = _ItemBusiness.GetItemList();
            dgvListItem.Rows.Clear();
            for (int i = 0; i < _lstItemDTO.Count; i++)
            {
                int inDex = dgvListItem.Rows.Add();
                dgvListItem.Rows[inDex].Cells[0].Value = _lstItemDTO[i].Id;
                dgvListItem.Rows[inDex].Cells[1].Value = _lstItemDTO[i].Name;
                dgvListItem.Rows[inDex].Cells[2].Value = _lstItemDTO[i].Camera;
                dgvListItem.Rows[inDex].Cells[3].Value = _lstItemDTO[i].Cpu;
                dgvListItem.Rows[inDex].Cells[4].Value = _lstItemDTO[i].Ram;
                dgvListItem.Rows[inDex].Cells[5].Value = _lstItemDTO[i].Pin;
                dgvListItem.Rows[inDex].Cells[6].Value = _lstItemDTO[i].Price;
                dgvListItem.Rows[inDex].Cells[7].Value = _lstItemDTO[i].Quantity;
            }
            currentAction = (int)ACTION.NONE;
            if (_lstItemDTO.Count > 0)
            {
                dgvListItem.Rows[0].Selected = true;
            }
        }


        private void dgvListItem_SelectionChanged(object sender, EventArgs e)
        {
            if (currentAction == (int)ACTION.NONE)
            {
                var index = dgvListItem.CurrentCell.RowIndex;
                if (index > -1)
                {
                    txtTen.Text = dgvListItem.Rows[index].Cells[1].Value.ToString().Trim();
                    txtCamera.Text = dgvListItem.Rows[index].Cells[2].Value.ToString().Trim();
                    txtCpu.Text = dgvListItem.Rows[index].Cells[3].Value.ToString().Trim();
                    txtRam.Text = dgvListItem.Rows[index].Cells[4].Value.ToString().Trim();
                    txtPin.Text = dgvListItem.Rows[index].Cells[5].Value.ToString().Trim();
                    txtDonGia.Text = string.Format("{0:0,0}", _lstItemDTO[index].Price);
                    txtSoLuong.Text = dgvListItem.Rows[index].Cells[7].Value.ToString().Trim();
                    var c = _ItemBusiness.SelectPictureName(_lstItemDTO[index].Id);
                    HienThiHinhAnh(c.ToString());
                }
            }
        }

        private void HienThiHinhAnh(string HinhAnh)
        {
            if (HinhAnh == "")
            {

                pbHinhAnh.BackgroundImage = Properties.Resources.no_image;
            }
            else
            {
                string file = imagesFolder + "" + HinhAnh;
                if (File.Exists(file))
                {
                    using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        pbHinhAnh.BackgroundImage = Image.FromStream(stream);
                        stream.Dispose();
                    }
                }
                else
                {
                    pbHinhAnh.BackgroundImage = Properties.Resources.no_image;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            g = 1;
            DieuKhien((int)DIEUKHIEN.DONG);
            txtTen.Text = "";
            txtRam.Text = "";
            txtCpu.Text = "";
            txtCamera.Text = "";
            txtPin.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            pbHinhAnh.BackgroundImage = Properties.Resources.no_image;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            g = 2;
            DieuKhien((int)DIEUKHIEN.DONG);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            g = 0;
            DieuKhien((int)DIEUKHIEN.MO);
            LoadData();
        }

        #region Thay đổi hình
        private void btnThayDoiHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh";
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg;*gif)|*.png;*jpg;*.jpeg;*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbHinhAnh.BackgroundImage = null;
                if (g == 1)
                {
                    _itemDTO = new ItemDTO();
                    _itemDTO.Image = ofd.FileName;
                    using (FileStream stream = new FileStream(_itemDTO.Image, FileMode.Open, FileAccess.Read))
                    {
                        pbHinhAnh.BackgroundImage = Image.FromStream(stream);
                        stream.Dispose();
                    }
                }
                if (g == 2)
                {
                    _NewImage = ofd.FileName;
                    pbHinhAnh.BackgroundImage = Image.FromFile(_NewImage);
                    using (FileStream stream = new FileStream(_NewImage, FileMode.Open, FileAccess.Read))
                    {
                        pbHinhAnh.BackgroundImage = Image.FromStream(stream);
                        stream.Dispose();
                    }
                }
            }
        }
        #endregion

        #region Xóa hình
        private void btnXoaHinh_Click(object sender, EventArgs e)
        {
            if (g == 1)
            {
                _itemDTO.Image = "";
            }
            if (g == 2)
            {
                _NewImage = "";
            }
            pbHinhAnh.BackgroundImage = Properties.Resources.no_image;
        }
        #endregion

        #region Xử lý lưu hình ảnh
        #region Tạo tên file ảnh mới
        private string TaoTenFileAnhMoi(string itemName, string orgHinhAnh)
        {
            if (orgHinhAnh != "")
            {
                string extension = System.IO.Path.GetExtension(orgHinhAnh);
                return ConvertToUnSign(itemName) + "" + extension;
            }
            return "";
        }
        #endregion
        #endregion

        #region ConvertToUnSign
        /// <summary>
        /// Chuyển chỗi thành chuỗi không dấu, không khoảng trắng
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ConvertToUnSign(string text)
        {
            Random rand = new Random(1000000);
            for (int i = 33; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 58; i < 65; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }

            for (int i = 91; i < 97; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            for (int i = 123; i < 127; i++)
            {
                text = text.Replace(((char)i).ToString(), "");
            }
            text = text.Replace(" ", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return (regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D') + "-" + rand.Next().ToString());
        }
        #endregion

        #region Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var index = dgvListItem.CurrentCell.RowIndex;
            bool kiemTra = false;
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCamera.Text == "")
            {
                MessageBox.Show("Camera không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCpu.Text == "")
            {
                MessageBox.Show("Cpu không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtRam.Text == "")
            {
                MessageBox.Show("Ram không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPin.Text == "")
            {
                MessageBox.Show("Pin không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtDonGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được trống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region Lưu khi thêm
            else if (g == 1)
            {
                kiemTra = _ItemBusiness.ExisItemName(txtTen.Text.ToString(), -1);
                if (kiemTra == false)
                {
                    MessageBox.Show("Trùng Tên Sản Phẩm! Vui Lòng Chọn Tên Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    _itemDTO = new ItemDTO();
                    _itemDTO.Name = txtTen.Text.ToString().Trim();
                    _itemDTO.Camera = txtCamera.Text.ToString().Trim();
                    _itemDTO.Ram = txtRam.Text.ToString().Trim();
                    _itemDTO.Cpu = txtCpu.Text.ToString().Trim();
                    _itemDTO.Pin = txtPin.Text.ToString().Trim();
                    _itemDTO.Price = double.Parse(txtDonGia.Text.ToString().Trim());
                    _itemDTO.Quantity = int.Parse(txtSoLuong.Text.ToString().Trim());
                    string oldFileName = "", newFileName = "";
                    oldFileName = _itemDTO.Image;
                    newFileName = TaoTenFileAnhMoi(_itemDTO.Name, _itemDTO.Image);
                    _itemDTO.Image = newFileName;

                    if (_ItemBusiness.AddItem(_itemDTO))
                    {
                        if (oldFileName != null)
                        {
                            File.Copy(oldFileName, imagesFolder + "" + newFileName);
                        }
                        MessageBox.Show("Thêm sản phẩm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm mới không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            #endregion

            else if (g == 2)
            {
                kiemTra = _ItemBusiness.ExisItemName(txtTen.Text.ToString(), int.Parse(dgvListItem.Rows[index].Cells[0].Value.ToString()));
                if (kiemTra == false)
                {
                    MessageBox.Show("Trùng Tên Sản Phẩm! Vui Lòng Chọn Tên Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    _itemDTO = _lstItemDTO.ElementAtOrDefault(index);
                    _itemDTO.Name = txtTen.Text.ToString().Trim();
                    _itemDTO.Camera = txtCamera.Text.ToString().Trim();
                    _itemDTO.Ram = txtRam.Text.ToString().Trim();
                    _itemDTO.Cpu = txtCpu.Text.ToString().Trim();
                    _itemDTO.Pin = txtPin.Text.ToString().Trim();
                    _itemDTO.Price = double.Parse(txtDonGia.Text.ToString().Trim());
                    _itemDTO.Quantity = int.Parse(txtSoLuong.Text.ToString().Trim());
                    string oldFileName = "", newFileName = "";
                    if (_itemDTO.Image != null)
                    {
                        oldFileName = _itemDTO.Image.Trim();
                    }
                    if (_NewImage != "")
                    {
                        newFileName = TaoTenFileAnhMoi(_itemDTO.Name, _NewImage);
                        _itemDTO.Image = newFileName;
                    }
                    if (_ItemBusiness.EditItem(_itemDTO))
                    {
                        if (_NewImage != "")
                        {
                            if (oldFileName != "")
                            {
                                File.Delete(imagesFolder + "" + oldFileName);
                            }
                            File.Copy(_NewImage, imagesFolder + "" + _itemDTO.Image);
                        }
                        if (_NewImage == "")
                        {
                            if (oldFileName != "")
                            {
                                File.Delete(imagesFolder + "" + oldFileName);
                            }
                        }
                        MessageBox.Show("Sửa thông tin nhóm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        LoadData();
                    }
                }
            }
            DieuKhien((int)DIEUKHIEN.MO);
            g = 0;
        }
        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            else
            {
                _ItemBusiness = new ItemBusiness();
                var index = dgvListItem.CurrentCell.RowIndex;
                
                    if (_ItemBusiness.DeleteItem(_lstItemDTO[index].Id))
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmItem_Category frm = new frmItem_Category();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
