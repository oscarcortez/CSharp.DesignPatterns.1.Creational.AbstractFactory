# CSharp.DesignPatterns.1.Creational.AbstractFactory

Summary:
Abstract Factory nos permite definir de forma genérica familias de objetos relacionados, dejando las concreciones reales para que esos objetos se implementen según sea necesario.

1. Se crea un "container generico" de "elementos genericos", este container es un abstract class: RecipeFactory
```csharp
public abstract class RecipeFactory
{
    public abstract Sandwich CreateSandwich();

    public abstract Dessert CreateDessert();
}
```
2. Se crean los "contenedores especificos" de "elementos genericos": AdulCuisineFactory, KidCuisineFactory. Que heredan del abstract RecipeFactory
```csharp
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
```
3. Para que los "elementos genericos" sean "genericos" se crean sus clases abstractas de cada elemento: Dessert, Sandwich
```csharp
    public abstract class Dessert
    {
    }
    public abstract class Sandwich
    {
    }
```

4. Ahora se crean los elementos especificos de cada container
  4.1 Para container AdultMenu se crea el sandwich BLT (hereda de sandwich), y el dessert CremeBrulee (hereda de dessert)
```csharp
public class BLT: Sandwich
{
}
public class CremeBrulee : Dessert
{
}
```
  4.2 Para container ChildMenu se crea el sandwich GrilledCheese (hereda de sandwich) y el dessert IceCreamSundae (hereda de dessert)
 ```csharp
public class GrilledCheese : Sandwich 
{
}
public class IceCreamSundae : Dessert
{
}
```
 Notar que los "elementos especificos" se crean cuando se instancia el factory especifico: AdulCuisineFactory, KidCuisineFactory
 ```csharp
 public override Dessert CreateDessert()
{
    return new CremeBrulee();
}

public override Sandwich CreateSandwich()
{
    return new BLT();            
}
 ```
