using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class Product
    {

        public Product (string name, string price, int quanty)
        {
            Name = name;
            Price = price;  
            Quantity = quanty;
        }



        public string Name;
        public string Price;
        public int Quantity;

        public string GetName   ( )
        {
            return Name;
        }
        public string GetPrice ( )
        {
            return Price;
        }
        public int GetQuantity ( )
        {
            return Quantity;
        }

        public void StetName (string nume)
        {
            Name = nume;
        }

        public void SetSetPrice (string pret) {

            Price = pret;
                }
        public void SetQuantity (int cantitate)
        {
            Quantity = cantitate;
        }



    }
}
