﻿using Microsoft.EntityFrameworkCore;
using RestApiModelDDD.Domain.Entitys;
using System;
using System.Linq;

namespace RestApiModelDDD.Infrastruture.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }
        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }
        //    return base.SaveChanges();
        //}
    }
}