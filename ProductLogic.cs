using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        //access type name
        private List<Product> _products;
        private Dictionary<string, DogLeash> dictDog;
        private Dictionary<string, CatFood> dictCat;

        public ProductLogic()
        {
            _products = new List<Product>() {
                new DogLeash
                {
                    Name = "Dog Leash 1",
                    Quantity = 1
                },
                new DogLeash
                {
                    Name = "Dog Leash 2",
                    Quantity = 2
                },
                new CatFood
                {
                    Name = "Cat Food",
                    Quantity = 0
                }
            };

            dictDog = new Dictionary<string, DogLeash>();
        }

        public void AddProduct(Product newProduct)
        {
            if(newProduct is DogLeash)
            {
                //Add to dictDog
                dictDog.Add(newProduct.Name, newProduct as DogLeash);
            } else if(newProduct is CatFood)
            {
                //Add to dictCat
                dictCat.Add(newProduct.Name, newProduct as CatFood);
            }
            _products.Add(newProduct);
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return dictDog[name];
            } catch (Exception ex)
            {
                return null;
            }
            
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
        
        public List<string> GetOnlyInStockProducts()
        {
            return _products.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }
    }
}
