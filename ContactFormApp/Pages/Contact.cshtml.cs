using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactFormApp.Data;
using ContactFormApp.Models;

namespace ContactFormApp.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ContactFormContext _context;

        public ContactModel(ContactFormContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactMessage ContactMessage { get; set; }

        public string SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Validation failed, stay on page and show errors
                return Page();
            }

            // Save the message
            _context.ContactMessages.Add(ContactMessage);
            _context.SaveChanges();

            SuccessMessage = "Your message has been sent successfully!";
            ModelState.Clear(); // clear the form

            return Page();
        }
    }
}
