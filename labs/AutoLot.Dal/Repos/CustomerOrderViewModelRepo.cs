using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.Dal.Repos
{
    public class CustomerOrderViewModelRepo
    : BaseViewRepo<CustomerOrderViewModel>, ICustomerOrderViewModelRepo
    {
        public CustomerOrderViewModelRepo(ApplicationDbContext context) : base(context) { }
        internal CustomerOrderViewModelRepo(DbContextOptions<ApplicationDbContext> options) :
        base(options)
        { }
    }
}
