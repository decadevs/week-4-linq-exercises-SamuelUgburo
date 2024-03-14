//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Week4Task;

//public class Program {

//    static void Main(string[] args)
//    {
//        IList<State> stateList = new List<State>()
//{
//    new State() { StateID = 1, StateName = "Abia", StateCapital= "Umuahia" },
//    new State() { StateID = 1, StateName = "Adamawa", StateCapital= "Yola" },
//    new State() { StateID = 1, StateName = "Akwa Ibom", StateCapital= "Uyo" },
//    new State() { StateID = 2, StateName = "Anambra", StateCapital= "Awka" },
//    new State() { StateID = 2, StateName = "Bauchi", StateCapital= "Bauchi" },
//    new State() { StateID = 2, StateName = "Bayelsa", StateCapital= "Yenagoa" },
//    new State() { StateID = 3, StateName = "Benue", StateCapital= "Makurdi" },
//    new State() { StateID = 3, StateName = "Borno", StateCapital= "Maiduguri" },
//    new State() { StateID = 3, StateName = "Cross-River", StateCapital= "Calabar" },
//    new State() { StateID = 4, StateName = "Delta", StateCapital= "Asaba" },
//    new State() { StateID = 4, StateName = "Ebonyi", StateCapital= "Abakaliki" },
//    new State() { StateID = 4, StateName = "Edo", StateCapital= "Benin" },
//    new State() { StateID = 5, StateName = "Ekiti", StateCapital= "Ado-Ekiti" },
//    new State() { StateID = 5, StateName = "Enugu", StateCapital= "Enugu" },
//    new State() { StateID = 5, StateName = "Gombe", StateCapital= "Gombe" },
//    new State() { StateID = 6, StateName = "Imo", StateCapital= "Owerri" },
//    new State() { StateID = 6, StateName = "Jigawa", StateCapital= "Dutse" },
//    new State() { StateID = 6, StateName = "Kaduna", StateCapital= "Kaduna" },
//    new State() { StateID = 7, StateName = "Kano", StateCapital= "Kano" },
//    new State() { StateID = 7, StateName = "Katsina", StateCapital= "Katsina" },
//    new State() { StateID = 7, StateName = "Kebbi", StateCapital= "Birnin-Kebbi" },
//    new State() { StateID = 8, StateName = "Kogi", StateCapital= "Lokojs" },
//    new State() { StateID = 8, StateName = "Kwara", StateCapital= "Ilorin" },
//    new State() { StateID = 8, StateName = "Lagos", StateCapital= "Ikeja" },
//    new State() { StateID = 9, StateName = "Nasarawa", StateCapital= "Lafia" },
//    new State() { StateID = 9, StateName = "Niger", StateCapital= "Minna" },
//    new State() { StateID = 9, StateName = "Ogun", StateCapital= "Abeokuta" },
//    new State() { StateID = 10, StateName = "Ondo", StateCapital= "Akure" },
//    new State() { StateID = 10, StateName = "Osun", StateCapital= "Oshogbo" },
//    new State() { StateID = 10, StateName = "Oyo", StateCapital= "Ibadan" },
//    new State() { StateID = 11, StateName = "Plateau", StateCapital= "Jos" },
//    new State() { StateID = 11, StateName = "Rivers", StateCapital= "Port-Harcourt" },
//    new State() { StateID = 11, StateName = "Sokoto", StateCapital= "Sokoto" },
//    new State() { StateID = 12, StateName = "Taraba", StateCapital= "Jalingo" },
//    new State() { StateID = 12, StateName = "Yobe", StateCapital= "Damaturu" },
//    new State() { StateID = 12, StateName = "Zamfara", StateCapital= "Gusau" },

//    };
//        var groupedStates = stateList.GroupBy(s => s.StateID);

//        Console.WriteLine("A Group of states in set of 3:");
//        Console.WriteLine("==================================");
        

//        // Iterate over each group
//        foreach (var group in groupedStates)

//        {
//            Console.WriteLine("_________________________________");

//            // Concatenate state names within the group
//            string stateNames = string.Join(", ", group.Select(s => s.StateName));
            
//            // Print states with the same ID on the same line
//            Console.WriteLine($" {stateNames}");
//        }

       


//    }

//}