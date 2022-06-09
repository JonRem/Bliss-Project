using Microsoft.AspNetCore.Mvc.Rendering;
using Bliss_DataAccess.Repository.IRepository;
using Bliss_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bliss_Models;

namespace Bliss_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private List<Product> ProductList { get; set; }

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public IEnumerable<SelectListItem> GetAllDropdownList(string obj)
        {
            if(obj==WC.CategoryName)
            {
                return _db.Category.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }
            if (obj==WC.ApplicationTypeName)
            {
                return _db.ApplicationType.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }
            return null;
        }

        public IEnumerable<Product> Search(string searchProduct)
        {

            //ProductList = IEnumerable < Product > GetAll(includeProperties: "Category,ApplicationType");

            


            if (string.IsNullOrEmpty(searchProduct))
            {
                return ProductList;
            }

            return ProductList.Where(u => u.Name.Contains(searchProduct) ||
                    u.Name.Contains(searchProduct));
            
            // throw new NotImplementedException();
        }

        public void Update(Product obj)
        {
            // var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            // if individual properties only ned to be updated then use previous method in CategoryRepository as an example
            _db.Product.Update(obj);
        }
    }
}
