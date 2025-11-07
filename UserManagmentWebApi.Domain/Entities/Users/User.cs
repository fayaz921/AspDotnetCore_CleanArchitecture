using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentWebApi.Domain.Entities.Enums;

namespace UserManagmentWebApi.Domain.Entities.Users
{
    public class User
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();

        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();

        public Role Role { get; set; } = Role.User;

        public string? ImageUrl { get; set; }

        public string Contact { get; set; } = string.Empty;

        public string? OTP { get; set; }
    }
}
