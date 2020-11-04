using Core.Entites.Concrete;
using Core.EntityFramework;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepostoryBase<User, NortwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaim(User user)
        {
            using (var context = new NortwindContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationsClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
