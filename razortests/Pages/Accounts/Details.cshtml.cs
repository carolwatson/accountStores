using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountStore.Data;
using AccountStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AccountStoreApp.Pages.Accounts
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AccountModel Account { get; set; }

        public void OnGet(int id)
        {
            Account = _context.Accounts.Find(id);
        }
    }
}
