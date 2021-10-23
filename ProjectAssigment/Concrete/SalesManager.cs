using ProjectAssigment.Abstract;
using ProjectAssigment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssigment.Concrete
{
    public class SalesManager : ISalesService
    {
        ICustomerCheckService _customerCheckService;
        public SalesManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }  

        public void Sale(Customer customer, Games games)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("-----Sales----- "+"\n"+ "Customer: "+customer.FirstName+" "+customer.LastName + "\n" + "Games Name:"+ games.NameOfTheGame + " " + "Price(TL):" + games.Price);
            }
            else
            {
                throw new Exception("Customer is not valid");
            }
        }

        public void Sale(Customer customer, Games games, GameOffer gameOffer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("-----Sales----- "+"\n"+ "Customer: "+customer.FirstName+" "+customer.LastName + "\n" + "Games Name:"+ games.NameOfTheGame + " " + "Price(TL):" + games.Price+" "+"Discount: "+gameOffer.DiscountRate);
              
            }
            else
            {
                throw new Exception("Customer is not valid");
            }
        }
     
    }
}
