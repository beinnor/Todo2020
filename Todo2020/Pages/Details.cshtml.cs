using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Todo2020.Data;
using Todo2020.Models;

namespace Todo2020.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Todo2020.Data.Todo2020Context _context;

        public DetailsModel(Todo2020.Data.Todo2020Context context)
        {
            _context = context;
        }

        public TodoItem TodoItem { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TodoItem = await _context.TodoItem.FirstOrDefaultAsync(m => m.Id == id);

            if (TodoItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
