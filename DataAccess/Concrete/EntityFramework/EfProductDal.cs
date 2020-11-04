using Core.EntityFramework;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepostoryBase<Product,NortwindContext>,IProductDal
    {
       
    }
}
