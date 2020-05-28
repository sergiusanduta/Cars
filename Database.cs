using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public class Database
    {
        private string path = @"C:\Users\WindowsPC\Documents\DatabaseCar.txt";
       
        
        public void SaveCar(Car car)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                string carInfo = car.GetCarInfo();
                sw.WriteLine(carInfo);
            }
        }
    }
}

            //TODO : Save car properties/info in a text file
            // Honda | Civic | 2015 | 15000
            // BMW | X7 | 2002 | 5000