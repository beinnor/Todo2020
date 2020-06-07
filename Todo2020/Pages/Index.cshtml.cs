using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Todo2020.Models;

namespace Todo2020.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Todo2020.Data.Todo2020Context _context;

        public IndexModel(ILogger<IndexModel> logger, Todo2020.Data.Todo2020Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<TodoItem> TodoItem { get; set; }

        public async Task OnGetAsync()
        {
            TodoItem = await _context.TodoItem.ToListAsync();
        }
    }
}
