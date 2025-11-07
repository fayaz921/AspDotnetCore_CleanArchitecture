using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagmentWebApi.Application.Dtos.Authentication
{
    public record UserLoginDto(string UserIdentifier, string Password);
  
}
