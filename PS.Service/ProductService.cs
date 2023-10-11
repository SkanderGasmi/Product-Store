using PS.Data.Infrastructures;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Service
{

    public class ProductService : IProductService
    {
        public IDataBaseFactory DatabaseFactory { get; set; }
        public IRepository<Product> ProductRepository { get; set; }
        public IUnitOfWork unitOfWork { get; set; }


        public ProductService()
        {
            DatabaseFactory = new DatabaseFactory();
            unitOfWork = new UnitOfWork();
            ProductRepository = new ProductRepository(DatabaseFactory);
        }

    

        public void Add(Product c)
        {
            ProductRepository.Add(c);
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductRepository.GetAll();
        }


        public void Remove(Product c)
        {
            ProductRepository.Delete(c);    
        }

//        public IEnumerable<Product> FindMost5ExpensiveProds()
//        {
//            GetAll().OrderByDescending(x => x.).Take(5);
//        }

//        - UnavailableProdPercentage qui retourne le pourcentage des produits dont la quantité est
//épuisée.
//- GetProdByClient qui retourne les produits achetés par un client passé en paramètre.
//- DeleteOldProducts qui supprime les produits dont la date de production a dépassé une
//année.


    }
}
