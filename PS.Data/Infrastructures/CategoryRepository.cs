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
    public class CategoryRepository : IRepository<Category>
    {
        private PSContext context;
        public IDataBaseFactory dataBaseFactory { get; set; }

        public CategoryRepository(IDataBaseFactory dataBaseFactory)
        {
            this.dataBaseFactory = dataBaseFactory;
            context = (PSContext) dataBaseFactory.DataContext;
        }

        public void Add(Category c)
        {
            context.Categories.Add(c);
        }

        public void Update(Category c)
        {
            context.Entry(c).State = EntityState.Modified;
        }

        public void Delete(Category c)
        {
            Category category = context.Categories.Find(c.CategoryId);
            context.Categories.Remove(category);
        }

        public void Delete(Expression<Func<Category, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }

        public Category GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public IEnumerable<Category> GetMany(Expression<Func<Category, bool>> condition = null)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
