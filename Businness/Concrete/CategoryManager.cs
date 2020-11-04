using Businness.Abstrack;
using Core.Utililies.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Businness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<Category> GetById(int CategoryID)
        {
            return new SuccesDataResult<Category>(_categoryDal.GetT(p=>p.CategoryID==CategoryID));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccesDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }
    }
}
