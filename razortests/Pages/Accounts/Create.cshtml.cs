
using System.Threading.Tasks;
using AccountStoreApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AccountStore.Data;
using AccountStore.Models;
using AccountStore.Pages.Accounts.Helpers;
using System;

namespace AccountStore.Pages.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
     

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
           
        }

        [BindProperty(SupportsGet = true)]
        public AccountModel Account { get; set; }

        [BindProperty(SupportsGet = true)]
        public PasswordGenModel Generator { get; set; }

        [BindProperty(SupportsGet = true)]
        public AddPswdToAccountVM AddPswd { get; set; }


        public void OnGet()
        {
           
            Generator.GeneratedPassword = GeneratorHelper.GeneratePassword(Generator.MaxLength, Generator.UseCaps, Generator.UseSymb, Generator.UseNumbers);
            Account.Password = Generator.GeneratedPassword;
        }


        public void OnGetGenPassword()
        {
           
            Generator.GeneratedPassword = GeneratorHelper.GeneratePassword(Generator.MaxLength, Generator.UseCaps, Generator.UseSymb, Generator.UseNumbers);
    
        }
      

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid == false)
            {
                return Page();
            }

           
            await _context.AddAsync(Account);
            await _context.SaveChangesAsync();
            TempData["success"]="Account Created Successfully";
            return RedirectToPage("Index");
        }

    }
}
