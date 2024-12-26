using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShopWebApp.Data;
using ShopWebApp.Data.Identity;

namespace ShopWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ShopWebApp.Data.ApplicationDbContext _context;

        public IndexModel(ShopWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }


    }
}
