using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PokedexApi.Models
{
    [Table("Pokedex")]
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [NotNull]
        [StringLength(80)]
        public required string Name { get; set; }

        [Required]
        [NotNull]
        [StringLength(100)]
        public required string Weight { get; set; }

        [Required]
        [NotNull]
        [StringLength(100)]
        public required string Height { get; set; }

        [StringLength(100)]
        public required int Type1 { get; set; }

        [StringLength(100)]
        public int? Type2 { get; set; }

        public int? EvolutionLevel { get; set; }

        [Required]
        [NotNull]
        [StringLength(10000)]
        public required string Description { get; set; }

        [Required]
        [NotNull]
        [StringLength(5000)]
        public required string Image { get; set; }

        [Required]
        [NotNull]
        [StringLength(5000)]
        public required string ImageShiny { get; set; }
    }
}
