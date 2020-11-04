using Core.Entites.Concrete;
using Core.Utililies.Security.Encrypted;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Utililies.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get;}
        private TokenOptions _tokenOptions;
        private DateTime _accesTokenExpirations;
        public JwtHelper(IConfiguration configuration,TokenOptions tokenOptions)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOption").Get<TokenOptions>();
            _accesTokenExpirations = DateTime.Now.AddMinutes(tokenOptions.AccessTokenExpration);
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey = SecurityHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SignigCredentialsHelper.SigningCredentials(securityKey);
            
        }
        public JwtSecurityToken CreateSecurityToken(User user,TokenOptions tokenOptions ,
            SigningCredentials signingCredentials,List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires:_accesTokenExpirations,
                notBefore:DateTime.Now,
                claims:operationClaims,
                signingCredentials:signingCredentials
                ) ;
        }
        private IEnumerable<Claim> SetClaim(User user,List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("Email", user.Email));
        }
    }
}
