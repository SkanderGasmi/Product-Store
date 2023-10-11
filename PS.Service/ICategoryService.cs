using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Service
{
    public interface ICategoryService
    {
        public void Add(Category c);
        public void Remove(Category c);
        public IEnumerable<Category> GetAll();
    }
}
