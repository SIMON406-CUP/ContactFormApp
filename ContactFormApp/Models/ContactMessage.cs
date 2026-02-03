namespace ContactFormApp.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }  // primary key
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
