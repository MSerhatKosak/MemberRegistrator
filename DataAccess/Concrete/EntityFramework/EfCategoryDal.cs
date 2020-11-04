using Core.EntityFramework;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCategoryDal:EfEntityRepostoryBase<Category,NortwindContext>,ICategoryDal
    {
    }
}
