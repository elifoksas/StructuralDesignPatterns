using System;

namespace Decoratorr
{
    class Decorator
    {
        public class Decoratorr
        {
            static void Main(string[] args)
            {
                IDrink drink = new Coffee();
                Console.WriteLine(drink.Operasyon());
                Console.WriteLine(new coffeDecoratorMilk(drink).Operasyon());
                Console.WriteLine(new coffeDecoratorSugar(drink).Operasyon());
                Console.WriteLine(new coffeDecoratorCream(drink).Operasyon());
                Console.WriteLine(new coffeDecoratorMilk(new coffeDecoratorSugar(drink)).Operasyon());
                Console.WriteLine(new coffeDecoratorMilk(new coffeDecoratorSugar(new coffeDecoratorCream(drink))).Operasyon());

                Console.ReadKey();
            }
            interface IDrink
            {

                string Operasyon();
            }
            class Coffee : IDrink
            {
                private IDrink drink;
                public string Operasyon()
                {
                    return "Coffee";
                }

            }

            class coffeDecoratorMilk : IDrink
            {

                private IDrink drink;

                public coffeDecoratorMilk(IDrink d)
                {
                    drink = d;
                }
                public string Operasyon()
                {
                    string s = drink.Operasyon();
                    s += " with milk";
                    return s;

                }
            }
            class coffeDecoratorSugar : IDrink
            {

                private IDrink drink;

                public coffeDecoratorSugar(IDrink d)
                {
                    drink = d;
                }
                public string Operasyon()
                {
                    string s = drink.Operasyon();
                    s += " with sugar";
                    return s;

                }
            }

            class coffeDecoratorCream : IDrink
            {

                private IDrink drink;

                public coffeDecoratorCream(IDrink d)
                {
                    drink = d;
                }
                public string Operasyon()
                {
                    string s = drink.Operasyon();
                    s += " with cream";
                    return s;

                }
            }



        }
    }
}
