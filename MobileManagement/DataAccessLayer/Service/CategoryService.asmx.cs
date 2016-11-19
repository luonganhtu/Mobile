using DataAccessLayer.Entitty;
using DataAccessLayer.DTO;
using DataAccessLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DataAccessLayer
{
    /// <summary>
    /// Summary description for CategoryService
    /// </summary>
    [WebService(Namespace = "http://CategoryService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CategoryService : System.Web.Services.WebService
    {
        public CategoryService() { }

        private MobileEntities db;

        [WebMethod]
        public List<CategoryDTO> GetListCategory()
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.CategoryDTOList(db.CATEGORies.ToList());
            }
        }

        [WebMethod]
        public bool AddCategory(CategoryDTO pCategoryDTO)
        {
            using (db = new MobileEntities())
            {
                CATEGORY category = DALUtilitiesMethod.ToCategory(pCategoryDTO);
                try
                {
                    db.CATEGORies.Add(category);
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
        public bool ExisCattName(string pCatName, int pCatID)
        {
            using (db = new MobileEntities())
            {
                var n = db.CATEGORies.SingleOrDefault(p => p.Name.Equals(pCatName) && p.Id != pCatID);
                if (n != null)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        [WebMethod]
        public bool EditCategory(CategoryDTO pCategoryDTO)
        {
            using (db = new MobileEntities())
            {
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Id == pCategoryDTO.Id);
                if (category == null)
                {
                    return false;
                }
                try
                {
                    category.Name = pCategoryDTO.Name;
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
        public bool CanDeleteCategory(int pCatID)
        {
            using (db = new MobileEntities())
            {
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Id == pCatID);
                List<SUBCATEGORY> sub = db.SUBCATEGORies.Where(m => m.CategoryId == category.Id).ToList();
                // Nếu tồn tại sách thuộc category thì không thể xóa
                if (category.ITEMs.Count > 0)
                {
                    return false;
                }
                else if (sub.Count > 0)
                {
                    return false;
                }
                return true;
            }
        }

        [WebMethod]
        public bool DeleteCategory(int pCategoryID)
        {
            using (db = new MobileEntities())
            {
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Id == pCategoryID);
                try
                {
                    db.CATEGORies.Remove(category);
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
        public string SelectNameCategory(int pCategoryID)
        {
            using (db = new MobileEntities())
            {
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Id == pCategoryID);
                if (category != null)
                {
                    return category.Name;
                }
                else
                {
                    return "";
                }
            }
        }

        [WebMethod]
        public int SelectIdCategory(string pCategoryName)
        {
            using (db = new MobileEntities())
            {
                CATEGORY category = db.CATEGORies.SingleOrDefault(n => n.Name == pCategoryName);
                if (category != null)
                {
                    return category.Id;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
