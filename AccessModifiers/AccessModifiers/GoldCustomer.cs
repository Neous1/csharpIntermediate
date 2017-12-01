using System;
using Amazon;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            Console.WriteLine("CalculateRating was protected , thus no good");
        }
    }
}