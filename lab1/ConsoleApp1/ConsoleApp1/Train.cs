using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Train
    {
        private string timeofarrival;
        private string timeofdeparture;
        public int NumberOfTrain { get; private set;}
        public string TimeOfArrival {
            get 
            { 
                return timeofarrival; 
            }
            private set 
            {
                string[] time = value.Split(':' ,'-', ' ');
                if (Convert.ToInt32(time[0]) > 24 || Convert.ToInt32(time[1]) > 60)
                {
                    throw new Exception("Time is out of range"); 
                }
                else 
                {
                    timeofarrival = value;
                }
            }
        }
        public string TimeOfDeparture {
            get 
            {
                return timeofdeparture; 
            }
            private set
            {
                string[] time = value.Split(':', '-', ' ');
                if (Convert.ToInt32(time[0]) > 24 || Convert.ToInt32(time[1]) > 60)
                {
                    throw new Exception("Time is out of range");
                }
                else
                {
                    timeofdeparture = value;
                }
            }
        }
        public string Destination { get; private set;}
        public Train(int number, string TA, string TD, string dest)
        {
            NumberOfTrain = number;
            try
            {
                TimeOfArrival = TA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            try
            {
                TimeOfDeparture = TD;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }  
            
            Destination = dest;
        }
    }
}
