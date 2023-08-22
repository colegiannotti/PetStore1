﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);
        public DogLeash GetDogLeashByName(string name);
        public List<Product> GetAllProducts();

        public List<string> GetOnlyInStockProducts();
    }
}
