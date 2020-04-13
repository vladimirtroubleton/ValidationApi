using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidApiCore3._1.Models;

namespace ValidApiCore3._1.Contexts
{
    public class OrderContext : DbContext
    {
        public DbSet<OrderModel> Orders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 1,
                                                                       ContractId  = Guid.NewGuid().ToString() ,
                                                                        CustomerName = "Александр Дмитриевич Борисов" ,
                                                                            ProductPrice = 4000 , 
                                                                                ProductCount  = 3 , 
                                                                                    FinalPrice = 3*4000, 
                                                                                        ProductName = "Трансформатор 2001",
                                                                                            OrderDate = DateTime.Now});

        }
    }
}
