using Session01.Domain.Entities.Customers;
using Session01.Domain.Entities.Goods;
using Session01.Domain.Entities.Salesmans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session01.Domain.Entities.Orders
{
    public class Order
    {
        private int _quantity;
        private int _price;
        private int _totalPrice;
        public int OrderId { get; set; }
        public Good Good { get; set; }
        public Salesman Salesman { get; set; }
        public Customer Customer { get; set; }

        public int Quantity { get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
                updateTotalPrice();
            }
        }


        public int Price
        {     
            get
            {
                return _price;
            }

            set
            {
                _price = value;
                updateTotalPrice();
            }
        }
        public int TotalPrice { get {

                return _totalPrice;
            }
            private set
            {
                _totalPrice = value;
            }
        }


        private void updateTotalPrice()
        {
            _totalPrice = Quantity * Price;
        }



    }
}
