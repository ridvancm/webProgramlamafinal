using System.ComponentModel.DataAnnotations;

namespace webProgramlamafinal.Models
{
    public class Recipie
    {
        
            [Key] // Primary Key
            public int RecipeId { get; set; }

            [Required]
            [StringLength(100)]
            public string ?Title { get; set; } // Tarifin adı

            [Required]
            public string? Description { get; set; } // Tarif açıklaması

            [Required]
            public string? Ingredients { get; set; } // Malzemeler listesi

            [Required]
            public string? Instructions { get; set; } // Tarif adımları

            public DateTime CreatedAt { get; set; } = DateTime.Now; // Oluşturulma tarihi
        
    }
}
