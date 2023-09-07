using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;

        //setter methods
        public void SetId(int id)
        { _id = id; }
        public void SetName(string name) 
        { _name = name; }
        public void SetPrice(double price) 
        { _price = price; }
        public void SetDiscountPercent(double discountPercent)
        { _discountPercent = discountPercent; }

        //getter methods
        public int GetId() 
        { return _id; }
        public string GetName()
        { return _name; }
        public double GetPrice()
        { return _price; }
        public double GetDiscountPercent()
        { return _discountPercent; }
        public double DiscountCost()
        {
            double discountPrice = _price * (_discountPercent / 100);
            return _price - discountPrice;
        }
    }
}
