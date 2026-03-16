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
    public class IndexModel : PageModel
    {
        private readonly myproject1.Data.MyDbcontex _context;

        public IndexModel(myproject1.Data.MyDbcontex context)
        {
            _context = context;
        }

        public IList<Expense> Expense { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Expense = await _context.Expenses.ToListAsync();
        }
    }
}
