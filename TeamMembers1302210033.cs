using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    internal class TeamMembers1302210033
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
        public List<TeamMembers1302210033> members { get; set; }

        public TeamMembers1302210033() { }
        public TeamMembers1302210033(string firstName, string lastName, string gender, int age, string nim, List<TeamMembers1302210033> members)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.nim = nim;
            this.members = members;
        }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_2_1302210033.json");
            TeamMembers1302210033 hasilbaca = JsonSerializer.Deserialize<TeamMembers1302210033>(jsonString);

            Console.WriteLine("Team member List :");

            for (int i = 0; i < hasilbaca.members.Count; i++)
            {
                Console.WriteLine("<" + hasilbaca.members[i].nim + ">" + " " +
                    "<" + hasilbaca.members[i].firstName + " " + hasilbaca.members[i].lastName + ">" + " " +
                    "(" + hasilbaca.members[i].age + " " + hasilbaca.members[i].gender + ")");
            }
        }
    }
}