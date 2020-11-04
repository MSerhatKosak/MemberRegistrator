using Businness.Abstrack;
using Core.Entites.Concrete;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string mail)
        {
            return _userDal.GetT(u => u.Email == mail);
        }

        public List<OperationClaim> GetClaim(User user)
        {
            throw new NotImplementedException();
        }
    }
}
