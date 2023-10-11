using System;
using System.Reflection;

namespace PS.Domain
{
    public class Provider : Concept
    {
        private string _password;
        private string _confirmPassword;

        //Properties
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length < 5 || value.Length > 20)
                    throw new ArgumentException("La taille du mot de passe doit etre entre 5 et 20");
                _password = value;
            }
        }

        public string ConfirmPassword 
        {
            get
            {
                return _confirmPassword;
            }
            set
            {
                if (value != _password)
                    throw new ArgumentException("Les mots de passes doivent etre identiques");
                _confirmPassword = value;
            }
        
        }    
        
        public DateTime DateCreated { get; set; }    
        
        public string Email { get; set; }    
        
        public int Id { get; set; }    
        
        public bool IsApproved { get; set; }    
        
           
        
        public string UserName { get; set; }

        //Relations
        public virtual IList<Product> Products { get; set; }

        //Methods
        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = !P.IsApproved;
        }

        public static void SetIsApproved(string password, string confirmPassword, out bool isApproved)
        {
            isApproved = password == confirmPassword ? true : false;    
        }

        public bool Login(string userName, string password) 
        {
            return false;
        }

        public bool Login(string userName,  string password, string email)
        {
            return false;
        }

        //public bool Login(string userName,  string password, string? email)
        //{
        //    return false;
        //}

        public override string GetDetails()
        {
            string details = $"Password: {Password}\n " +
                $"ConfirmPassword: {ConfirmPassword}\n" +
                $"DateCreated: {DateCreated}\n" +
                $"Email: {Email}\n" +
                $"IsApproved: {IsApproved}\n" +
                $"UserName: {UserName}\n"+
                $"Products:\n\n";

            foreach(Product p in Products)
            { 
                details += p.GetDetails();

            }

            return details;
        }
        
        public IList<Product> GetProducts(string filterType, string filterValue)
        {
            IList<Product> products = new List<Product>();
            foreach (var p in Products)
            {
                PropertyInfo[] properties = p.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    if (property.GetValue(p) != null && 
                        property.Name == filterType &&
                        property.GetValue(p).ToString().Equals(filterValue))
                            
                        products.Add(p);
                }
                
            }

            return products;
        }
    }
}