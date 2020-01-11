﻿using System;
using MedicalDutyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalDutyAPI
{
    public class DutyingContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=medical_duty_database;Username=;Password=");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("medical_duty_schema");
        }
    }
}
