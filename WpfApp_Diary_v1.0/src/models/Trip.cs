using System;
using System.Collections.Generic;

namespace WpfApp_Diary_v1._0.src.models
{
    public class Trip
    {
        long IdTrip { get; set; }
        string From { get; set; }
        string To { get; set; }
        TimeSpan Duration { get; set; }
        double Price { get; set; }
        List<string> WhereItPasses { get; set; }
        DateTime DateDeparture { get; set; }
        DateTime DateArrival { get; set; }
        string Type { 
            get 
            { 
                return Type; 
            } 
            set
            {
                switch (value)
                {
                    case "Economy": 
                        Type = value;
                        break;
                    case "Luxury":
                        Type = value;
                        break;
                    default:
                        return;
                }
            }
        }
        int NumerOfPassengers { get; set; }

        Trip(string From, string To, TimeSpan Duration, double Price, List<string> WhereItPasses, DateTime DateDeparture, DateTime DateArrival, string Type, int NumerOfPassengers)
        {
            this.From = From;
            this.To = To;
            this.Duration = Duration;
            this.Price = Price;
            this.WhereItPasses = WhereItPasses;
            this.DateDeparture = DateDeparture;
            this.DateArrival = DateArrival;
            this.Type = Type;
            this.NumerOfPassengers = NumerOfPassengers;
        }
    }
}
