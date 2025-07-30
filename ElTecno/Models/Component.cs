using System.ComponentModel.DataAnnotations;

namespace ElTecno.Models
{
    public class Component
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        [RegularExpression(@"^(http|https)://[^\s/$.?#].[^\s]*$", ErrorMessage = "La URL debe ser válida y comenzar con http:// o https://")]
        public string ApiUrl { get; set; }

        [Range(5, 3600, ErrorMessage = "El intervalo de refresco debe estar entre 5 y 3600 segundos.")]
        public int RefreshInterval { get; set; }
        public string Size { get; set; } // "small", "medium", "large"
        public string Position { get; set; } = "medium";
        public bool IsActive { get; set; } = true;
        public bool IsFavorite { get; set; }
        public string ApiKey { get; set; } = "****"; // Opcional API key
    }
}