using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep
{
    class Produkt
    {
        public string BarCode;
        public string Name;
        public double Price;

        public Produkt(string barCode, string name, double price)
        {
            BarCode = barCode;
            Name = name;
            Price = price;
        }
    }
}



// 	BarCode: Reprezentuje kod kreskowy 
//	Name: Nazwa produktu
//	Price: Cena jednostkowa produktu
//	Quantity: Ilość produktu w magazynie
