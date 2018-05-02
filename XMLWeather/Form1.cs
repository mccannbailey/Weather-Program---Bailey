using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();
        Day d = new Day();

        string city, temp, weather, time;

        public Form1()
        {
            city = temp = weather = time = "";

            InitializeComponent();
            GetData();
            ExtractCurrent();
            ExtractForecast();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            // city and location
            XmlNode cityNode = doc.SelectSingleNode("current/city");
            city = cityNode.Attributes["name"].Value;

            // current temperature
            XmlNode currentNode = doc.SelectSingleNode("current/temperature");
            temp = Convert.ToString(currentNode.Attributes["value"].Value); 

            // clouds
            XmlNode weatherNode = doc.SelectSingleNode("current/weather");
            weather = weatherNode.Attributes["number"].Value;

            // time/date
            XmlNode timeNode = doc.SelectSingleNode("current/lastupdate");
            time = timeNode.Attributes["value"].Value;

            Day d = new Day
            {
                city = city,
                date = time,
                currentTemp = temp,
                tempImage = WeatherImages(weather, temp).Item1,
                cloudImage = WeatherImages(weather, temp).Item2
            };
            days.Add(d);
        }

        private void ExtractForecast()
        {

        }

        public Tuple<Image, Image> WeatherImages(string w, string t)
        {
            double code = Convert.ToDouble(w);
            double temp = Convert.ToDouble(t);
            Image cloudImage = Properties.Resources.sun;
            Image tempImage = null;

            // cloudy weather
            if (code > 800 && code < 805) { cloudImage = Properties.Resources.cloudy; }
            // clear weather
            if (code == 800) { cloudImage = Properties.Resources.sun; }
            // rainy weather
            if (code > 499 && code < 532) { cloudImage = Properties.Resources.rainy; }
            // thunderstorm 
            if (code > 199 && code < 233) { cloudImage = Properties.Resources.thunderstorm; }


            // temperature warnings
            if (temp < 0) { tempImage = Properties.Resources.cold; }
            if (temp > 20) { tempImage = Properties.Resources.hot; }

            return Tuple.Create(tempImage, cloudImage);
        }
    }
}
