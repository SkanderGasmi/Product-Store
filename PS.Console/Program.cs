using PS.Data;
using PS.Domain;
using PS.Service;


//Provider P1 = new Provider()
//{
//    Password = "aa",
//    ConfirmPassword = "aa"
//};

//bool IsApproved;
//Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, out IsApproved);
//P1.IsApproved =IsApproved;

//Console.WriteLine(P1.Password);
//Console.WriteLine(P1.ConfirmPassword);
//Console.WriteLine(P1.IsApproved); // False car passage de P1.IsApproved par valeur (copie) 
//Console.WriteLine("======================================");


//Provider P2 = new Provider()
//{
//    Password = "bb",
//    ConfirmPassword = "bb"
//};
//Provider.SetIsApproved(P2);


//Console.WriteLine(P2.Password);
//Console.WriteLine(P2.ConfirmPassword);
//Console.WriteLine(P2.IsApproved); // True car passage de P1 par référence 


//3- Encapsulation
//Provider P1 = new Provider();
//P1.Password = "aaaaaa";
//Console.WriteLine(P1.Password);
//P1.ConfirmPassword = "aaaaaa";
//Console.WriteLine(P1.ConfirmPassword);

//4- Ploymorphisme
//Product P1 = new Product();
//Product P2 = new Biological();
//Product P3 = new Chemical();

//Console.WriteLine(P1.GetMyType());
//Console.WriteLine(P2.GetMyType());
//Console.WriteLine(P3.GetMyType());

//5- V Collections / Itérations / Structures conditionnelles
/*Provider provider = new Provider()
{
    Products = new List<Product>()
     {
         new Product()
         {
             Name = "a"
         },
         new Biological()
         {
             Name = "b"
         },
         new Chemical()
         {
             Name = "a"
         }
     }
};

IList<Product>  p = provider.GetProducts("Name", "a");
*/

Category category1 = new Category() { Name = "CAT1" };
Category category2 = new Category() { Name = "CAT2" };
Category category3 = new Category() { Name = "CAT3" };

Product product1 = new Product() { Name = "prod1", Category = category1 };
Product product2 = new Product() { Name = "PROD2", Category = category1 };
Product product3 = new Product() { Name = "PROD3", Category = category3 };
Product product4 = new Product() { Name = "PROD4", Category = null };
Product product5 = new Product() { Name = "PROD5", Category = category2 };
Product product6 = new Product() { Name = "PROD6", Category = category3 };

Provider provider1 = new Provider() { UserName = "PROV1", Products = new List<Product> { product1, product2, product3 } };
Provider provider2 = new Provider() { UserName = "PROV2", Products = new List<Product> { product1, product5 } };
Provider provider3 = new Provider() { UserName = "PROV3", Products = new List<Product> { product1, product4 } };
Provider provider4 = new Provider() { UserName = "PROV4", Products = new List<Product> { product6, product4 } };
Provider provider5 = new Provider() { UserName = "PROV5", Products = new List<Product> { product6, product4, } };


//IList<Product> provider1ProductsCategory1 = provider1.GetProducts("Category", "CAT1");
//Console.WriteLine(provider1ProductsCategory1.Count());

//foreach (Product product in provider1ProductsCategory1)
//{
//    Console.WriteLine(product.GetDetails());


//}

//product1.UpperName();
//Console.WriteLine(product1.Name);
//Console.WriteLine(product1.InCategory(category2));

// Partie 3: Entity Framework Core

PSContext psContext = new PSContext();
psContext.Add((new Product() { Name = "PROD1",DateProd = DateTime.Now }));