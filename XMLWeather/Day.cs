using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, city, country;
        public Image cloudImage;
        public Image tempImage;

        public Day()
        {
            date = currentTemp = city = country = "";

            cloudImage = null;
            tempImage = null;
        }
    }
}
