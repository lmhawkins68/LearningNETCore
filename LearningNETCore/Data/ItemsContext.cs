﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LearningNETCore.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options) { }
        public DbSet<Models.Item> Items { get; set; }

    }
}
