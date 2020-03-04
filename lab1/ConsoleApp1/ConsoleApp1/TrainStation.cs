using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class TrainStation
    {
       static List<Train> listOfTrains = new List<Train>();
        static public void NowAvaliableByTime(string time)
        {
            
            foreach (Train train in listOfTrains)
            {
                if (time == train.TimeOfDeparture)
                {
                    Console.WriteLine($"Train number : {train.NumberOfTrain}\nTrain destination : {train.Destination}" );
                }
            }
        }

        static public int BestChoise(string destination)
        {
            int number = 0;
            int[] besttime = { 0, 0 };
            foreach (Train train in listOfTrains)
            {
               string[] time = train.TimeOfDeparture.Split(':', '-', ' ');
                if(besttime[1] < Convert.ToInt32(time[1]))
                {
                    if (besttime[0] < Convert.ToInt32(time[0]))
                    {
                        besttime[0] = Convert.ToInt32(time[0]);
                        besttime[1] = Convert.ToInt32(time[1]);
                        number = train.NumberOfTrain;
                    }
                    else
                    {
                        besttime[1] = Convert.ToInt32(time[1]);
                        number = train.NumberOfTrain;
                    }
                }

                
            }
            return number;
        }

        static public void ShowInfo(Train train)
        {
            Console.WriteLine(new string('-', 50));
            Console.Write($"Train number: {train.NumberOfTrain}\nTrain destination: {train.Destination}\n");
        }
        static public void ShowInfo()
        {
            foreach (Train train in listOfTrains)
            {
                try
                {
                    string[] time = train.TimeOfArrival.Split(':', '-', ' ');
                    string[] time1 = train.TimeOfDeparture.Split(':', '-', ' ');
                    Console.WriteLine(new string('-', 50));
                    Console.Write($"Train number: {train.NumberOfTrain}\nTrain destination: {train.Destination}\n");
                    Console.WriteLine(new string('-', 50));
                }
                catch (NullReferenceException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
        }
        static public void RegisterTrain( params Train[] trains) 
        {
            foreach (Train train in trains)
            {
                listOfTrains.Add(train);
            }
        }


        static public void DeleteTrain(Train train)
        {
            listOfTrains.Remove(train);
        }


    }
}
