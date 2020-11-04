using Core.Utililies.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstrack
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int ProductId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
/*İŞLEMLERİN BAŞARILI MI YOKSA HATALI MI OLDUGUNU Result bize söylicek*/

    }
}
