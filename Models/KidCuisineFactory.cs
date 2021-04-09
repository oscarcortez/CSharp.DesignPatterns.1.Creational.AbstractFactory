using Models.AbstractFactoryElements;
using Models.ChildMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class KidCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }

        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }
    }
}
