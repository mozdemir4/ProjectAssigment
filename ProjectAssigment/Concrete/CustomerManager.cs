﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectAssigment.Abstract;
using ProjectAssigment.Entities;

namespace ProjectAssigment.Concrete
{
    public class CustomerManager:BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Girilen bilgiler doğrulanamadı!!!");
            }
           
        }
    
    }
}
