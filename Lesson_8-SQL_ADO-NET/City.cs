using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_SQL_ADO_NET
{
    class City
    {
        private string cityName;

        //constructor
        public City()
        {
            this.cityName = "";
        }
        //constructor with city name
        public City(string cityName)
        {
            if(cityName.Length > 0)
            {
                this.cityName = cityName;
            }
            else
                this.cityName = "";
        }
        //get / set
        public string CityName
        {
            get { return cityName; }
            set
            {
                this.cityName = value;
            }
        }
    }
}
