using System;
using System.ComponentModel.DataAnnotations;

namespace ContactFormApp.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [StringLength(1000, ErrorMessage = "Message cannot be longer than 1000 characters")]
        public string? Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
