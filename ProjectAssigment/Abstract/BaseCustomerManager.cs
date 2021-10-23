using ProjectAssigment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssigment.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
      
      
        public virtual void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Customer saved"+"\n"+"First Name: "+customer.FirstName+"\n"+"Last Name: "+customer.LastName);
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine("Customer updated");
        }

    }
}
