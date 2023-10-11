using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Data.Infrastructures
{
    public interface IDataBaseFactory : IDisposable
    {
        DbContext DataContext { get; }
    }
}
