using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PS.Service
{
    public class ManageProvider
    {
        public IList<Provider> Providers { get; set; }

        public IList<Provider> GetProviderByName(string name)
        {
            return this.Providers.Where(p => p.UserName.Equals(name)).Select(p => p).ToList();

        }
        public Provider GetFirstProviderByName(string name)
        {
            return this.Providers.Where(p => p.UserName.Equals(name)).Select(p => p).First();
        }
        public Provider GetProviderById(int id)
        {
            return this.Providers.Where(p => p.Id.Equals(id)).Select(p => p).Single();
        }
        

    }
}
