using Microsoft.EntityFrameworkCore;

namespace PS.Domain
{
    [Owned]
    public class Address
    {
        public int Id { get; set; }
        public string LabName { get; set; }

        public string StreetAdress { get; set; }
    }
}