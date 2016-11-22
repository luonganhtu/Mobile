using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.ItemLocalhost;

namespace BusinessLogicLayer.Business
{
    public class ItemBusiness
    {
        private ItemService service;

        public ItemBusiness()
        {
            service = new ItemService();
        }

        //Lấy danhs sách
        public List<ItemDTO> GetItemList()
        {
            return service.GetListItem().OrderBy(n => n.Id).ToList();
        }

        //lay danh sach ma san pham khi có id category
        public List<ItemDTO> GetListItemWhenCategoryId(int _pCategoryId)
        {
            return service.GetListItemWhenCategoryId(_pCategoryId).ToList();
        }

        //lay danh sach ma san pham khi có id subcategory
        public List<ItemDTO> GetListItemWhenSubCategoryId(int _pSubCategoryId)
        {
            return service.GetListItemWhenSubCategoryId(_pSubCategoryId).ToList();
        }



        // Thêm
        public bool AddItem(ItemDTO pItemDTO)
        {
            return service.AddItem(pItemDTO);
        }

        //Sửa
        public bool EditItem(ItemDTO pItemDTO)
        {
            return service.EditItem(pItemDTO);
        }

        //Kiểm tra trùng tên
        public bool ExisItemName(string pItemName, int pItemID)
        {
            return service.ExisItemName(pItemName, pItemID);
        }

        //Lấy tên hình
        public string SelectPictureName(int pIdItem)
        {
            return service.SelectPictureName(pIdItem);
        }

        public bool DeleteItem(int pItemID)
        {
            return service.DeleteItem(pItemID);
        }

        public string SelectNameItem(int pItemID)
        {
            return service.SelectNameItem(pItemID);
        }

        //Lấy mã sản phẩm mà không thuộc danh mục được chọn
        public List<ItemDTO> GetListItemNoRelationItemCategory(int _pCategoryId)
        {
            return service.GetListItemNoRelationItemCategory(_pCategoryId).ToList();
        }


    }
}
