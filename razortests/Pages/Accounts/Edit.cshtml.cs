
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountStore.Data;
using AccountStore.Models;
using Microsoft.AspNetCore.Http;

namespace AccountStore.Pages.Accounts
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
       

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
           
        }

        [BindProperty]
        public AccountModel Account { get; set; }

        public void OnGet(int id)
        {
            Account = _context.Accounts.Find(id);
        }

       
        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid == false)
            {
                return Page();
            }
        
         

            _context.Update(Account);
            await _context.SaveChangesAsync();
            TempData["success"] = "Account Updated Successfully";
           
            return RedirectToPage("Index");
        }

    }
}
