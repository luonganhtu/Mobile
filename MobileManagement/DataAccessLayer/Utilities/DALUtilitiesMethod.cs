using DataAccessLayer.DTO;
using DataAccessLayer.Entitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.Utilities
{
    public class DALUtilitiesMethod
    {
        #region Category
        //Chuyển danh sách đối tượng Data sang danh sách đối tượng Business
        public static List<CategoryDTO> CategoryDTOList(List<CATEGORY> CategoryList)
        {
            List<CategoryDTO> categoryDTOList = new List<CategoryDTO>();
            foreach (CATEGORY item in CategoryList)
            {
                CategoryDTO categoryDTO = ToCategoryDTO(item);
                categoryDTOList.Add(categoryDTO);
            }
            return categoryDTOList;
        }

      

        #region Chuyển đổi đối tượng DTO sang Data
        public static CATEGORY ToCategory(CategoryDTO pCategoryDTO)
        {
            CATEGORY category = new CATEGORY();
            category.Id = pCategoryDTO.Id;
            category.Name = pCategoryDTO.Name;
            return category;
        }
        #endregion

        #region Chuyển đổi đối tượng Data sang DTO
        public static CategoryDTO ToCategoryDTO(CATEGORY pCategory)
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.Id = pCategory.Id;
            categoryDTO.Name = pCategory.Name;
            return categoryDTO;
        }
        #endregion
        #endregion

        #region SubCategory
        //Chuyển danh sách đối tượng Data sang danh sách đối tượng Business
        public static List<SubCategoryDTO> SubCategoryDTOList(List<SUBCATEGORY> SubCategoryList)
        {
            List<SubCategoryDTO> subCategoryDTOList = new List<SubCategoryDTO>();
            foreach (SUBCATEGORY item in SubCategoryList)
            {
                SubCategoryDTO subCategoryDTO = ToSubCategoryDTO(item);
                subCategoryDTOList.Add(subCategoryDTO);
            }
            return subCategoryDTOList;
        }

 

        #region Chuyển đổi đối tượng DTO sang Data
        public static SUBCATEGORY ToSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            SUBCATEGORY subCategory = new SUBCATEGORY();
            subCategory.Id = pSubCategoryDTO.Id;
            subCategory.CategoryId = pSubCategoryDTO.CategoryId;
            subCategory.Name = pSubCategoryDTO.Name;
            return subCategory;
        }
        #endregion

        #region Chuyển đổi đối tượng Data sang DTO
        public static SubCategoryDTO ToSubCategoryDTO(SUBCATEGORY pSubCategory)
        {
            SubCategoryDTO subCategoryDTO = new SubCategoryDTO();
            subCategoryDTO.Id = pSubCategory.Id;
            subCategoryDTO.CategoryId = (int)pSubCategory.CategoryId;
            subCategoryDTO.Name = pSubCategory.Name;
            return subCategoryDTO;
        }
        #endregion
        #endregion

        #region Item
        //Chuyển danh sách đối tượng Data sang danh sách đối tượng Business
        public static List<ItemDTO> ItemDTOList(List<ITEM> ItemList)
        {
            List<ItemDTO> ItemDTOList = new List<ItemDTO>();
            foreach (ITEM item in ItemList)
            {
                ItemDTO itemDTO = ToItemDTO(item);
                ItemDTOList.Add(itemDTO);
            }
            return ItemDTOList;
        }

   

        #region Chuyển đổi đối tượng DTO sang Data
        public static ITEM ToItem(ItemDTO pItemDTO)
        {
            ITEM item = new ITEM();
            item.Id = pItemDTO.Id;
            item.Name = pItemDTO.Name;
            item.Ram = pItemDTO.Ram;
            item.Pin = pItemDTO.Pin;
            item.Camera = pItemDTO.Camera;
            item.Cpu = pItemDTO.Cpu;
            item.Price = pItemDTO.Price;
            item.Image = pItemDTO.Image;
            item.Quantity = pItemDTO.Quantity;
            return item;
        }
        #endregion

        #region Chuyển đổi đối tượng Data sang DTO
        public static ItemDTO ToItemDTO(ITEM pItem)
        {
            ItemDTO itemDTO = new ItemDTO();
            itemDTO.Id = pItem.Id;
            itemDTO.Name = pItem.Name;
            itemDTO.Ram = pItem.Ram;
            itemDTO.Pin = pItem.Pin;
            itemDTO.Camera = pItem.Camera;
            itemDTO.Cpu = pItem.Cpu;
            itemDTO.Price = (double)pItem.Price;
            itemDTO.Image = pItem.Image;
            itemDTO.Quantity = (int)pItem.Quantity;
            return itemDTO;
        }
        #endregion
        #endregion

        #region User
        //Chuyển danh sách đối tượng Data sang danh sách đối tượng Business
        public static List<UserDTO> UserDTOList(List<USER> UserList)
        {            
            List<UserDTO> UserDTOList = new List<UserDTO>();
            foreach (USER item in UserList)
            {
                UserDTO userDTO = ToUserDTO(item);
                UserDTOList.Add(userDTO);
            }
            return UserDTOList;
        }

        #region Chuyển đổi đối tượng DTO sang Data
        public static USER ToUser(UserDTO pUserDTO)
        {
            USER user = new USER();
            user.Id = pUserDTO.Id;
            user.AccountId = pUserDTO.AccountId;
            user.FullName = pUserDTO.FullName;
            user.Address = pUserDTO.Address;
            user.PhoneNumber = pUserDTO.PhoneNumber;
            return user;
        }
        #endregion

        #region Chuyển đổi đối tượng Data sang DTO
        public static UserDTO ToUserDTO(USER pUser)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Id = pUser.Id;
            userDTO.AccountId = (int)pUser.AccountId;
            userDTO.FullName = pUser.FullName;
            userDTO.Address = pUser.Address;
            userDTO.PhoneNumber = pUser.PhoneNumber;
            return userDTO;
        }
        #endregion
        #endregion

        #region Account
        //Chuyển danh sách đối tượng Data sang danh sách đối tượng Business
        public static List<AccountDTO> AccountDTOList(List<ACCOUNT> AccountList)
        {
            List<AccountDTO> AccountDTOList = new List<AccountDTO>();
            foreach (ACCOUNT item in AccountList)
            {
                AccountDTO accountDTO = ToAccountDTO(item);
                AccountDTOList.Add(accountDTO);
            }
            return AccountDTOList;
        }

        #region Chuyển đổi đối tượng DTO sang Data
        public static ACCOUNT ToAccount(AccountDTO pAccountDTO)
        {
            ACCOUNT account = new ACCOUNT();
            account.Id = pAccountDTO.Id;
            account.AccountName = pAccountDTO.AccountName;
            account.Password = pAccountDTO.Password;
            account.Level = pAccountDTO.Level;           
            return account;
        }
        #endregion

        #region Chuyển đổi đối tượng Data sang DTO
        public static AccountDTO ToAccountDTO(ACCOUNT pAccount)
        {
            AccountDTO accountDTO = new AccountDTO();
            accountDTO.Id = pAccount.Id;
            accountDTO.AccountName = pAccount.AccountName;
            accountDTO.Password = pAccount.Password;
            accountDTO.Level = (byte)pAccount.Level;
            return accountDTO;
        }
        #endregion
        #endregion

        #region [ Order ] - [ Order Detail ]

        /// <summary>
        /// Chuyển danh sách đối tượng Dữ liệu sang danh sách đối tượng Business
        /// </summary>
        /// <param name="pOrderList"></param>
        /// <returns></returns>
        public static List<OrderDTO> ToOrderDTOList(List<ORDER> pOrderList)
        {
            List<OrderDTO> orderDTOList = new List<OrderDTO>();
            foreach (ORDER item in pOrderList)
            {
                OrderDTO orderDTO = ToOrderDTO(item);
                orderDTOList.Add(orderDTO);
            }

            return orderDTOList;
        }

        /// <summary>
        /// Chuyển đối tượng Dữ liệu sang đối tượng DTO
        /// </summary>
        /// <param name="pOrder"></param>
        /// <returns></returns>
        public static OrderDTO ToOrderDTO(ORDER pOrder)
        {
            OrderDTO orderDTO = new OrderDTO();
            orderDTO.Id = pOrder.Id;
            orderDTO.UserId = (int)pOrder.UserId;
            orderDTO.PurchaseDate = (DateTime)pOrder.PurchaseDate;
            return orderDTO;
        }

        /// <summary>
        /// Chuyển đối tượng DTO sang đối tượng dữ liệu
        /// </summary>
        /// <param name="pOrderDTO"></param>
        /// <returns></returns>
        public static ORDER ToOrder(OrderDTO pOrderDTO)
        {
            ORDER order = new ORDER();

            order.Id = pOrderDTO.Id;
            order.UserId = pOrderDTO.UserId;
            order.PurchaseDate = pOrderDTO.PurchaseDate;
            return order;
        }

        /// <summary>
        /// Chuyển danh sách đối tượng Dữ liệu sang đối tượng DTO
        /// </summary>
        /// <param name="pOrderDetailList"></param>
        /// <returns></returns>
        public static List<OrderDetailDTO> ToOrderDetailDTOList(List<ORDER_DETAIL> pOrderDetailList)
        {
            List<OrderDetailDTO> orderDetailDTOList = new List<OrderDetailDTO>();
            foreach (ORDER_DETAIL item in pOrderDetailList)
            {
                OrderDetailDTO orderDetailDTO = ToOrderDetailDTO(item);
                orderDetailDTOList.Add(orderDetailDTO);
            }

            return orderDetailDTOList;
        }

        /// <summary>
        /// Chuyển đối tượng Dữ liệu sang đối tượng DTO
        /// </summary>
        /// <param name="pOrderDetail"></param>
        /// <returns></returns>
        public static OrderDetailDTO ToOrderDetailDTO(ORDER_DETAIL pOrderDetail)
        {
            OrderDetailDTO orderDetailDTO = new OrderDetailDTO();
            orderDetailDTO.OrderId = pOrderDetail.OrderId;
            orderDetailDTO.ItemId = pOrderDetail.ItemId;
            orderDetailDTO.Quantity = (int)pOrderDetail.Quantity;
            orderDetailDTO.PriceOrder = (double)pOrderDetail.PriceOrder;
            return orderDetailDTO;
        }

        /// <summary>
        /// Chuyển đối tượng DTO sang đối tượng Dữ liệu
        /// </summary>
        /// <param name="pOrderDetailsDTO"></param>
        /// <returns></returns>
        public static ORDER_DETAIL ToOrderDetail(OrderDetailDTO pOrderDetailDTO)
        {
            ORDER_DETAIL orderDetail = new ORDER_DETAIL();
            orderDetail.OrderId = pOrderDetailDTO.OrderId;
            orderDetail.ItemId = pOrderDetailDTO.ItemId;
            orderDetail.Quantity = pOrderDetailDTO.Quantity;
            orderDetail.PriceOrder = pOrderDetailDTO.PriceOrder;
            return orderDetail;
        }

        #endregion



    }
}