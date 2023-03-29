using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemoApp.Models.ViewModels;

namespace RazorPagesDemoApp.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInMnager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInMnager)
        {
            this.signInMnager = signInMnager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl=null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInMnager.PasswordSignInAsync(Model.Email, Model.Password,Model.RememberMe,false);

                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);

                    }
                }
                ModelState.AddModelError("", "Username or Password is incorrect");
            }
            return Page();
        }

    }
}
