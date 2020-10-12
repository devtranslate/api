﻿using DevTranslate.Api.Context.Configurations;
using DevTranslate.Api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.Context
{
    public class DevTranslateContext : DbContext
    {
        protected DevTranslateContext()
        {
        } 

        public DevTranslateContext(DbContextOptions<DevTranslateContext> options) : base(options)
        {
        }

        public DbSet<Translation> Translations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TranslationConfiguration());

            modelBuilder.Seed();
        }
    }
}
