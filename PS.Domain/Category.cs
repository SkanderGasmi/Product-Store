namespace PS.Domain
{
    public class Category : Concept
    {
        public int CategoryId { get; set; }
       
        public string Name { get; set; }
            
        public virtual IList<Product> Products { get; set; }

        public override string GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}