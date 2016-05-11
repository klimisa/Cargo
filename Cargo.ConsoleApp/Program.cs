using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cargo.DomainModel;
using Cargo.DomainModel.Factories;
using Cargo.DomainModel.Models;

namespace Cargo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cargo = CargoFactory.NewCargo();
            NewCargoReport(cargo);
            
            var handlingEvent = new HandlingEvent(cargo, "Load", DateTime.Now.AddMinutes(-1));
            NewHandingEventReport(handlingEvent);

            var loadingEvent = HandlingEvent.NewLoading(cargo, new CarrierMovement(), DateTime.Now.AddMinutes(-1));
            NewHandingEventReport(loadingEvent);

            Console.ReadKey();
        }

        private static void NewCargoReport(DomainModel.Models.Cargo cargo)
        {
            Console.WriteLine("------------------------------------------------------");
            WriteHeader("N E W  C A R G O");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("TrackingId: {0}", cargo.TrackingId);
            Console.WriteLine("Delivery Specification: {0}", cargo.Goal == null ? "Null" : "I have a spec.");
            Console.WriteLine("Delivery History: {0}",
                cargo.DeliveryHistory.HandlingEvents.Count == 0 ? "Empty" : "Some History");
            Console.WriteLine("------------------------------------------------------");
        }

        private static void NewHandingEventReport(HandlingEvent handlingEvent)
        {
            Console.WriteLine("------------------------------------------------------");
            WriteHeader("N E W  H a n d l i n g  E v e n t");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Event Id: {0}", handlingEvent.EventId);
            Console.WriteLine("------------------------------------------------------");
        }

        private static void WriteHeader(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
