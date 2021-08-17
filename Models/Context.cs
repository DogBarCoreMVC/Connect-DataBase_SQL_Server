using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Server_EFCore.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        DbSet<GroupMenu> groupMenus_tbl { get; set; }
    }
}
