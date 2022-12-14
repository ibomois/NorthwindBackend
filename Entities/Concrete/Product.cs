using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity 
    {
        public int ProtectId { get; set; }

        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public string QuantityPerUnit  { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitInStock { get; set; }


    }
}
