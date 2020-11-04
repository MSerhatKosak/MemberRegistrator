using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Security.Encrypted
{
   public class SecurityHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            //SecurityKey oluşturuyoruz
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
