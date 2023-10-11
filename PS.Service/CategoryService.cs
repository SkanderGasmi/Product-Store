using PS.Data.Infrastructures;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Service
{
    public class CategoryService : ICategoryService
    {
        public IDataBaseFactory DatabaseFactory { get; set; }
        public IRepository<Category> CategoryRepository { get; set; }
        public IUnitOfWork unitOfWork { get; set; }


        public CategoryService()
        {
            DatabaseFactory = new DatabaseFactory();
            unitOfWork = new UnitOfWork();
            CategoryRepository = new CategoryRepository(DatabaseFactory);
        }

        public void Add(Category c)
        {
            CategoryRepository.Add(c);
        }

        

        public void Remove(Category c)
        {
            CategoryRepository.Delete(c);
        }

        public IEnumerable<Category> GetAll()
        {
            return CategoryRepository.GetAll();
        }
    }
}
