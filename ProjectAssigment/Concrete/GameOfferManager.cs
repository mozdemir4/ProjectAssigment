using ProjectAssigment.Abstract;
using ProjectAssigment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssigment.Concrete
{
    public class GameOfferManager : IOfferService
    {
        public void Add(GameOffer gameOffer)
        {
            Console.WriteLine("Discount added: " + gameOffer.Explanation + " " + gameOffer.DiscountRate);
        }

        public void Delete(GameOffer gameOffer)
        {
            Console.WriteLine("Discount deleted: " + gameOffer.Id);
        }

        public void Update(GameOffer gameOffer)
        {
            Console.WriteLine("Discount updated: " + gameOffer.Id);
        }
    }
}
