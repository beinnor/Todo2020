using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo2020.Models;

namespace Todo2020.Data
{
    public class Todo2020Context : DbContext
    {
        public Todo2020Context (DbContextOptions<Todo2020Context> options)
            : base(options)
        {
        }

        public DbSet<Todo2020.Models.TodoItem> TodoItem { get; set; }
    }
}
