using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_ElectricBill_
{
    internal class ElectricBill
    {
        static void Main(string[] args)
        {
            int units;
            string billType;
            Console.WriteLine("Enter the amount of units: ");
            units = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter the type of bill (residential/commercial)");
            billType = Console.ReadLine();

            if(billType == "residential")
            {
                Residential r1 = new Residential();
                r1.Bill();
            }

            else if(billType == "commercial")
            {
                Commercial c1 = new Commercial();
                c1.Bill();
            }

            Console.ReadLine();

        }
    }

    class CalculateBill
    {
        protected int units;
        protected string billType;

        protected CalculateBill() { }
        CalculateBill(int units, string billType)
        {
            this.units = units;
            this.billType = billType;
        }
    }

    class Residential : CalculateBill
    {
        double bill_Amt = 0;

        public void Bill()
        {
            if (units <= 100)
            {
                bill_Amt = (units * 5);
            }
            else if (units <= 200)
            {
                bill_Amt = (100 * 5) + (units - 100) * 17;
            }
            else if (units <= 500)
            {
                bill_Amt = (100 * 5) + (100 * 17) + (units - 200) * 23;
            }
            else if (units > 500)
            {
                bill_Amt = (100 * 5) + (100 * 17) + (300 * 23) + (units - 500) * 69;
            }
            else
            {
                Console.WriteLine("No value");
            }
            bill_Amt = bill_Amt + (bill_Amt * 0.13);
            Console.WriteLine(bill_Amt);
        }
    }

    class Commercial : CalculateBill
    {
        double bill_Amt = 0;

        public void Bill()
        {
            if (units <= 100)
            {
                bill_Amt = (units * 8);
            }
            else if (units <= 200)
            {
                bill_Amt = (100 * 8) + (units - 100) * 21;
            }
            else if (units <= 500)
            {
                bill_Amt = (100 * 8) + (100 * 21) + (units - 200) * 23;
            }
            else if (units > 500)
            {
                bill_Amt = (100 * 8) + (100 * 21) + (300 * 23) + (units - 500) * 79;
            }
            else
            {
                Console.WriteLine("No value");
            }
            bill_Amt = bill_Amt + (bill_Amt * 0.17);
            Console.WriteLine(bill_Amt);
        }
    }
}
