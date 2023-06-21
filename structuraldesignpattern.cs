using System;
using System.Collections.Generic;
using System.Text;

namespace creational_design_pattern
{
     class structuraldesignpattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Adapter design pattern : ");

            india obj = new india(new workabroad());
            Console.WriteLine(obj.startwork());

            //====================================================================

            Console.WriteLine("Bridge pattern :");

            invoice invoice = new invoice();

            invoice.setcustomer("ICICI Bank");
            invoice.setid("ABC123");

            invoiceitem item1 = new invoiceitem();
            item1.setvalues("item 1", 1, 12.5M, 65.35M);

            invoice.additem(item1);

            invoiceitem item2 = new invoiceitem();
            item2.setvalues("item 2", 10, 14.5M, 75.35M);

            invoice.additem(item2);

            invoiceitem item3 = new invoiceitem();
            item3.setvalues("item 3", 12, 18.5M, 76.35M);

            invoice.additem(item3);

            Console.WriteLine("Invoice total =" + invoice.gettotal()) ;






            Console.ReadLine();
        }
    }

    interface IWorkAbroad   {     string dowork();   }
    class india
    {
        private readonly IWorkAbroad _workabroad;
        public india(IWorkAbroad work)
        {
            _workabroad = work;
        }
        public string startwork()
        {
            return _workabroad.dowork();
        }       
    }
    class china
    {
           public string workhere()
           {
               return "you are working in china";
           }
    }

    class workabroad : IWorkAbroad
    {
        readonly china _china = new china();
        public string dowork()
        {
            return _china.workhere();
        }
    }

    abstract class InvoiceItemType
    {
        protected string name;
        protected int qty;
        protected decimal rate;
        protected decimal price;

        public abstract decimal getprice();
        public abstract string getname();
        public abstract int getqty();
        public abstract decimal getrate();
        public abstract void setvalues(string name, int qty, decimal rate, decimal price);
    }

    class invoiceitem : InvoiceItemType
    {
        public override string getname()   {     return name;  }
        public override decimal getprice() {      return price;  }
        public override int getqty()       {       return qty;    }
        public override decimal getrate()   {       return rate; }

        public override void setvalues(string name, int qty, decimal rate, decimal price)
        {
            this.name=name;
            this.qty=qty;
            this.rate=rate;
            this.price = price;
        }
    }

    abstract class InvoiceType
    {
        protected string id;
        protected string customer;
        protected List<InvoiceItemType> _items;

        public abstract void additem(InvoiceItemType item);
        public abstract void setcustomer(string name);
        public abstract void setid(string id);
        public abstract List<InvoiceItemType> getItems();
        public abstract decimal gettotal();
    }

    class invoice : InvoiceType
    {
        public invoice()     {           _items= new List<InvoiceItemType> ();   }
        public override void additem(InvoiceItemType item)
        {
            _items.Add(item);
        }

        public override List<InvoiceItemType> getItems()
        {
            return _items;
        }

        public override decimal gettotal()
        {
            decimal total = 0;
            foreach (InvoiceItemType i  in _items)
            {
                total += i.getprice();
            }
            return total;
        }

        public override void setcustomer(string name)
        {
          this.customer= name;  
        }

        public override void setid(string id)
        {
          this.id=id;
        }
    }

    interface IBank
    {
        string deposit();
        string withdraw();
        decimal getbalance();
    }

    class bank
    {
        public string deposit() { return "deposited"; }
        public string withdraw() { return "withdraw"; }
        public string getbalance() { return "5000"; }

    }

    class bankproxy
    {
        private bank _bank= new bank();

        public string deposit() { return _bank.deposit(); }
        public string withdraw() { return _bank.withdraw(); }
        public string getbalance() { return _bank.getbalance(); }

    }
}
