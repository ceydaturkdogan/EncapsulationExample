using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Cars
    {

        private string _mark;
        private string _type;
        private string _color;
        private double _doorNumber;

        public double DoorNumber
        {
            get
            {
                return _doorNumber;
            }

            set
            {
                if ((value != 2) && (value != 4))
                {
                    _doorNumber = -1;
                }
                else
                {
                    _doorNumber = value;
                }
            }
        }

        public Cars(string mark,string type,string color,double doorNumber)
        {
            _mark = mark;
            _type = type;
            _color = color;
            DoorNumber = doorNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Araba Markası:{_mark}\nAraba Modeli:{_type}\nAraba Rengi:{_color}\nArabanın Kapı Sayısı:{DoorNumber}");
        }

    }
}
