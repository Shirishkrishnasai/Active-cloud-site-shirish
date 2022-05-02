using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Active_cloud_site_5.Models;

namespace Active_cloud_site_5.DataAccess
{
    public class Active_cloud_site_5DbContext : DbContext
    {
        public Active_cloud_site_5DbContext(DbContextOptions<Active_cloud_site_5DbContext> options) : base(options)
        {
        }
        
        public DbSet<Diet_and_menu_details> Diet_And_Menu_s { get; set; }
        public DbSet<Diet_breakdown_details> Diet_Breakdown_s { get; set; }
        public DbSet<Master_Menu> Master_Menu_s { get; set; }

    }
}
