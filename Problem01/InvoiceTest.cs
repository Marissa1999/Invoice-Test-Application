//ID: 1775227
//Name: Marissa Goncalves
//Assignment 1 - Problem 1: InvoiceTest app

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{

	class InvoiceTest
	{

			static void Main(string[] args)
			{

                //Prompt the user to type the part number
				Console.Write("Please enter the part number: ");
				string number = Console.ReadLine();

                //Prompt the user to type the part description
                Console.Write("Please enter the part description: ");
				string description = Console.ReadLine();

                //Prompt the user to type the quantity
                Console.Write("Please enter the quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Prompt the user to type the price per item
                Console.Write("Please enter the price per item: ");
				decimal price = decimal.Parse(Console.ReadLine());


                //Skip a line
			    Console.WriteLine();
			

                //Create a new object with the inputted values
		     	Invoice invoiceResults = new Invoice(number, description, quantity, price);
			

                //Using string interpolation, display the inputted results in an organized table
		     	Console.WriteLine($"----------------------------------------------------");
		    	Console.WriteLine($"|                    INVOICE                       |");
			    Console.WriteLine($"----------------------------------------------------");
			    Console.WriteLine($"| Part Number      | {invoiceResults.PartNumber,-30}|");
			    Console.WriteLine($"----------------------------------------------------");
			    Console.WriteLine($"| Part Description | {invoiceResults.PartDescription,-30}|");
			    Console.WriteLine($"----------------------------------------------------");
			    Console.WriteLine($"| Quantity         | {invoiceResults.Quantity,-30}|");
			    Console.WriteLine($"----------------------------------------------------");
			    Console.WriteLine($"| Price Per Item   | {invoiceResults.PricePerItem,-30:C}|");
			    Console.WriteLine($"----------------------------------------------------");
			    Console.WriteLine($"| Total Amount     | {invoiceResults.GetInvoiceAmount(),-30:C}|");
			    Console.WriteLine($"----------------------------------------------------");
                Console.WriteLine();

		    }

    }


}
