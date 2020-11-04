using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utililies.Security.Encrypted
{
    public class SignigCredentialsHelper
    {
        public static SigningCredentials SigningCredentials(SecurityKey securityKey)
        {
            //SecurityKey algortmasını belirliyoruz
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
