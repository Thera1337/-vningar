using System;
using System.Threading;
using System.Collections.Generic;

namespace Boutique
{
    class Program
    {
        static int Choise;
        static int TotalPrice;
        static List<Plagg> Butik = new List<Plagg>();
        static List<Plagg> ShoppingCart = new List<Plagg>();
        static void Main(string[] args)
        {
            Admin();
            Console.Clear();
            while (true)
            {
                PrintBoutique();
                Boutique();
                Thread.Sleep(2000);
                Console.SetCursorPosition(0, 0);
            }
        }
        static void Admin()
        {
            Console.WriteLine("Ange hur många plagg du vill lägga till: ");
            int antal = int.Parse(Console.ReadLine());

            for (int i = 0; i < antal; i++)
            {
                //Plagg plagg = default;

                Console.WriteLine("Välj vilken sorts plagg du vill lägga till: ");
                Console.WriteLine("[1] Pants");
                Console.WriteLine("[2] Shirt");
                Console.WriteLine("[3] Socks");
                Console.WriteLine("[4] Scarf");
                int type = int.Parse(Console.ReadLine());
                //plagg.Kind = Enum.GetName(typeof(Kind), type);
                //plagg.Kind = (Type)type;

                Console.WriteLine("Välj storlek på plagget: ");
                Console.WriteLine("[1] XS");
                Console.WriteLine("[2] S");
                Console.WriteLine("[3] M");
                Console.WriteLine("[4] L");
                Console.WriteLine("[5] XL");
                int size = int.Parse(Console.ReadLine());
                //plagg.Size = Enum.GetName(typeof(Size), size);
                //plagg.Size = (Sizes)size;

                Console.WriteLine("Välj färg på plagget: ");
                Console.WriteLine("[1] Blue");
                Console.WriteLine("[2] Green");
                Console.WriteLine("[3] Black");
                Console.WriteLine("[4] White");
                int color = int.Parse(Console.ReadLine());
                //plagg.Color = Enum.GetName(typeof(Color), color);
                //plagg.Color = (Colors)color;

                Console.WriteLine("Välj pris på plagget: ");
                Console.WriteLine("[100] One Hundred");
                Console.WriteLine("[200] Two Hundred");
                Console.WriteLine("[300] Three Hundred");
                Console.WriteLine("[400] Four Hundred");
                int price = int.Parse(Console.ReadLine());
                //plagg.Price = Enum.GetName(typeof(Price), price);
                //plagg.Price = (Prices)price;

                Butik.Add(new Plagg(type, size, color, price));
            }
        }
        static void PrintBoutique()
        {
            int i = 0;
            foreach (Plagg plagg in Butik)
            {
                if (i == Choise)
                {
                    Console.WriteLine($"---> Plagg: {plagg.Kind}, Färg: {plagg.Color}, Storlek: {plagg.Size}, Pris: {plagg.Price}");
                }
                else
                {
                    Console.WriteLine($"Plagg: {plagg.Kind}, Färg: {plagg.Color}, Storlek: {plagg.Size}, Pris: {plagg.Price}");

                }
                i++;
            }
            Console.WriteLine("Varukorg:");
            foreach (Plagg plagg1 in ShoppingCart)
            {
                Console.WriteLine($"Plagg: {plagg1.Kind}, Pris: {plagg1.Price}");
                TotalPrice += (int)plagg1.Price;
            }
        }
        static void Boutique()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case 'a':
                    Choise--;
                    if (Choise < 0)
                    {
                        Choise = Butik.Count - 1;
                    }
                    break;
                case 'z':
                    Choise++;
                    if (Choise == Butik.Count)
                    {
                        Choise = 0;
                    }
                    break;
                case '\r':
                    ShoppingCart.Add(Butik[Choise]);
                    break;
                default:
                    break;
            }
        }
        struct Plagg
        {
            public Type Kind { get; set; }
            public Sizes Size { get; set; }
            public Colors Color { get; set; }
            public Prices Price { get; set; }

            public Plagg(int kind, int size, int color, int price)
            {
                Kind = (Type)kind;
                Size = (Sizes)size;
                Color = (Colors)color;
                Price = (Prices)price;
            }
        }
        enum Type
        {
            Pants = 1,
            Shirt,
            Socks,
            Scarf
        }
        enum Sizes
        {
            XS = 1,
            S,
            M,
            L,
            XL,
        }
        enum Colors
        {
            Blue = 1,
            Green,
            Black,
            White
        }
        enum Prices
        {
            OneHundred = 100,
            TwoHundred = 200,
            ThreeHundred = 300,
            FourHundred= 400
        }
    }
}
