using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Shape
    {
        public abstract double area();
        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
        public interface ShapeItem
        {
            double area();

        }
        
    }
    class Rectangle : Shape
        {
            private double length;
            private double width;
            public Rectangle(double num1,double num2)
            {
            this.length = num1;
            this.width = num2;
            }
            public override double area()
            {
                //throw new NotImplementedException();
                return length * width;
            }
            public static Rectangle operator+(Rectangle rect1,Rectangle rect2)
            {
                double rectLength = rect1.length + rect2.length;
                double rectWidth = rect1.width + rect2.width;
                return new Rectangle(rectLength, rectWidth);
            }
        }
    class KeyValue<Tkey, TValue>
    {
        public Tkey key { get; set; }
        public TValue value { get; set; }
        public KeyValue(Tkey k,TValue v)
        {
            key = k;
            value = v;
        }
        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }
    }
}
