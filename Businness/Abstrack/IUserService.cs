using Core.Entites.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstrack
{
   public interface IUserService
    {
        List<OperationClaim> GetClaim(User user);
        void add(User user);
        User GetByMail(string mail);

    }
}
