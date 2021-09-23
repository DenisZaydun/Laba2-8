using System;

namespace Лб2__8
{
    class Invoice
    {
        private int account;
        private string customer, provider;

        private string _article;
        private int _quantity, _price;

        public string article;
        public int quantity;

        private double cost, NDS, costWithNDS;

        public Invoice()
        {
            account = 119695197;
            customer = "АТБ";
            provider = "Mars";
        }

        public void Calculations()
        {
            _article = article.ToLower();
            _quantity = quantity;

            if (_article == "snickers" || _article == "1")
            {
                _price = 10;
            }
            else if(_article == "mars" || _article == "2")
            {
                _price = 15;
            }
            else if(_article == "twix" || _article == "3")
            {
                _price = 18;
            }
            
            cost =_price * _quantity;
            cost = Math.Round(cost, 2);

            NDS = cost * 20 / 100;
            NDS = Math.Round(NDS, 2);

            costWithNDS = cost + NDS;
            costWithNDS = Math.Round(costWithNDS, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Вартість: {cost}₴");
            Console.WriteLine($"НДС (20%): {NDS}₴");
            Console.WriteLine($"Вартість з НДС: {costWithNDS}₴");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            Invoice invoice = new Invoice();

            Console.WriteLine("Для замовлення оберіть продукт");
            Console.WriteLine("1. Snickers — 10грн");
            Console.WriteLine("2. Mars — 15грн");
            Console.WriteLine("3. Twix — 18грн\n");
            Console.Write("Ваш вибір: ");
            invoice.article = Console.ReadLine();

            Console.Write("Кількість: ");
            invoice.quantity = int.Parse(Console.ReadLine());

            invoice.Calculations();

            invoice.GetInfo();
        }
    }
}
