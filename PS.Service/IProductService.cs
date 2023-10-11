using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Service
{
    public interface IProductService
    {
        public void Add(Product c);
        public void Remove(Product c);
        public IEnumerable<Product> GetAll();
    }
}
