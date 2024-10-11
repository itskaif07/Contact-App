
using System.ComponentModel.DataAnnotations;

namespace Contact.Models
{
    public class ContactItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Your name cannot exceed 100 characters.")]
        public string ContactName { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "The phone number must contain exactly 10 digits.")]
        public int PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        public string? ImagePath { get; set; }

        public string? Nickname { get; set; }
        public DateTime? BirthDay { get; set; }

        public string? Address { get; set; }

        public string? Notes { get; set; }
    }
}
