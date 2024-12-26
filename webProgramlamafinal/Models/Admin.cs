using System.ComponentModel.DataAnnotations;

namespace webProgramlamafinal.Models
{
  
        public class Admin
        {
            [Key] // Primary Key
            public int AdminId { get; set; }

            [Required]
            [StringLength(50)]
            public string ?Username { get; set; } // Kullanıcı adı

            [Required]
            [StringLength(100)]
            public string ?Password { get; set; } // Şifre

            [Required]
            [EmailAddress]
            public string ?Email { get; set; } // Email adresi
        }
}

