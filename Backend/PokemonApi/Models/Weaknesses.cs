using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WeaknessesApi.Models
{
    [Table("Weaknesses")]
    public class Weakness
    {
        [Key]
        public int Id { get; set; }

        public int? Type1 { get; set; }
        public int? Type2 { get; set; }
        public int? Type3 { get; set; }
        public int? Type4 { get; set; }
        public int? Type5 { get; set; }
    }
}

