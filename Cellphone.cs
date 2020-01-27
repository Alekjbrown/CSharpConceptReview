﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFileForm
{
    class Cellphone
    {
        //Fields
        private string _brand; //The phone's brand
        private string _model; //The phone's model
        private decimal _price; //Retail price

        //constructor
        public Cellphone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        //Brand property
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        //Model property
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        //Price property
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
