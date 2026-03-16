using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myproject1.Data;

namespace myproject1.Data.views
{
    public class DetailsModel : PageModel
    {
        private readonly myproject1.Data.MyDbcontex _context;

        public DetailsModel(myproject1.Data.MyDbcontex context)
        {
            _context = context;
        }

        public Expense Expense { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses.FirstOrDefaultAsync(m => m.ExpenseId == id);
            if (expense == null)
            {
                return NotFound();
            }
            else
            {
                Expense = expense;
            }
            return Page();
        }
    }
}
