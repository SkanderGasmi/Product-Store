using PS.Domain;
using System;
using System.Reflection.Metadata;
using static PS.Service.ManageProduct;

namespace PS.Service
{
    public class ManageProduct
    {
        //Properties
        public IList<Product> Products { get; set; }
        //public delegate IList<Product> FindProductDlg(char x
        //public delegate IList<Product> ScanProductDlg(Category c);

        //or 
        Func<char, IList<Product>> FindProductDlg;
        Func<Category, IList<Product>> ScanProductDlg;

        //Methods
        public ManageProduct()
        {
            Products = new List<Product>();

           // FindProductDlg FindProductAnonymous = FindProduct;
            // ScanProductDlg ScanProductAnonymous = ScanProduct;

            //or :
            FindProductDlg  = x => Products.Where(p => p.Name[0] == x).ToList(); ;
            ScanProductDlg = c => Products.Where(p => p.InCategory(c)).ToList(); ;


            


        }

        public ManageProduct(IList<Product> products) : this()
        {
            Products = products;
        }

        public IList<Chemical> Get5Chemical(double price)
        {
          return Products.OfType<Chemical>().Where(x => x.Price > price).Take(5).ToList();
        }
        //public IList<Product> Get5Chemical(double price)
        //{
        //    return Products.Where(x => x.GetMyType() == "CHEMICAL" && x.Price > price).Take(5).ToList();
        //}

        public IList<Product> GetProductPrice(double price)
        {
            return Products.Where(x => x.Price > price).Skip(2).ToList();
        }

        public double GetAveragePrice()
        {
            return Products.Average(x => x.Price);
        }

        public Product GetMaxPrice()
        {
            return Products.Where(x => x.Price == Products.Select(x => x.Price).Max(x => x)).Single();
        }

        public int GetCountProduct(string city)
        {
            return Products.OfType<Chemical>().Where(x => x.City == city).Count();
        }

        public IList<Chemical> GetChemicalCity()
        {
            return Products.OfType<Chemical>().OrderBy(x => x.City).ToList();
        }

        public IList<IGrouping<string,IList<Chemical>>> GetChemicalGroupByCity()
        {
            return (IList<IGrouping<string, IList<Chemical>>>)Products.OfType<Chemical>().OrderBy(x => x.City).GroupBy(x => x.City).ToList();
        }

        public IList<Product> FindProduct(char x)
        {
            return Products.Where(p => p.Name[0] == x).ToList();

        }
        
        public IList<Product> ScanProduct(Category c)
        {
            return Products.Where(p => p.InCategory(c)).ToList();

        }





    }
}