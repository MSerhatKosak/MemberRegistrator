using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Entity
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
