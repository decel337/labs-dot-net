using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispetcher mediator = new Dispetcher();
            List<Colleague> plains = new List<Colleague>() {new Plain(mediator, "Underground"), 
                new Plain(mediator, "Boeing"),
                new Plain(mediator, "Ger241")
            };
            
            List<Colleague> airports = new List<Colleague>() {new Airport(mediator, new Terminal(), new List<Landd>(){new Landd(1), new Landd(2)}, "New Jersey"), 
                new Airport(mediator, new Terminal(), new List<Landd>(){new Landd(1)}, "Underground"),
                new Airport(mediator, new Terminal(), new List<Landd>(){new Landd(1), new Landd(2), new Landd(3)}, "New York"),
                new Airport(mediator, new Terminal(), new List<Landd>(){new Landd(1)}, "Montgomery")
            };
            while (true)
            {
                Console.WriteLine("Plain in Sky: ");
                plains.Where(x => ((Plain) x).isTerminal == false && ((Plain) x).land == null).ToList()
                    .ForEach(x => Console.Write(((Plain) x).Name + ", "));
                Console.WriteLine();
                Console.WriteLine("Plain in Terminal: ");
                plains.Where(x => ((Plain) x).isTerminal).ToList().ForEach(x => Console.Write(((Plain) x).Name + ", "));
                Console.WriteLine();
                Console.WriteLine("Plain in Land: ");
                plains.Where(x => (((Plain) x).land != null)).ToList()
                    .ForEach(x => Console.Write(((Plain) x).Name + ", "));
                Console.WriteLine();

                    Console.Write("Input name plain: ");
                    string key = Console.ReadLine();
                    Console.WriteLine("Select action ToSky(0), ToLand(1), ToTerminal(2): ");
                    int action;
                    int.TryParse(Console.ReadLine(), out action);
                
                
                    if (action == 0)
                    {
                        mediator.Plain = plains.Find(x => ((Plain)x).Name.Equals(key));
                        mediator.Airport = ((Plain)mediator.Plain).Airport;
                        mediator.Plain.ToSky();
                    }
                    if (action == 1)
                    {
                        Console.WriteLine("Airports: ");
                        airports.ForEach(x => Console.Write(((Airport) x).Name + ", "));
                        Console.WriteLine();
                        Console.Write("Input index: ");
                        int indexAirport;
                        int.TryParse(Console.ReadLine(), out indexAirport);
                        mediator.Plain = plains.Find(x => ((Plain)x).Name.Equals(key));
                        mediator.Airport = airports[indexAirport-1];
                        mediator.Plain.ToLand();
                    }
                    if (action == 2)
                    {
                        Console.WriteLine("Airports: ");
                        airports.ForEach(x => Console.Write(((Airport) x).Name + ", "));
                        Console.WriteLine();
                        Console.Write("Input index: ");
                        int indexAirport;
                        int.TryParse(Console.ReadLine(), out indexAirport);
                        mediator.Plain = plains.Find(x => ((Plain)x).Name.Equals(key));
                        mediator.Airport = airports[indexAirport-1];
                        mediator.Plain.ToTerminal();
                    }
                    Console.WriteLine("-------------------------------------------------------------------------------");
            }
        }
    }
}