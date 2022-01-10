using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLot.Dal.Repos
{
    public class DriverRepo : BaseRepo<Driver>, IDriverRepo
    {
        public DriverRepo(ApplicationDbContext context) : base(context) { }
        internal DriverRepo(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        internal IOrderedQueryable<Driver> BuildQuery()
            => Table.OrderBy(m => m.PersonInformation.LastName).ThenBy(f => f.PersonInformation.FirstName);
        public override IEnumerable<Driver> GetAll() => BuildQuery();
        public override IEnumerable<Driver> GetAllIgnoreQueryFilters()
        => BuildQuery().IgnoreQueryFilters();
    }
}
