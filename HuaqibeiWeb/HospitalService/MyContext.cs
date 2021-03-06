﻿using HuaqibeiDTO;
using HuaqibeiService;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntites
{
    public class MyContext:DbContext
    {
        public MyContext() : base("name=connStr")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(
                Assembly.GetExecutingAssembly());
        }
        public DbSet<user> users { get; set; }
    }
}
