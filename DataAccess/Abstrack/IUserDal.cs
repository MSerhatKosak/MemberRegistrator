using Core.CoreDataAccess;
using Core.Entites.Concrete;
using Core.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IUserDal : IEntityRepostory<User>
    {
        List<OperationClaim> GetClaim(User user);
    }
}
