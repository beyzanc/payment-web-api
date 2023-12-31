﻿using Microsoft.EntityFrameworkCore;
using ResiPay.DB.DbConfigurations;
using ResiPay.DB.Entities;
using ResiPay.DB.SeedDatas;

namespace ResiPay.DB
{
    public class ResiPayDbContext : DbContext
    {
        public ResiPayDbContext() { }

        public ResiPayDbContext(DbContextOptions<ResiPayDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Apartment> Apartment { get; set; }
        public DbSet<Message> Message { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BillConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());

            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new MessageSeed());
            modelBuilder.ApplyConfiguration(new BillSeed());
            modelBuilder.ApplyConfiguration(new ApartmentSeed());

            base.OnModelCreating(modelBuilder);
        }

    }
}

