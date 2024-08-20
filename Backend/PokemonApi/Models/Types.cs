using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TypesApi.Models
{
    [Table("PokeTypes")]
    public class PokeType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [NotNull]
        [StringLength(80)]
        public required string TypeName { get; set; }
    }
}

