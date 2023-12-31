﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IshuBooks.Models;
namespace IshuBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<CoverType> CoverType { get; set; }

        public object CoverTypes { get; internal set; }
        public DbSet<Product> Products { get; set; }
    }
}
