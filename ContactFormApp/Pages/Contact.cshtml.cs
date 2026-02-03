using ContactFormApp.Models;
using ContactFormApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactFormApp.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ContactService _contactService;

        public ContactModel()
        {
            _contactService = new ContactService();
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public string SuccessMessage { get; set; }

        public void OnGet()
        {
            // Nothing for now
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _contactService.SaveContact(Contact);
            SuccessMessage = "Your message has been sent successfully!";
            ModelState.Clear(); // clear form
            return Page();
        }
    }
}
