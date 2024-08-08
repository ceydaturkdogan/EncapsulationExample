using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class Cars
    {

        private string _mark; //Marka için tanımlanan field
        private string _type;//Model için tanımlanan field
        private string _color;//Renk için tanımlanan field
        private double _doorNumber;//Kapı sayısı için tanımlanan field

        public double DoorNumber //Kapı sayısını alıp içerisinde kapı sayısı kontrolünü yapabilmek için tanımlanan property
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

        public Cars(string mark,string type,string color,double doorNumber) //nesne oluşturuurken verilerin girilmesini sağlayan yapıcı constructor
        {
            _mark = mark;
            _type = type;
            _color = color;
            DoorNumber = doorNumber;
        }

        public void DisplayInfo() //Bilgileri display eden method
        {
            Console.WriteLine($"Araba Markası:{_mark}\nAraba Modeli:{_type}\nAraba Rengi:{_color}\nArabanın Kapı Sayısı:{DoorNumber}");
        }

    }
}
