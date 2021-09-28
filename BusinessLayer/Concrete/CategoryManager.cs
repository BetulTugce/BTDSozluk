using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        //SİLİNECEK BU KISIM
        //GenericRepository<Category> repo = new GenericRepository<Category>();
        //public List<Category> GetAll()
        //{
        //    return repo.List();
        //}
        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryName.Length>=51 || p.CategoryDescription=="")
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
        public List<Category> GetList()
        {
            return _categorydal.List();
        }
    }
}
