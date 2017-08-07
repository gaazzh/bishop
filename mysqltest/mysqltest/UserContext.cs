using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace mysqltest
{
    public class UserContext: DbContext
    {
        public UserContext() : base("defdb") { }

        public DbSet<User> Users { get; set; }
    }
}
