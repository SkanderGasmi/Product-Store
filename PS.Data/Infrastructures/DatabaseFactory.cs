using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Data.Infrastructures
{
    public class DatabaseFactory : Disposable, IDataBaseFactory
    {
        public DbContext DataContext => new PSContext();

        protected override void DisposeCore()
        {

        }

    }
}
