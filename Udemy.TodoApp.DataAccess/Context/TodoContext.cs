using Microsoft.EntityFrameworkCore;
using System;
using Udemy.TodoApp.DataAccess.Configrations;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.DataAccess.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfigration());
        }
        public DbSet<Work> Works { get; set; }

    }
}
