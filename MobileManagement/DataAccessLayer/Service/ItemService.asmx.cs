using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataAccessLayer.Entitty;
using DataAccessLayer.DTO;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Service
{
    /// <summary>
    /// Summary description for ItemService
    /// </summary>
    [WebService(Namespace = "http://ItemService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ItemService : System.Web.Services.WebService
    {

        public ItemService() { }
        private MobileEntities db;

        [WebMethod]
        public List<ItemDTO> GetListItem()
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.ItemDTOList(db.ITEMs.ToList());
            }
        }

        //lấy list Mã Item khi co mã danh mục
        [WebMethod]
        public List<ItemDTO> GetListItemWhenCategoryId(int _pCategoryId)
        {
            using (db = new MobileEntities())
            {
                List<ItemDTO> lstItemDTO = new List<ItemDTO>();
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Id == _pCategoryId);
                if (category == null)
                {
                    return null;
                }
                else
                    foreach (var item in category.ITEMs)
                    {
                        ItemDTO itemDTO = new ItemDTO();
                        itemDTO.Id = item.Id;
                        lstItemDTO.Add(itemDTO);
                    }
                return lstItemDTO;
            }
        }

        [WebMethod]
        public bool AddItem(ItemDTO pItemDTO)
        {
            using (db = new MobileEntities())
            {
                ITEM item = DALUtilitiesMethod.ToItem(pItemDTO);
                try
                {
                    db.ITEMs.Add(item);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        [WebMethod]
        public bool ExisItemName(string pItemName, int pItemID)
        {
            using (db = new MobileEntities())
            {
                var n = db.ITEMs.SingleOrDefault(p => p.Name.Equals(pItemName) && p.Id != pItemID);
                if (n != null)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        [WebMethod]
        public bool EditItem(ItemDTO pItemDTO)
        {
            using (db = new MobileEntities())
            {
                ITEM item = db.ITEMs.SingleOrDefault(n => n.Id == pItemDTO.Id);
                if (item == null)
                {
                    return false;
                }
                try
                {
                    item.Id = pItemDTO.Id;
                    item.Name = pItemDTO.Name;
                    item.Ram = pItemDTO.Ram;
                    item.Pin = pItemDTO.Pin;
                    item.Camera = pItemDTO.Camera;
                    item.Cpu = pItemDTO.Cpu;
                    item.Price = pItemDTO.Price;
                    item.Image = pItemDTO.Image;
                    item.Quantity = pItemDTO.Quantity;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #region Lấy Tên Hình
        [WebMethod]
        public string SelectPictureName(int pIdItem)
        {
            using (db = new MobileEntities())
            {
                ITEM item = db.ITEMs.SingleOrDefault(n => n.Id == pIdItem);
                if (item != null)
                {
                    return item.Image;
                }
                return "";
            }
        }
        #endregion



        [WebMethod]
        public bool DeleteItem(int pItemID)
        {
            using (db = new MobileEntities())
            {
                ITEM item = db.ITEMs.SingleOrDefault(n => n.Id == pItemID);

                try
                {
                    item.CATEGORies.Clear();
                    item.SUBCATEGORies.Clear();
                    db.ITEMs.Remove(item);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        [WebMethod]
        public string SelectNameItem(int pItemID)
        {
            using (db = new MobileEntities())
            {
                ITEM item = db.ITEMs.SingleOrDefault(n => n.Id == pItemID);
                if (item != null)
                {
                    return item.Name;
                }
                else
                {
                    return "";
                }
            }
        }

        //lấy list Mã Item khi co mã danh mục
        [WebMethod]
        public List<ItemDTO> GetListItemWhenSubCategoryId(int _pSubCategoryId)
        {
            using (db = new MobileEntities())
            {
                List<ItemDTO> lstItemDTO = new List<ItemDTO>();
                SUBCATEGORY subCategory = db.SUBCATEGORies.SingleOrDefault(n => n.Id == _pSubCategoryId);
                if (subCategory == null)
                {
                    return null;
                }
                else
                    foreach (var item in subCategory.ITEMs)
                    {
                        ItemDTO itemDTO = new ItemDTO();
                        itemDTO.Id = item.Id;
                        lstItemDTO.Add(itemDTO);
                    }
                return lstItemDTO;
            }
        }

        //lấy list Mã Item khi co mã danh mục
        [WebMethod]
        public List<ItemDTO> GetListItemNoRelationItemCategory(int _pCategoryId)
        {
            using (db = new MobileEntities())
            {
                List<ITEM> _lstItem = new List<ITEM>();
                List<ItemDTO> lstItemDTO = new List<ItemDTO>();
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Id == _pCategoryId);
                if (category == null)
                {
                    return null;
                }
                else
                {
                    if (category.ITEMs.Count == 0)
                    {
                        _lstItem = db.ITEMs.ToList();
                    }
                    else
                    {
                        foreach (var item in category.ITEMs)
                        {
                            _lstItem = db.ITEMs.Where(n => n.Id != item.Id).ToList();
                            //for (int i = 0; i < _lstItem.Count; i++)
                            //{
                            //    if (_lstItem[i].Id == item.Id)
                            //    {
                            //        ListItem.Add(_lstItem[i]);
                            //    }


                            //}
                        }
                    }
                    foreach (var k in _lstItem)
                    {
                        ItemDTO itemDTO = new ItemDTO();
                        itemDTO.Id = k.Id;
                        lstItemDTO.Add(itemDTO);
                    }
                    return lstItemDTO;
                }

            }
        }
    }
}
