using DataAccessLayer.Entitty;
using DataAccessLayer.DTO;
using DataAccessLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DataAccessLayer.Service
{
    /// <summary>
    /// Summary description for SubCategoryService
    /// </summary>
    [WebService(Namespace = "http://SubCategoryService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SubCategoryService : System.Web.Services.WebService
    {

        public SubCategoryService() { }

        private MobileEntities db;

        [WebMethod]
        public List<SubCategoryDTO> GetListSubCategory()
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.SubCategoryDTOList(db.SUBCATEGORies.ToList());
            }
        }

        [WebMethod]
        public List<SubCategoryDTO> GetListSubCategoryWhenIdCategory(int _pIdCategory)
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.SubCategoryDTOList(db.SUBCATEGORies.Where(n=>n.CategoryId == _pIdCategory).ToList());
            }
        }

        //[WebMethod]
        //public List<ITEM> GetListItemWhenSubCategoryId(int _pSubCategoryId)
        //{
        //    using (db = new MobileEntities())
        //    {
        //        SUBCATEGORY subCategory = db.SUBCATEGORies.SingleOrDefault(n => n.Id == _pSubCategoryId);
        //        if (subCategory == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            return subCategory.ITEMs.ToList();
        //        }
        //    }
        //}

        [WebMethod]
        public bool AddSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            using (db = new MobileEntities())
            {
                SUBCATEGORY subCategory = DALUtilitiesMethod.ToSubCategory(pSubCategoryDTO);
                try
                {
                    db.SUBCATEGORies.Add(subCategory);
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
        public bool ExisSubName(string pSubName, int pSubID, int pCatId)
        {
            using (db = new MobileEntities())
            {
                var n = db.SUBCATEGORies.SingleOrDefault(p => p.Name.Equals(pSubName) && p.CategoryId == pCatId && p.Id != pSubID);
                if (n != null)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        [WebMethod]
        public bool EditSubCategory(SubCategoryDTO pSubCategoryDTO)
        {
            using (db = new MobileEntities())
            {
                SUBCATEGORY subCategory = db.SUBCATEGORies.SingleOrDefault(n => n.Id == pSubCategoryDTO.Id);
                if (subCategory == null)
                {
                    return false;
                }
                try
                {
                    subCategory.CategoryId = pSubCategoryDTO.CategoryId;
                    subCategory.Name = pSubCategoryDTO.Name;
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
        public bool CanDeleteSubCategory(int pSubCatID)
        {
            using (db = new MobileEntities())
            {
                SUBCATEGORY subCategory = db.SUBCATEGORies.SingleOrDefault(n => n.Id == pSubCatID);
                // Nếu tồn tại sách thuộc category thì không thể xóa
                if (subCategory.ITEMs.Count > 0)
                {
                    return false;
                }              
                return true;
            }
        }

        [WebMethod]
        public bool DeleteSubCategory(int pSubCategoryID)
        {
            using (db = new MobileEntities())
            {
                SUBCATEGORY subCategory = db.SUBCATEGORies.SingleOrDefault(n => n.Id == pSubCategoryID);
                try
                {
                    db.SUBCATEGORies.Remove(subCategory);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


    }
}
