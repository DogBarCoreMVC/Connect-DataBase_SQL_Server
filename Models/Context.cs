using Microsoft.EntityFrameworkCore;//Add Packages
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Server_EFCore.Models
{
    public class Context : DbContext//Inherit DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {
            //สร้าง Constructor และใช้ความสามารถของ EFCore (DbContextOptions) ในการสร้าง Database
        }
        DbSet<GroupMenu> groupMenus_tbl { get; set; }//GroupMenu.cs เป็นคลาสที่เราสร้างไว้แต่จะกลายไปเป็น table ใน Database และ groupMenus_tbl คือชื่อ ของ Table
    }
}
