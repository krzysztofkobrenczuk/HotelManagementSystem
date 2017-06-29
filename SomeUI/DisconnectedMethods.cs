using HotelManagementSystem.Data;
using HotelManagementSystem.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeUI
{
    public class DisconnectedMethods
    {
        private static void DisplayState(List<EntityEntry> es, string method)
        {
            Console.WriteLine(method);
            es.ForEach(e => Console.WriteLine($"{e.Entity.GetType().Name} : {e.State.ToString()}"));
            Console.WriteLine();
        }

        public static void AddGraphAllNew()
        {
            var clientGraph = new Client { FirstName = "Krzys", LastName = "Bob" };
            using(var context = new HotelContext())
            {
                context.Clients.Add(clientGraph);
                var es = context.ChangeTracker.Entries().ToList();
                DisplayState(es, "AddGraphAllNew");
            }
        }
    }
}
