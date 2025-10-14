using System;
using System.Collections.Generic;

// --- Base Interfaces ---
interface IPizza
{
    string Name { get; }
    void Prepare();
    void Bake();
    void Box();
}

interface IIngredient
{
    string Name { get; }
}

// --- Ingredient Implementations ---
class Dough : IIngredient
{
    public string Name { get; }
    public Dough(string name) => Name = name;
}

class Sauce : IIngredient
{
    public string Name { get; }
    public Sauce(string name) => Name = name;
}

class Topping : IIngredient
{
    public string Name { get; }
    public Topping(string name) => Name = name;
}

// --- Abstract Pizza (Composition Core) ---
abstract class BasePizza : IPizza
{
    public abstract string Name { get; }
    protected Dough dough;
    protected Sauce sauce;
    protected List<Topping> toppings = new List<Topping>();

    public void Bake() => Console.WriteLine($"Baking {Name} for 15 minutes...");
    public void Box() => Console.WriteLine($"Boxing {Name} in eco-friendly packaging.\n");

    public virtual void Prepare()
    {
        Console.WriteLine($"\nPreparing {Name}...");
        Console.WriteLine($"  Dough: {dough.Name}");
        Console.WriteLine($"  Sauce: {sauce.Name}");
        Console.WriteLine("  Toppings:");
        foreach (var topping in toppings)
            Console.WriteLine($"    • {topping.Name}");
    }
}

// --- Specific Pizza Types (Closed for modification, open for extension) ---
class ChickenPizza : BasePizza
{
    public override string Name => "Chicken Pizza";

    public ChickenPizza()
    {
        dough = new Dough("Thin Crust");
        sauce = new Sauce("Tomato Basil");
        toppings.Add(new Topping("Grilled Chicken"));
        toppings.Add(new Topping("Mozzarella"));
        toppings.Add(new Topping("Onions"));
    }
}

class MushroomPizza : BasePizza
{
    public override string Name => "Mushroom Pizza";

    public MushroomPizza()
    {
        dough = new Dough("Hand-Tossed");
        sauce = new Sauce("Creamy Garlic");
        toppings.Add(new Topping("Mushrooms"));
        toppings.Add(new Topping("Cheese"));
        toppings.Add(new Topping("Garlic"));
    }
}

class PepperoniPizza : BasePizza
{
    public override string Name => "Pepperoni Pizza";

    public PepperoniPizza()
    {
        dough = new Dough("Classic Crust");
        sauce = new Sauce("Spicy Tomato");
        toppings.Add(new Topping("Pepperoni"));
        toppings.Add(new Topping("Mozzarella"));
    }
}

// --- Factory Pattern for Scalable Creation ---
enum PizzaType
{
    Chicken,
    Mushroom,
    Pepperoni
}

static class PizzaFactory
{
public static IPizza CreatePizza(PizzaType type)
{
    switch (type)
    {
        case PizzaType.Chicken:
            return new ChickenPizza();

        case PizzaType.Mushroom:
            return new MushroomPizza();

        case PizzaType.Pepperoni:
            return new PepperoniPizza();

        default:
            throw new ArgumentException("Invalid pizza type");
    }
}

}

// --- Usage Example ---
class Program
{
    static void Main()
    {
        var pizzas = new List<IPizza>
        {
            PizzaFactory.CreatePizza(PizzaType.Chicken),
            PizzaFactory.CreatePizza(PizzaType.Mushroom),
            PizzaFactory.CreatePizza(PizzaType.Pepperoni)
        };

        foreach (var pizza in pizzas)
        {
            pizza.Prepare();
            pizza.Bake();
            pizza.Box();
        }
    }
}
