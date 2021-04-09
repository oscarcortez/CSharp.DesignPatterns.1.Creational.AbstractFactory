using Models.AbstractFactoryElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.AdultMenu
{
    public class AdultCuisineFactory : RecipeFactory
    {
        // notar que en esta clase recien se crean las instancias, cuando se llama a createDessert y CreateSandwich
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwich CreateSandwich()
        {
            return new BLT();            
        }
    }
}
