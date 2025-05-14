using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //thêm dữ liệu cho bang
            List<Category> lstcategorie = new List<Category>();
            lstcategorie.Add(new Category { Id = 1, Name = "Điện thoại Iphone X", DisplayOrder = 1 });
            lstcategorie.Add(new Category { Id = 2, Name = "Điện thoại Iphone 11", DisplayOrder = 2 });
            lstcategorie.Add(new Category { Id = 3, Name = "Điện thoại Iphone 12", DisplayOrder = 3 });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Điện thoại Iphone 11", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Điện thoại Iphone 12", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Điện thoại Iphone 13", DisplayOrder = 3 }


                );
            //thêm dữ liệu cho bảng product
            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Name = "Điện thoại Iphone 11", CategoryId =1,Price=1200 },
               new Product { Id = 2, Name = "Điện thoại Iphone 12", CategoryId = 2, Price = 12300 },
               new Product { Id = 3, Name = "Điện thoại Iphone 13", CategoryId = 3, Price = 12040 }


               );
        }
    }
}
