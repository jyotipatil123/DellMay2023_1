//using System;
//using System.Collections.Generic;

//namespace creational_design_pattern
//{
//     class Program
//    {
//        static void Main(string[] args)
//        {
//           // abstract factory pattern 

//            mykitchen obj = new mykitchen();
//            obj.createitems();

//            List<kitchenitem> items = obj.getitems();

//            foreach (kitchenitem item in items)
//            {
//                Console.WriteLine(item.print());
//            }

//            // singleton pattern 
      
//            thisapplication app1 = thisapplication.Instance();
//            app1.setname("App1");
//            Console.WriteLine(app1.getname());
            
//            thisapplication app2 = thisapplication.Instance();
//            app2.setname("App2");
//            Console.WriteLine(app2.getname());

//            Console.WriteLine(app1.getname()+"       "+ app2.getname());

//            // prototype design pattern
//            bookingtype seat1 = new booking();
//            seat1.setSeat("12A");
//            Console.WriteLine( seat1.getseat());

//            bookingtype seat2 = seat1.clone();
//            Console.WriteLine(seat2.getseat());

//            Console.ReadLine();
//        }
//    }
//}
//abstract class kitchenitem {   public abstract string print(); }
//class spoon : kitchenitem {    public override string print()   { return "spoon";   } }
//class pan : kitchenitem {      public override string print()   { return "pan"; } }
//class kettle : kitchenitem {   public override string print()  { return ("kettle");  } }
//class glass : kitchenitem{     public override string print()    {  return ("glass");   }}

//abstract class kitchen
//{
//    protected List<kitchenitem> mitems= new List<kitchenitem>();    

//    public List<kitchenitem> getitems()
//    {
//        return mitems;  
//    }

//    public abstract void createitems();
//}

//class mykitchen : kitchen
//{
//    public override void createitems()
//    {
//       mitems.Add(new spoon());
//       mitems.Add(new pan());
//       mitems.Add(new kettle());
//    }
//}

//class thisapplication
//{
//    private static thisapplication _instance;

//    private string name = "This application";
        
//    public thisapplication()
//    {   
//        Console.WriteLine("welcome");
//    }
//    public static thisapplication Instance()
//    {
//        if (_instance == null)
//        {
//            _instance = new thisapplication();
//        }
//        return _instance;
//    }
//    public string getname() { return name; }
//    public void setname(string n) { name = n; }
//}

//public abstract class bookingtype
//{
//    private string mseat;
//    public void setSeat(string s) { mseat = s; }
//    public abstract bookingtype clone();
//    public string getseat() {  return mseat; }
//}

//class booking : bookingtype
//{
//    public override bookingtype clone()
//    {
//        return this.MemberwiseClone() as bookingtype;
//    }
//}