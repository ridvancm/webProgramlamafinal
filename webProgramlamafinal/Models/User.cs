using System.ComponentModel.DataAnnotations;

namespace webProgramlamafinal.Models
{
    public class User
    { 
        
            [Key] // Primary Key
            public int? UserId { get; set; }

            [Required]
            [StringLength(50)]
            public string? UserName { get; set; }

            [Required]
            [StringLength(100)]
            public string? Password { get; set; }
            public string? Email { get; set; }

            [Required]
            [Phone]
            public string? PhoneNumber { get; set; }
            [Required]
            public string? Gender { get; set; }

    }

}

