using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.AbstractFactoryElements;
namespace Models
{
    public abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();

        public abstract Dessert CreateDessert();
    }
}
