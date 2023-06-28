// behavioural pattern
//observer pattern

using System;
using System.Collections.Generic;

namespace A
{
    class program
    {
        static void Main(string[] args)
        {
            //observer pattern 
            //Dell dell = new Dell("Dell", 200.0M);

            //dell.addWathcer(new person("Nischal", dell));
            //dell.addWathcer(new person("Anurag", dell));
            //dell.addWathcer(new person("Shriram", dell));

            //Console.WriteLine(dell.setPrice(210.0M));

            // template method pattern
            //Console.WriteLine("Car :  ");
            //transport car1 = new car();
            //Console.WriteLine(car1.run());

            //Console.WriteLine();

            //Console.WriteLine("Plane :");
            //transport plane1= new plane();
            //Console.WriteLine(plane1.run());

            // strategy pattern 

            Console.WriteLine("Strategy pattern : ");
            calculate cal1= new calculate();    
            cal1.setNumber(90);

            cal1.setDouble(new Addition());
            Console.WriteLine(cal1.doDouble());

            cal1.setDouble(new multiply());
            Console.WriteLine(cal1.doDouble()); 

            Console.ReadLine();
        }
        abstract class Double  {  public abstract int doSum(int a);  }
        class Addition : Double 
        {
            public override int doSum(int a)     {      return a + a;  }
        }
        class multiply : Double
        {
            public override int doSum(int a)    {      return a * 2;  }
        }

        class calculate
        {
            private int number;
            private Double _double;   //abstract
            public void setDouble(Double d)   {     _double = d;    }
            public void setNumber(int a)      {      number = a;    }
            public int doDouble()             {     return _double.doSum(number);    }

        }
    }    
   
}



// observer pattern 
//abstract class StockType
//{
//    private string name;
//    private decimal price;

//    private List<Watcher> wathcers = new List<Watcher>();
//    public StockType(string n, decimal p)
//    {
//        name = n;
//        price = p;
//    }

//    public void addWathcer(Watcher w)
//    {
//        wathcers.Add(w);
//    }

//    public void removeWatcher(Watcher w)
//    {
//        wathcers.Remove(w);
//    }

//    public void sendNotification()
//    {
//        foreach (Watcher w in wathcers)
//        {
//            w.notify(this);
//        }
//    }

//    public string setPrice(decimal p)
//    {
//        this.price = p;
//        sendNotification();
//        return "Price change to :" + p.ToString();
//    }

//    public string getName() { return name; }    
//    public decimal getPrice() { return price; }
//}
//interface Watcher
//{
//    void notify(StockType st);
//}
//class Dell : StockType
//{
//    public Dell(string name, decimal price) 
//        : base(name,price)
//    {

//    }
//}
//class person : Watcher
//{
//    private string name;
//    private Dell dell;

//    public person(string name, Dell d)
//    {
//        this.name = name;
//        dell = d;
//    }

//    public void notify(StockType st) 
//    {
//        Console.WriteLine("Stock :"+st.getName()+ "Price is now : "+
//            st.getPrice());
//    }
//}


// template method pattern 
//public abstract class transport
//{
//    protected string name;
//    public abstract string startengine();
//    public abstract string moveforward();
//    public abstract string stopengine();

//    public string run()
//    {
//        string val = "";
//        val += startengine();
//        val += "\n";
//        val += moveforward();
//        val += "\n";
//        val += stopengine();

//        return val;
//    }
//}
//public class car : transport
//{
//    public override string moveforward()
//    {
//        return "Turn key in ignition";
//    }

//    public override string startengine()
//    {
//        return "Put in gear";
//    }

//    public override string stopengine()
//    {
//        return "Put gear in neutral";
//    }
//}


//public class plane : transport
//{
//    public override string moveforward()
//    {
//        return "start Engine";
//    }

//    public override string startengine()
//    {
//        return "Pull yoke back";
//    }

//    public override string stopengine()
//    {
//        return "Put flaps down";
//    }
//}