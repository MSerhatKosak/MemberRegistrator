using Businness.Abstrack;
using Core.Utililies.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*DataResult IResult donuş tiplerini ürün eklemede hata var mı hataları yakaalamk için kullanıyoruz*/
namespace Businness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            //DataAccesdeki adde göndeeriyoruz ordakide core katmanındaki base 
            //Repostroye gönderiyor.
            _productDal.Add(product);
            return new SuccessResult("Ürün kaydedildi");
        }

        public IResult Delete(Product product)
        {
            //İŞ KODLARI
            _productDal.Delete(product);
            return new SuccessResult("Ürün silindi");
        }

        public IDataResult<Product> GetById(int ProductId)
        {
            //İŞ KODLARI
            return new SuccesDataResult<Product>(_productDal.GetT(p => p.ProductID == ProductId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult< List<Product>> GetListByCategory(int categoryId)
        {
            //İŞ KODLARI
            return new SuccesDataResult<List<Product>>(_productDal.GetList(p => p.CategoryID == categoryId).ToList(),"Ürün geldi");

        }

        public IResult Update(Product product)
        {
            //İŞ KODLARI
            _productDal.Update(product);
            return new SuccessResult("Ürün güncellendi");
        }
    }
}
