using System.Net;

namespace PS.Domain
{
    public class Chemical : Product
    {
        public string City {get;set;}   

        public Address address { get;set;}

        //Methods
        public override string GetMyType()
        {
            return "CHEMICAL";
        }
        
        public override string GetDetails()
        {
            string details = base.GetDetails();
            details += $"City: {City}\n " +
               $"LabName: {address.LabName}\n" +
               $"StreetAdress: {address.StreetAdress}\n";

            return details;
        }




    }
}