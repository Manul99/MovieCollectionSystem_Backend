using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollectionSystemBackend.Domain.Entities
{
    public class Film
    {
        [Key]
        public int MovieSerialId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]  
        public string? Title { get; set; }
        [Required]
        public DateTime? ReleaseYear { get; set; }
        [Required]
        public string? Director { get; set; }
        [Required]
        public string? Duration { get; set; }
        [Required]
        [StringLength(50, MinimumLength =10, ErrorMessage ="The field must be between 10 to 50 characters")]
        public string? Description { get; set; }
        public string? PosterImage { get; set; }
    }
}
