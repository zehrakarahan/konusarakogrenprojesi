using KonusarakOgren.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KonusarakOgren.DataAccess.Context
{
    public class KonusarakOgrenContext:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=KonusarakOgrendb.db");

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ExamQuestions> ExamQuestions { get; set; }


    }
}
