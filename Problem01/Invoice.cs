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

	class Invoice
	{

        //Initialize the instance variables of the Invoice class
        private string partNumber;
        private string partDescription;
        private int quantity;
		private decimal pricePerItem;


        //Main constructor for the Invoice class that takes all inputted values in the parameter
		public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
		{
			PartNumber = partNumber;
			PartDescription = partDescription;
		    Quantity = quantity;
			PricePerItem = pricePerItem;
		}


        //Implicit property for the part number
        public string PartNumber
        {
            get; set;
        }


        //Implicit property for the part description
        public string PartDescription
		{
            get; set;
        }



        //Property for the quantity
        public int Quantity
		{

			get
			{
                //Return the quantity
				return this.quantity;
			}

			set
			{
                //If the value is less than 0, set the quantity to 0
				if (value < 0)
				{
                    this.quantity = 0;
				}

                //Or else, the quantity is set to the value
                else
                {
                    this.quantity = value;
                }

			}

		}


        //Property for the price per item
		public decimal PricePerItem
		{

			get
			{
                //Return the pricer per item
                return this.pricePerItem;
			}

			set
			{
                //If the value is less than 0.0, set the price per item to 0.0
                if (value < 0.0m)
				{
					this.pricePerItem = 0.0m;
				}

                //Or else, the price per item is set to the value
                else
                {
                    this.pricePerItem = value;
                }

			}

		}

    
        //Returns the invoice amount based on the quantity multiplied by the price per item
        public decimal GetInvoiceAmount()
		{
			return Quantity * PricePerItem;
		}



	}


}
