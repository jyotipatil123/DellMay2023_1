//////////////////constructors demo
////////////////using System;

////////////////class india
////////////////{
////////////////    public india()   //default constructor
////////////////    {
////////////////        Console.WriteLine("default constructor is invoked ");
////////////////    }
////////////////    public india(string city)  //parameterized constructor
////////////////    {
////////////////       Console.WriteLine("India has so many cities "+city);
////////////////    }
////////////////}


////////////////class MyClass
////////////////{
////////////////    static void Main(string[] args)
////////////////    {
////////////////       india obj= new india();           //default contstructor

////////////////        india obj1 = new india("Gujarat");  // parameterized constructor

////////////////        Console.ReadLine();
////////////////    }
////////////////}

////////////////=================================================================
////////////////constructors demo
//////////////using System;

//////////////class india
//////////////{
//////////////    public india()   //default constructor
//////////////    {
//////////////        Console.WriteLine("india default constructor is invoked ");
//////////////    }
//////////////    public india(string city)  //parameterized constructor
//////////////    {
//////////////        Console.WriteLine("india -parameterized constructor --India has so many cities " + city);
//////////////    }
//////////////}

//////////////class UK : india
//////////////{
//////////////    public UK()
//////////////    {
//////////////        Console.WriteLine("UK constructor is invoked");
//////////////    }
//////////////    public UK(string city1)
//////////////    {
//////////////        Console.WriteLine("UK parameterized constructor is inovked --city 1 is : "+city1);
//////////////    }
//////////////}


//////////////class MyClass
//////////////{
//////////////    static void Main(string[] args)
//////////////    {
//////////////        //india obj = new india();           //default contstructor

//////////////        //india obj1 = new india("Gujarat");  // parameterized constructor

//////////////        UK obj1= new UK();

//////////////        Console.WriteLine();
//////////////        Console.WriteLine();

//////////////        UK obj2 = new UK("Delhi"); 


//////////////        Console.ReadLine();
//////////////    }
//////////////}


////////////using System;

////////////class computer
////////////{
////////////    string name="dell";
////////////    string make="2000";

////////////    public computer()
////////////    {
////////////        name = "Lenovo";
////////////        make = "1995";
////////////    }
////////////    public void display()
////////////    {
////////////        Console.WriteLine("System name is : "+name);
////////////        Console.WriteLine("System make is : " + make);
////////////    }

////////////}

////////////class MyClass
////////////{
////////////    static void Main(string[] args)
////////////    {
////////////        computer obj= new computer();
////////////        obj.display();

////////////        Console.ReadLine();
////////////    }
////////////}

//////////// constructor demo

////////////static constructor

//////////using System;

//////////class test
//////////{
//////////    private static int id = 10;
//////////    public static int ID
//////////    {
//////////        get { return id; }
//////////    }

//////////    public test()
//////////    {
//////////        Console.WriteLine(  "default constructor of test");
//////////    }
//////////    static test()    // static constructor 
//////////    {
//////////        if (test.id > 10)
//////////            id = 100;
//////////        else
//////////            id = 200;

//////////        Console.WriteLine("construcotr id is : " + id);
//////////    }

//////////    public static void print()
//////////    {
//////////        Console.WriteLine("Test id is : " + id);
//////////    }

//////////}


//////////class MyClass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        //Console.WriteLine(test.ID );
//////////        //test.print();

//////////         test obj= new test();

//////////         test.print();   

//////////      //  print();

//////////        Console.ReadLine();
//////////    }
//////////}

////////// oops 
////////// polymorphism 
////////// function overloading  -- same function name with different parameters 

//////////using System;

//////////class bank
//////////{
//////////    int balance = 1000;
//////////    public void credit()
//////////    {
//////////        Console.WriteLine("credit() is called");
//////////    }
//////////    public void credit(int amt)
//////////    {
//////////        balance += amt;
//////////        Console.WriteLine("credited amount is : "+amt);
//////////    }
//////////    public void credit(int accno, int amt)
//////////    {
//////////        balance += amt;
//////////        Console.WriteLine("credited amount is : " + amt+ accno);
//////////    }

//////////    public void credit(int accno, int amt, string name)
//////////    {
//////////        balance += amt;
//////////        Console.WriteLine("credited amount is : " + accno+amt+name);
//////////    }


//////////}

