using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders:true);
            Console.WriteLine(rating == 0 ? "Promoted to level 1" : "Promoted to level 2");
        }


        //change CalculatingRating to private to make it acessible only to promote()
        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}