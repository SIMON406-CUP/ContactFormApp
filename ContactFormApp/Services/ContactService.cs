using ContactFormApp.Models;
using System.Text.Json;

namespace ContactFormApp.Services
{
    public class ContactService
    {
        private const string FilePath = "contacts.json";

        public void SaveContact(Contact contact)
        {
            List<Contact> contacts = new List<Contact>();

            if (File.Exists(FilePath))
            {
                string existingData = File.ReadAllText(FilePath);
                contacts = JsonSerializer.Deserialize<List<Contact>>(existingData) ?? new List<Contact>();
            }

            contacts.Add(contact);

            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public List<Contact> GetAllContacts()
        {
            if (!File.Exists(FilePath)) return new List<Contact>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }
    }
}