//////////class MyClass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        //bank obj= new bank();
//////////        //obj.credit();
//////////        //obj.credit(1000);

//////////        bank obj = new bank();
//////////        obj.credit();
//////////        obj.credit(2000);
//////////        obj.credit(123456, 8900);
//////////        obj.credit(77777, 9000, "Anvitha");

//////////        Console.ReadLine();
//////////    }
//////////}

//////////function overriding 

//////////using System;

//////////class canara
//////////{
//////////    int interestrate = 8;
//////////    public virtual void loan()
//////////    {
//////////        Console.WriteLine("Interest rate from Canara bank is  :"+interestrate);
//////////    }

//////////    public void function1()
//////////    {
//////////        Console.WriteLine("function1 from canara");
//////////    }
//////////}

//////////class icici :canara
//////////{
//////////    int interestrate = 8;
//////////    public override void loan()
//////////    {
//////////        base.loan();

//////////        Console.WriteLine("Interest rate from Icici bank is :" + interestrate);
//////////    }

//////////    public void function1()
//////////    {
//////////        base.function1();
//////////        Console.WriteLine("function1 from icici");
//////////    }
//////////}

//////////class MyClass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        icici obj = new icici();
//////////        obj.loan();

//////////        obj.function1();

//////////        Console.ReadLine();
//////////    }
//////////}


//////////using System;

//////////class canara
//////////{
//////////    public void function1()
//////////    {
//////////        Console.WriteLine("function1 from canara");
//////////    }
//////////}

//////////class icici : canara
//////////{
//////////    public new void function1()
//////////    {
//////////        Console.WriteLine("function1 from icici");
//////////    }
//////////}

//////////class MyClass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////       icici obj= new icici();
//////////       obj.function1();


//////////        Console.ReadLine();
//////////    }
//////////}

////////// interfaces --contract --class and functions
////////// function signatures  no function body
////////// implementation 

//////////using System;

//////////interface IVehicle
//////////{
//////////    public void start();
//////////    public void stop();

//////////}

//////////interface ICar             //declare 
//////////{
//////////    public void color();    //function signatures 
//////////    public void fuel();
//////////}

//////////class MyClass : IVehicle, ICar
//////////{
//////////    public void color()
//////////    {
//////////        Console.WriteLine("color is red");
//////////    }

//////////    public void fuel()
//////////    {
//////////        Console.WriteLine("fuel is full ");
//////////    }

//////////    public void start()
//////////    {
//////////        Console.WriteLine("start() is invoked");
//////////    }

//////////    public void stop()
//////////    {
//////////        Console.WriteLine("stop() is invoked");
//////////    }
//////////}
//////////class MyClass1
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        MyClass obj = new MyClass();
//////////        obj.color();
//////////        obj.fuel();
//////////        obj.start();
//////////        obj.stop();

//////////        Console.ReadLine();
//////////    }
//////////}

////////////using System;

////////////class A
////////////{

////////////}
////////////class B
////////////{

////////////}

////////////class C :A 
////////////{

////////////}


//////////// explicit interfaces

//////////using System;

//////////interface IVehicle
//////////{
//////////    void start();
//////////    void stop();

//////////}

//////////interface ICar  : IVehicle   //interface inheritance            //declare 
//////////{
//////////    public void color();    //function signatures 
//////////    public void fuel();
//////////}

//////////class MyClass : IVehicle, ICar
//////////{
//////////    void ICar.color()
//////////    {
//////////        Console.WriteLine("color is red");
//////////    }

//////////    void ICar.fuel()
//////////    {
//////////        Console.WriteLine("fuel is full ");
//////////    }

//////////    void IVehicle.start()
//////////    {
//////////        Console.WriteLine("start() is invoked");
//////////    }

//////////    void IVehicle.stop()
//////////    {
//////////        Console.WriteLine("stop() is invoked");
//////////    }
//////////}
//////////class MyClass1
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        // implicit 
//////////        //MyClass obj = new MyClass();
//////////        //obj.color();
//////////        //obj.fuel();
//////////        //obj.start();
//////////        //obj.stop();

//////////        // explicit 

//////////        IVehicle vehicle = new MyClass();
//////////        vehicle.start();
//////////        vehicle.stop();

//////////        ICar obj = new MyClass();
//////////        obj.color();
//////////        obj.fuel();

