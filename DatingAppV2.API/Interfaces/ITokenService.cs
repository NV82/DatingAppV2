using DatingAppV2.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppV2.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
