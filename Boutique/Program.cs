using System;
using System.Collections.Generic;

namespace Boutique
{
    class Program
    {
        static List<Plagg> Butik = new List<Plagg>();
        static List<Plagg> ShoppingCart = new List<Plagg>();
        static void Main(string[] args)
        {
            Admin();
        }
        static void Admin()
        {
            Console.WriteLine("Ange hur många plagg du vill lägga till: ");
            int antal = int.Parse(Console.ReadLine());

            for (int i = 0; i < antal; i++)
            {
                Plagg plagg = default;

                Console.WriteLine("Välj vilken sorts plagg du vill lägga till: ");
                Console.WriteLine("[1] Pants");
                Console.WriteLine("[2] Shirt");
                Console.WriteLine("[3] Socks");
                Console.WriteLine("[4] Scarf");
                int type = int.Parse(Console.ReadLine());
                plagg.Type = Enum.GetName(typeof(Type), type);
                //plagg.Type2 = (Type)2;

                Console.WriteLine("Välj storlek på plagget: ");
                Console.WriteLine("[1] XS");
                Console.WriteLine("[2] S");
                Console.WriteLine("[3] M");
                Console.WriteLine("[4] L");
                Console.WriteLine("[5] XL");
                int size = int.Parse(Console.ReadLine());
                plagg.Size = Enum.GetName(typeof(Size), size);

                Console.WriteLine("Välj färg på plagget: ");
                Console.WriteLine("[1] Blue");
                Console.WriteLine("[2] Green");
                Console.WriteLine("[3] Black");
                Console.WriteLine("[4] White");
                int color = int.Parse(Console.ReadLine());
                plagg.Color = Enum.GetName(typeof(Color), color);

                Console.WriteLine("Välj pris på plagget: ");
                Console.WriteLine("[1] One Hundred");
                Console.WriteLine("[2] Two Hundred");
                Console.WriteLine("[3] Three Hundred");
                Console.WriteLine("[4] Four Hundred");
                int price = int.Parse(Console.ReadLine());
                plagg.Price = Enum.GetName(typeof(Price), price);

                Butik.Add(plagg);
            }
        }
        struct Plagg
        {
            public string Type { get; set; }
            //public Type Type2 { get; set; }
            public string Size { get; set; }
            public string Color { get; set; }
            public string Price { get; set; }

            public Plagg(string type, string size, string color, string price)
            {
                Type = type;
                Size = size;
                Color = color;
                Price = price;
            }
        }
        enum Type
        {
            Pants = 1,
            Shirt,
            Socks,
            Scarf
        }
        enum Size
        {
            XS = 1,
            S,
            M,
            L,
            XL,
        }
        enum Color
        {
            Blue = 1,
            Green,
            Black,
            White
        }
        enum Price
        {
            OneHundred = 1,
            TwoHundred,
            ThreeHundred,
            FourHundred
        }
    }
}
