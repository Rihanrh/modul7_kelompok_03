using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    public class Data
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public Data() { }

        public Data(string firstName, string lastName, string gender, int age, string nim)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.nim = nim;
        }
    }

    public class Members
    {
        public List<Data> members { get; set; }
        public Members() { }
        public Members(List<Data> members)
        {
            this.members = members;
        }
    }
    internal class TeamMembers1302213092
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_2_nim.json");
            Members mem = JsonSerializer.Deserialize<Members>(jsonString);
            int i = 0;
            Console.WriteLine("Team member list:");
            foreach (Data data in mem.members)
            {
                Console.WriteLine("<" + data.nim + ">" + " " +
                    "<" + data.firstName + " " + data.lastName + ">" + " " +
                    "(" + data.age + " " + data.gender + ")");
            }
        }
    }
}