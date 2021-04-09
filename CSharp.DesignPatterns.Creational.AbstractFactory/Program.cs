using Models;
using Models.AdultMenu;
using System;

namespace CSharp.DesignPatterns.Creational.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(A)dult or (C)hild?:");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;
            
            switch(input)
            {
                case 'A':
                case 'a':
                    factory = new AdultCuisineFactory();
                    break;

                case 'c':
                case 'C':
                    factory = new KidCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();
            }
            Console.WriteLine();
            Console.WriteLine($"Menu: {factory.GetType().Name}");
            Console.WriteLine($"Sandwich: {factory.CreateSandwich().GetType().Name}");
            Console.WriteLine($"Dessert: {factory.CreateDessert().GetType().Name}");
        }
    }
}
