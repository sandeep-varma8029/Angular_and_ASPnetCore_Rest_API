using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpressoApi.Models;


namespace ExpressoApi.Data
{
    public class ExpressoDbContext : DbContext
    {

        public ExpressoDbContext(DbContextOptions<ExpressoDbContext>options):base(options)
        {
            
        }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Proficiency> Proficiency { get; set; }
        public DbSet<TechSkill> TechSkill { get; set; }
        public DbSet<BusSkill> BusSkill { get; set; }
        public DbSet<Certification> Certification { get; set; }
        public DbSet<Languages> Languages { get; set; }
    }
}
