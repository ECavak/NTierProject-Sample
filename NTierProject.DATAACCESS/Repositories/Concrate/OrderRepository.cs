using NTierProject.DATAACCESS.Repositories.Context;
using NTierProject.ENTITIES.Entities;
using NTierProject.CORE.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NTierProject.DATAACCESS.Repositories.Concrate
{
    public class OrderRepository : Repository<Order>
    {
        private readonly ProjectContext _context;
        public OrderRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }

        public List<Order> ListPendingOrders()
        {
            return GetDefault(x => x.Status == Status.Active && x.Confirmed == false).OrderByDescending(x => x.CreatedDate).ToList();
        }
        public int PendingOrdersCount()
        {
            //return GetByDefault(x => x.Status == Status.Active && x.Confirmed == false).OrderByDescending(x => x.CreatedDate).ToList();
            return ListPendingOrders().Count;
        }
    }
}