//////////        Console.ReadLine();
//////////    }
//////////}


////////////using System;

////////////class vehicle
////////////{

////////////}

////////////class car :vehicle
////////////{


////////////}

////////////class MyClass
////////////{
////////////    static void Main(string[] args)
////////////    {
////////////        vehicle v1 = new car();




////////////        Console.ReadLine();
////////////    }
////////////}


////////// abstract class 
////////using System;

////////interface ICar             //declare 
////////{
////////    public void color();    //function signatures 
////////    public void fuel();
////////}
////////public  class animal :ICar
////////{
////////   // public abstract void haircolor();
////////	public void behavior()
////////	{
////////        Console.WriteLine("this displays the animal behaviour");
////////    }
////////    public void eyecolor()
////////    {
////////        Console.WriteLine("this displays the animal eye color : black ");
////////    }

////////    public void color()
////////    {
////////        throw new NotImplementedException();
////////    }

////////    public void fuel()
////////    {
////////        throw new NotImplementedException();
////////    }
////////}

////////public abstract class A : animal
////////{
////////    //public override void haircolor()
////////    //{
////////    //    throw new NotImplementedException();
////////    //}
////////}

////////class B : A { }

////////class MyClass
////////{
////////    static void Main(string[] args)
////////    {
////////      A obj = new B();
////////        obj.color();   //icar
////////        obj.eyecolor();  // abstract class animal 
////////        obj.behavior();  // abstract class 
////////        obj.fuel(); //icar

////////    }
////////}

//////////class tiger : animal1, ICar     // working 
//////////{
//////////    public void legs()
//////////    {
//////////        Console.WriteLine("4 legs for tiger");
//////////    }
//////////    public override void haircolor()
//////////    {
//////////        Console.WriteLine("Tiger hair color is reddish");
//////////    }

//////////    public void color()
//////////    {
//////////        throw new NotImplementedException();
//////////    }

//////////    public void fuel()
//////////    {
//////////        throw new NotImplementedException();
//////////    }
//////////    //public override void behavior()     xxxxxx
//////////    //{
//////////    //    Console.WriteLine( );
//////////    //}


//////////}

//////////class MyClass
//////////{
//////////	static void Main(string[] args)
//////////	{
//////////        tiger obj= new tiger(); 
//////////        obj.legs(); 
//////////        obj.eyecolor();
//////////        obj.behavior();
//////////        obj.haircolor();

//////////		Console.ReadLine();
//////////	}
//////////}
/////////

////////sealed keyword 
////using System;

////sealed class MyClass1
////{
////    public void logic()
////    {

////    }

////    public int id { get; set; }
////}

////////class myclass1 : MyClass
////////{

////////}


////class MyClass
////{
////    static void Main(string[] args)
////    {
////        MyClass1 obj = new MyClass1();
////        obj.logic();

////        obj.id = 1;
////        Console.WriteLine(obj.id);

////    }
////}

//////=====================================================
/////

////jagged arrays : 

//// array inside an array

//// {1, 2,3}
//// {1.2}
//// {1,2,3,4}

//using System;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        int[][] arr = new int[3][];

//        arr[0] = new int[] { 1,2,3 };           //0
//        arr[1] = new int[] { 1, 2, 3,4 };    //1
//        arr[2] = new int[] { 1, 2 };         //2 

//        for (int i = 0; i < arr.Length; i++)
//        {
//            for(int j = 0; j < arr[i].Length;  j++)
//            {
//                Console.Write(arr[i][j]);
//            }
//            Console.WriteLine(  );
//        }

//        Console.ReadLine();

//    }
//}

//----------selection sort

using System;

class MyClass
{
    static void Main(string[] args)
    {
        string[] names = new string[5]
        { 
            "Nischal", 
            "Shriram", 
            "Mokshi", 
            "Aawi", 
            "Abay"
        };

        int n = 5;
        string temp;
        int smallest;

        for (int i = 0; i < n-1; i++)
        {
            smallest = i;
            for (int j = i+1; j < n; j++)
            {
                if (names[j].CompareTo(names[smallest]) < 0)
                {
                    smallest = j;    
                }
            }
            temp = names[smallest];
            names[smallest] = names[i];
            names[i] = temp;    
        }

        Console.WriteLine("selection sort result is : ");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }



    }
}