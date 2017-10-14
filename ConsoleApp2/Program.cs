using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double GetSum(double num1, double num2);
namespace ConsoleApp2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };
            List<int> oddNums = numList.Where(n => n % 2==1).ToList();

            foreach(int num in oddNums)
            {
                Console.WriteLine(num);
            }

            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5+3=" + getSum.Invoke(5, 3));

            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };
            Console.WriteLine("5+10=" + sum(5, 10));

            Animal a = new Animal(15,10,"Spot","Woof");
            Console.WriteLine(a.name,a.sound);
            Console.WriteLine(a.toString());
            Console.WriteLine("{0}-{1}",a.getSum(1.23, 2.42),a.getSum(3,4));
            Dog b = new Dog();
            Console.WriteLine(b.toString());

            Shape rect = new Rectangle(5, 5);

            Console.WriteLine("Rect Area " + rect.area());

            KeyValue<string, string> superman = new KeyValue<string, string>("Field ", "Ruan");
            superman.showData();

            Temperature micTemp = Temperature.Low;
            Console.WriteLine(micTemp);

            Customers bob = new Customers();
            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

            Console.ReadLine();


        }
    }
}
