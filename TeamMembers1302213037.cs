using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    internal class TeamMembers1302213037
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
        public List<TeamMembers1302213037> members { get; set; }

        public TeamMembers1302213037() { }
        public TeamMembers1302213037(string firstName, string lastName, string gender, int age, string nim, List<TeamMembers1302213037> members)
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
            string jsonString = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_2_1302213037.json");
            TeamMembers1302213037 hasilbaca = JsonSerializer.Deserialize<TeamMembers1302213037>(jsonString);

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
