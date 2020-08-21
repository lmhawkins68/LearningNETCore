using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LearningNETCore.Data;
using LearningNETCore.Models;

namespace LearningNETCore.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly LearningNETCore.Data.ItemsContext _context;

        public IndexModel(LearningNETCore.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
