using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteService.Models;

namespace NoteService
{
    public class NoteServiceContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NoteServiceContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=notedb;Username=postgres;Password=1423");
        }
    }
}
