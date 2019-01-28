using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcUzytkownikModels.Models;

namespace MvcUzytkownicy.Models
{
    public class MvcUzytkownicyContext : DbContext
    {
        public MvcUzytkownicyContext (DbContextOptions<MvcUzytkownicyContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieModels.Models.Uzytkownicy> Uzytkownicy { get; set; }
    }
}
