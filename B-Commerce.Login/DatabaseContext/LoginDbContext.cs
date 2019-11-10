using B_Commerce.Login.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_Commerce.Login.DatabaseContext
{
    public class LoginDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6JDHFRJ;Database=LoginDatabase;Trusted_Connection=True;");
        }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}
