using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train1 = new Train(124 ,"12:55","13:40", "Харьков - Одесса");
            Train train2 = new Train(125, "12-56", "15:59", "Киев - Черкассы");
            Train train3 = new Train(126, "12:67", "13:54", "Харьков - Полтава");
            TrainStation.RegisterTrain(train1, train2, train3);
            TrainStation.NowAvaliableByTime("13:40");
            TrainStation.ShowInfo();
        }
    }
}
