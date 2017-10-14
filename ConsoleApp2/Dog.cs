using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dog:Animal
    {
        public string favFood { get; set; }
        public Dog() : base()
        {
            this.favFood = "No favorite Food";
        }
        public Dog(double height,double weight,string name, string sound,string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }
        public string toString()
        {
            return String.Format("{0}is{1} inches tall, weight {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound,favFood);
        }
    }
}
