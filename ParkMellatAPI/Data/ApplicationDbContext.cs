using Microsoft.EntityFrameworkCore;//add ef Core
using ParkMellatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkMellatAPI.Data
{
    public class ApplicationDbContext :  DbContext // using db context features 
    {

        //add ctor and options of db context 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ParkMellat> ParkMellats { get; set; }
    }
}
