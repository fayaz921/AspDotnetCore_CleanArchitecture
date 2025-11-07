using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentWebApi.Application.Dtos.Authentication
{
    public record UserRegisterDto(string FirstName, string LastName, string Email, string Password, string Contact, string UserName);

}
