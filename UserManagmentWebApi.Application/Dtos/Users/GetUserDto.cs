using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentWebApi.Application.Dtos.Users
{
    public record GetUserDto(Guid UserId, string FirstName, string LastName, string Email, string Contact, string ImageUrl, string Role, string UserName);
   
}
