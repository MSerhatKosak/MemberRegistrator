using Core.Utililies.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstrack
{
   public interface ICategoryService
    {
        IDataResult<Category> GetById(int CategoryID);
        IDataResult<List<Category>> GetList();
    }
}
