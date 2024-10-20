﻿using CardAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CardAPI.Data
{
    public class CardsDbContext : DbContext
    {
        public CardsDbContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet
        public DbSet<Card> Cards { get; set; }
    }
}
