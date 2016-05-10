using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cargo.DomainModel;

namespace Cargo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cargo = new DomainModel.Cargo();
            var h1 = cargo.DeliveryHistory.HandlingEvents;
            var h2 = cargo.Handled;
        }
    }
}
