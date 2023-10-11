namespace PS.Domain
{
    public class Biological: Product
    {
        public string Herbs { get; set; }

        //Methods
        public override string GetMyType()
        {
            return "BIOLOGICAL";
        }

        public override string GetDetails()
        {
            string details = base.GetDetails();
            details += $"Herbs: {Herbs}\n ";

            return details;
        }   
    }
}