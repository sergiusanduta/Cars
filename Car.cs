﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public  class Car 
    {
        public string _make;
        public string _model;
        public int _year;
        public int _price;

        public Car(string make, string model, int year, int price)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
        }

        public string GetCarInfo()
        {
            string carInfo = _make + "|" + _model + "|" + _year + "|" + _price;
            return carInfo;
        }
    }    

}
