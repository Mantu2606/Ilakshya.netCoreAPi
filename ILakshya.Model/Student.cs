using System.ComponentModel.DataAnnotations;

namespace ILakshya.Model
{
    public class Student
    {
        [Key]
        public int StuEnrollNo { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Student name is required field")]
        public string StuName { get; set; } = string.Empty;

        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;

        [MaxLength(50)]
        [Required(ErrorMessage = "Student city is a required field!")]
        public string City { get; set; } = string.Empty;

        [MaxLength(10)]
        public string Zipcode { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Country { get; set; } = string.Empty;

        [MaxLength(15)]
        [Required(ErrorMessage = "Student phone number is a required field!")]
        public string Phone { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required(ErrorMessage = "Student email is a required field!")]

        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Avatar { get; set; } = string.Empty;
    }
}
