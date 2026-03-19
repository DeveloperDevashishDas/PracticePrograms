using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace PracticePrograms
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            double finalAmount = 500;
            return finalAmount;
        }
     
    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }

    public class ProposedInvoice : Invoice 
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 100;
        }
    }

 
     public class TwoSum 
     {
      
        static void Main()
         {
            Invoice invoice = new FinalInvoice();
            Invoice pi = new ProposedInvoice();
            double fiam = invoice.GetInvoiceDiscount(1000);
            double pInvoice = invoice.GetInvoiceDiscount(2000);
            double rInvoice = invoice.GetInvoiceDiscount(3000);
           
            Console.WriteLine("Hello Bangkok Japan");
        }
        
    }
}

