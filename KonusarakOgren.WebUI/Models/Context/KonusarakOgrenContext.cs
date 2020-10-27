using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.WebUI.Models.Context
{
    public class KonusarakOgrenContext:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=KonusarakOgrenContext.db");
           
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=KonusarakOgrenContext.db");

        //}
        public DbSet<User> Users { get; set; }
        public DbSet<ExamQuestions> ExamQuestions { get; set; }
    }
}
