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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }      

        public void Update(OrderHeader obj)
        {
            //var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            // if individual properties only ned to be updated then use previous method in CategoryRepository as an example
            _db.OrderHeader.Update(obj);
        }
    }
}
