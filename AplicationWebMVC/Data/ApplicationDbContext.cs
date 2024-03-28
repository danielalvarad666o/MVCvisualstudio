using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace ASP.Data
{
    using Microsoft.EntityFrameworkCore;
    using App.Models;
    
    
   
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }

            public DbSet<Customers> customers { get; set; }
     

            [DbFunction(Schema = "dbo")]
            public static int fn_PorductCategory_count(int pCategoryId)
            {
                throw new Exception();
            }
        }
    }


