using System;
using ProjectAssigment.Abstract;
using ProjectAssigment.Concrete;
using ProjectAssigment.Entities;


namespace ProjectAssigment
{
    class Program
    {
        static void Main(string[] args)
        {

           

            BaseCustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { Id = 1, FirstName = "Muhammet", LastName = "ÖZDEMİR", DateOfBirth = new DateTime(1997, 1, 10), NationaltyId = "21321321312" });

            Customer customer1 = new Customer { Id=2,FirstName="Selma",LastName="GÜDA",DateOfBirth=new DateTime(1985),NationaltyId="2121353253" };
            Customer customer2 = new Customer { Id=3,FirstName="Murat",LastName="ÖZDEMİR",DateOfBirth=new DateTime(1987),NationaltyId="212145353253" };
            
            Games games1 = new Games { Id=1,Price=100,NameOfTheGame="Fifa2021"};

            IGamesService gamesService = new GamesManager();
            gamesService.Add(games1);

            GameOffer gameOffer1 = new GameOffer { Id=1,Explanation="İndirim",DiscountRate="%35"};

            IOfferService gameOfferManager = new GameOfferManager();
            gameOfferManager.Add(gameOffer1);
             

            ISalesService salesService = new SalesManager(new CustomerCheckManager());

            salesService.Sale(customer1, games1);
            salesService.Sale(customer2, games1, gameOffer1);








        }
    }
}
