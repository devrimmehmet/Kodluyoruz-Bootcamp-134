using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private double Price;
        public void SetPrice(double value) 
        {
            if (value > 0) 
            {
                Price = value;
            }else
            {
                throw new ArgumentException("Fiyat Negatif Olamaz!");
            }
        }
        public double GetPrice() 
        {
            return Price;
        }

        public string Name 
        {
            get { return Name; }
            set { Name = value; } 
        }
        private int stock;


        public int StockCount
        {
            get
            {
                return stock;
            }
            set
            {
                if (value < 0)
                {
                    stock = 0;
                    IsProductFoundInStock = false;
                }
            }
        }
        public bool IsProductFoundInStock { get; private set; }

        public double Discount { get; set; }

        public string Description { get; set; }
    }
}
