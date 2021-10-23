using ProjectAssigment.Abstract;
using ProjectAssigment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssigment.Concrete
{
    public class GamesManager : IGamesService
    {
        public void Add(Games games)
        {
            Console.WriteLine("Game added" + "\n" + "Game Name: " + games.NameOfTheGame + " " + "Price " + games.Price);
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Game Id: "+games.Id+" "+"Game Name: "+games.NameOfTheGame);
        }
        public void Update(Games games)
        {
            Console.WriteLine("Game updated: " + games.NameOfTheGame + " " + games.Price);
        }
    }
}
