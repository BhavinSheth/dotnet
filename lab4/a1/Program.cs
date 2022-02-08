using System;
namespace code
{

    class TimePeriod
    {
        private double seconds;

        public double hours
        {
            get { return seconds / 3600; }
            set
            {
                if (value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(
                          $"{nameof(value)} must be between 0 and 24.");
                seconds = value * 3600;
            }
        }
    }

    class Person
    {
        private String firstName;
        private String lastName;
        public Person(String first, String last)
        {
            firstName = first;
            lastName = last;
        }
        public String name => $"{firstName} {lastName}";
    }

    class SalesItem
    {
        private String item;
        private int amt;
        public SalesItem(String item, int amt)
        {
            this.item = item;
            this.amt = amt;
        }
        public string Name
        {
            get => item;
            set => item = value;
        }

        public int Price
        {
            get => amt;
            set => amt = value;
        }
    }

    public class SaleItem
    {
        public string Name
        { get; set; }

        public decimal Price
        { get; set; }
    }

    static class Program
    {
        public static void Main(String[] st)
        {
            // 1st code
            TimePeriod t = new TimePeriod();
            t.hours = 21;
            Console.WriteLine($"time in hours : {t.hours}");

            // 2nd code\
            var p = new Person("bhavin", "sheth");
            Console.WriteLine(p.name);

            // 3rd code
            var item = new SalesItem("shoes", 144);
            Console.WriteLine($"{item.Name} sells for {item.Price}");

            // 4th code
            var item1 = new SaleItem { Name = "Shoes", Price = 19.95m };
            Console.WriteLine($"{item1.Name}: sells for {item1.Price}");


        }
    }
}