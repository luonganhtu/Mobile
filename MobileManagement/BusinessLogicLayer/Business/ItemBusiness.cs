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

        //lay danh sach ma san pham
        public List<ItemDTO> GetListItemWhenCategoryId(int _pCategoryId)
        {
            return service.GetListItemWhenCategoryId(_pCategoryId).ToList();
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
    }
}
