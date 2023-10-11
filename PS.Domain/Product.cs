using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Threading.Channels;

namespace PS.Domain
{
    public class Product : Concept
    {
        //Properties
        public DateTime DateProd { get; set; }

        [DisplayFormatAttribute()]
        public string Description { get; set; }

        [Required]
        [StringLength(25,ErrorMessage = "La taille de la chaîne saisie ne dépasse pas les 25 caractères.")]
        [MaxLength(50,ErrorMessage = "La taille de la chaîne saisie ne dépasse pas les 25 caractères.")]
        public string Name { get; set; }

        public double Price { get; set; }

        public int ProductId { get; set; }
        
        public int Quantity { get; set; }

        public string ImageName { get; set; }

        public PackagingType MyPackagingType { get; set; } = 0;


        //Relations
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual IList<Provider> Providers { get; set; }

        //Methods
        public virtual string GetMyType()
        {
            return "UNKOWN";
        }


        public override string GetDetails()
        {
            string details = $"DateProd: {DateProd}\n " +
               $"Description: {Description}\n" +
               $"Name: {Name}\n" +
               $"Price: {Price}\n" +
               $"ProductId: {ProductId}\n" +
               $"Quantity: {Quantity}\n";

            return details;
        }

        
    }
}