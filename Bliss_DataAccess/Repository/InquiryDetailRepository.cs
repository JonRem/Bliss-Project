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
    public class InquiryDetailRepository : Repository<InquiryDetail>, IInquiryDetailRepository
    {
        private readonly ApplicationDbContext _db;
        public InquiryDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }      

        public void Update(InquiryDetail obj)
        {
            //var objFromDb = _db.Category.FirstOrDefault(u => u.Id == obj.Id);
            // if individual properties only ned to be updated then use previous method in CategoryRepository as an example
            _db.InquiryDetail.Update(obj);
        }
    }
}
