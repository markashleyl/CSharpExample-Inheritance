using System;
namespace InheritanceApplication
{
    class Box
    { 
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    
    //Base class Cost of Box
    public interface BoxCost
    {
        int getCost(int area);
    }
    // Derived class
    class Cardboard : Box, BoxCost
    {
        public int getArea()
        {
            return (width * height);
        }
    public int getCost(int area)
    {
        return area * 70;
    }
}
class CardboardTester
{
    static void Main(string[] args)
    {
        Cardboard Card = new Cardboard();
        int area;
        Card.setWidth(7);
        Card.setHeight(10);
        area = Card.getArea();
        //Print the area of the object.
        Console.WriteLine("Total area: {0}", Card.getArea());
        Console.WriteLine("Total box cost: ${0}", Card.getCost(area));
        Console.ReadKey();
    }
  }
}