using Millitary.API.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Millitary.API.Models.Data
{
    public class Account
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
        public DateTime DateCreated { get; set; }
        [NotMapped]
        public string? Token { get; set; }
    }
}