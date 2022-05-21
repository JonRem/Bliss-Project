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
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }      

        public void Update(OrderDetail obj)
        {
            //var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            // if individual properties only ned to be updated then use previous method in CategoryRepository as an example
            _db.OrderDetail.Update(obj);
        }
    }
}
