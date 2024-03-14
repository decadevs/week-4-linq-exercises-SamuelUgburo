using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Task
{
    internal class Number3
    {
        static void Main(string[] args)
        {
            List<States> states = new List<States>
            {
                new States  { StateID =1, StateName = "Abia" },
                new States   { StateID = 1, StateName = "Adamawa" },
                new States  { StateID = 1, StateName = "Akwa Ibom" },
                new States { StateID = 1, StateName = "Anambra" },
                new States { StateID = 2, StateName = "Bauchi" },
                new States { StateID = 2, StateName = "Bayelsa" },
                new States { StateID = 2, StateName = "Benue" },
                new States { StateID = 2, StateName = "Borno" },
                new States { StateID = 3, StateName = "Cross-River" },
                new States { StateID = 4, StateName = "Delta" },
                new States { StateID = 5, StateName = "Ebonyi" },
                new States { StateID = 5, StateName = "Edo" },
                new States { StateID = 5, StateName = "Ekiti" },
                new States { StateID = 5, StateName = "Enugu" },
                new States { StateID = 6, StateName = "Gombe" },
                new States { StateID = 7, StateName = "Imo" },
                new States { StateID = 8, StateName = "Jigawa"},
                new States{ StateID = 9, StateName = "Kaduna" },
                new States { StateID = 9, StateName = "Kano" },
                new States { StateID = 9, StateName = "Katsina" },
                new States { StateID = 9, StateName = "Kebbi" },
                new States { StateID = 9, StateName = "Kogi" },
                new States { StateID = 9, StateName = "Kwara" },
                new States { StateID = 10, StateName = "Lagos" },
                new States { StateID = 11, StateName = "Nasarawa" },
                new States { StateID = 11, StateName = "Niger" },
                new States { StateID = 12, StateName = "Ogun" },
                new States { StateID = 12, StateName = "Ondo" },
                new States { StateID = 12, StateName = "Osun" },
                new States { StateID = 12, StateName = "Oyo" },
                new States { StateID = 13, StateName = "Plateau" },
                new States { StateID = 14, StateName = "Rivers" },
                new States { StateID = 15, StateName = "Sokoto" },
                new States { StateID = 16, StateName = "Taraba" },
                new States { StateID = 17, StateName = "Yobe" },
                new States { StateID = 18, StateName = "Zamfara" },
            };

            List<States2> states2 = new List<States2>
            {
                    new States2 {GroupID = 1, GroupName = "A" },
                    new States2 {GroupID = 2, GroupName = "B"},
                    new States2 {GroupID = 3, GroupName = "C"},
                    new States2 {GroupID = 4, GroupName = "D"},
                    new States2 {GroupID = 5, GroupName = "E"},
                    new States2 {GroupID = 6, GroupName = "G"},
                    new States2 {GroupID = 7, GroupName = "I"},
                    new States2 {GroupID = 8, GroupName = "J"},
                    new States2 {GroupID = 9, GroupName = "K" },
                    new States2 {GroupID = 10, GroupName = "L"},
                    new States2 {GroupID = 11, GroupName = "N"},
                    new States2 {GroupID = 12, GroupName = "O"},
                    new States2 {GroupID = 13, GroupName = "P"},
                    new States2 {GroupID = 14, GroupName = "R"},
                    new States2 {GroupID = 15, GroupName = "S"},
                    new States2 {GroupID = 16, GroupName = "T"},
                    new States2 {GroupID = 17, GroupName = "Y"},
                    new States2 {GroupID = 18, GroupName = "Z"},

            };

            var groupJoin = states2.GroupJoin(states, y => y.GroupID, st => st.StateID, (y, stateGrp) => new
            {
                GroupName = y.GroupName,
                state = stateGrp.Select(s => s.StateName)

            });
            foreach (var group in groupJoin)
            {
                Console.WriteLine($"Group: {group.GroupName} - {group.state.Count()}");
                Console.WriteLine("----------------");
                Console.WriteLine(string.Join(", ", group.state));
                Console.WriteLine();
            }
        }
    }
}
