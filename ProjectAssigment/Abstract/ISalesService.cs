using ProjectAssigment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssigment.Abstract
{
    interface ISalesService
    {
        void Sale(Customer customer, Games games, GameOffer gameOffer1);
        void Sale(Customer customer1, Games games1);
    }
}
