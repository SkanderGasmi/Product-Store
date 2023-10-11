using PS.Domain;

namespace PS.Service
{
    public static class ProductExtension
    {
        public static void UpperName(this Product p)
        {
            p.Name = p.Name.ToUpper();
        }

        public static bool InCategory(this Product p, Category category)
        {
            return p.Category.Equals(category) ? true : false;
        }

    }
}
