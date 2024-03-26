using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class PizzaManager
    {
        public List<PizzaProperties> pizzaList;
        public PizzaManager()
        {
            pizzaList = new List<PizzaProperties>();
        }
        public List<PizzaProperties> ListOfPizza()
        {
            PizzaProperties pizza1 = new PizzaProperties() { 
                Id = 1,
                Type = "Chicken Delight Pizza",
                Price = 350.99f 
            };
            PizzaProperties pizza2 = new PizzaProperties() { 
                Id = 2, 
                Type = "Margherita Pizza",
                Price = 169.90f
            };
            PizzaProperties pizza3 = new PizzaProperties()
            {
                Id = 3,
                Type = "Chocolate and Banana Pizza",
                Price = 225.66f
            };
            PizzaProperties pizza4 = new PizzaProperties()
            {
                Id = 4,
                Type = "Chicken Pepporoni Pizza",
                Price = 290.99f
            };
            PizzaProperties pizza5 = new PizzaProperties()
            {
                Id = 5,
                Type = "Mushroom and Olive  Pizza",
                Price = 235.66f
            };
            PizzaProperties pizza6 = new PizzaProperties()
            {
                Id = 6,
                Type = "Farm House Pizza",
                Price = 240.13f
            };
            PizzaProperties pizza7 = new PizzaProperties()
            {
                Id = 7,
                Type = "Cheese and Paneer Pizza",
                Price = 275.90f
            };
            PizzaProperties pizza8= new PizzaProperties()
            {
                Id = 7,
                Type = "Cheese and Corn Pizza",
                Price = 275.90f
            };
            pizzaList.Add(pizza1);
            pizzaList.Add(pizza2);
            pizzaList.Add(pizza3);
            pizzaList.Add(pizza4);
            pizzaList.Add(pizza5);
            pizzaList.Add(pizza6);
            pizzaList.Add(pizza7);
            pizzaList.Add(pizza8);

            return pizzaList;
        }
    }
}