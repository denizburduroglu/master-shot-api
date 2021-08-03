using MasterShotAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterShotAPI.Domain
{
    public class MasterShotDbContext : DbContext
    {
        public MasterShotDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<Post> Posts { get; set; }
    }
}
