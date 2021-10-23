using ProjectAssigment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssigment.Abstract
{
    public interface IOfferService
    {
        void Add(GameOffer gameOffer);
        void Delete(GameOffer gameOffer);
        void Update(GameOffer gameOffer);
    }
}
