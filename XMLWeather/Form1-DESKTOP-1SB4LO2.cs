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
        public Form1()
        {
            InitializeComponent();
            GetData();
            MakePictureParent();
            ExtractCurrent();
            ExtractForecast();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford&mode=xml&units=metric", "WeatherData.xml");
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7", "WeatherData7Day.xml");
       
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;


            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                //if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                     cityOutput.Text = child.Attributes["name"].Value;
                }
                
                //if the "temperature" element is found display the value of it's "value" attribute
                if (child.Name == "temperature")
                {
                    currentOutput.Text = child.Attributes["value"].Value;
                }

                //if the "wind" element is found search through each of it's sub elements
                if (child.Name == "wind")
                {
                    //check each child of the wind element (grandChild of parent element)
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        //if the "speed" element is found display the values of the "name" and "value" attributes
                        if (grandChild.Name == "speed")
                        {
                            windOutput.Text = grandChild.Attributes["name"].Value;
                            windSpeedOutput.Text = grandChild.Attributes["value"].Value;
                        }
                    }
                }

                if (child.Name == "lastupdate")
                {
                   // dateLabel.Text = DateTime.Parse(child.Attributes["value"].Value).ToString("MMM dd");
                }
            }
        }
              
        private void ExtractForecast()
        {
            //open XML document
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //used to set forecast information into correct day labels
            int day = 1;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                //if the "forecast" element is found search through each of it's sub elements
                if (child.Name == "forecast")
                {
                    //check each child of the forecast element (grandChild of parent element)
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        //check each child of the grandChild element (greatGrandChild of parent element)
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            //if the "temperature" element is found display the appropriate day "max" and "min" attribute
                            if (greatGrandChild.Name == "temperature")
                            {
                                switch (day)
                                {
                                    case 1:
                                        maxOutput.Text = greatGrandChild.Attributes["max"].Value;
                                        minOutput.Text = greatGrandChild.Attributes["min"].Value;
                                        break;
                                    case 2:
                                        day2Max.Text = greatGrandChild.Attributes["max"].Value;
                                        day2Min.Text = greatGrandChild.Attributes["min"].Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            // if the "clouds" element is found display the appropriate day "value" attribute then 
                            // update the day variable to the next day.
                            if (greatGrandChild.Name == "clouds")
                            {
                                switch (day)
                                {
                                    case 1:
                                        day1Outlook.Text = greatGrandChild.Attributes["value"].Value;
                                        day++;
                                        break;
                                    case 2:
                                        day2Outlook.Text = greatGrandChild.Attributes["value"].Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }


        private void MakePictureParent()
        {
            currentOutput.Parent = rainPictureBox;
            cityOutput.Parent = rainPictureBox;

            int newX = cityOutput.Location.X - rainPictureBox.Location.X;
            int newY = cityOutput.Location.Y - rainPictureBox.Location.Y;
            cityOutput.Location = new Point(newX, newY);

            DateTime date = new DateTime();
            DateTime dateNow = DateTime.Now;

            dateLabel.Text = dateNow.Day.ToString();

            //dateLabel.Text = dateNow.ToString();
            
            //dateLabel.Text = dateNow.ToString("dd-m-yy");
            //dateLabel.Text = Convert.ToString(DateTime.Today.AddDays(1));
            //dateLabel.Text = DateTime.Now.AddDays(1).ToString("day");
            //dateLabel.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            //dateLabel.Text = DateTime.Now.ToString("fff");
            //dateLabel.Text = DateTime.Now.ToString("hh:mm:ss.fff tt");
            // displays 1:14:43 PM 

        }

    }
}
