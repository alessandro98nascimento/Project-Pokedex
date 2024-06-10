using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace UsersApi.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [NotNull]
        [StringLength(80)]
        [EmailAddress]
        public required string Email { get; set; }

        [NotNull]
        [StringLength(100)]
        public required string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public required string UserPassword { get; set; }

        [NotNull]
        public required DateTime UserBirthDay { get; set; }

        public int UserActive { get; set; } = 1;
    }
}

