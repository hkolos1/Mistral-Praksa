﻿using Microsoft.EntityFrameworkCore;
using Mistral_Internship.Models;

namespace Mistral_Internship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
    }
}
