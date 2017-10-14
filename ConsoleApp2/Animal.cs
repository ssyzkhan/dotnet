using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{

    struct Customers
    {
        private string name;
        private double balance;
        private int id;
        public void createCust(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }
        public void showCust()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("Id " + id);
        }
    }

    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }
    class Animal
    {
        

        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
        }
        public Animal(double height,double weight,string name,string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
        }
        static int numOfAnimals = 0;
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }
        public string toString()
        {
            return String.Format("{0}is{1} inches tall, weight {2} lbs and likes to say {3}", name, height, weight, sound);
        }
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }
        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }
    }
}
