﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contact.Models
{
    public class ContactItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        [MaxLength(50, ErrorMessage = "Your name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [MaxLength(50, ErrorMessage = "Your name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Phone Number")]
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
