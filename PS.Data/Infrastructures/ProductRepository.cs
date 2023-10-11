using Microsoft.EntityFrameworkCore;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PS.Data.Infrastructures
{
    public class ProductRepository : IRepository<Product>
    {
        private PSContext context;
        public IDataBaseFactory dataBaseFactory { get; set; }

        public ProductRepository(IDataBaseFactory dataBaseFactory)
        {
            this.dataBaseFactory = dataBaseFactory;
            context = (PSContext) dataBaseFactory.DataContext;
        }

        public void Add(Product p)
        {
            context.Products.Add(p);
        }

        public void Update(Product p)
        {
            context.Entry(p).State = EntityState.Modified;
        }

        public void Delete(Product p)
        {
            Product product= context.Products.Find(p.ProductId);
            context.Products.Remove(product);
        }

        public void Delete(Expression<Func<Product, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public IEnumerable<Product> GetMany(Expression<Func<Product, bool>> condition = null)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
