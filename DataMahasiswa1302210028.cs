using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }

        public Course() { }

        public Course(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Address() { }

        public Address(string streetAddress, string city, string state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }

    public class DataMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
        public DataMahasiswa() { }
        public DataMahasiswa(string firstName, string lastName, string gender, int age, Address address, List<Course> courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }
    }
    internal class DataMahasiswa1302210028
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"./jurnal7_1_1302210028.json");
            DataMahasiswa dm = JsonSerializer.Deserialize<DataMahasiswa>(jsonString);
            int i = 0;
            Console.WriteLine("Nama\t: " + dm.firstName + " " + dm.lastName);
            Console.WriteLine("Gender\t: " + dm.gender);
            Console.WriteLine("Umur\t: " + dm.age + " tahun");
            Console.WriteLine("Alamat\t: " + dm.address.streetAddress + ", " + dm.address.city + ", " + dm.address.state);
            Console.WriteLine("Matkul yang diambil: ");
            foreach (Course courses in dm.courses)
            {
                Console.WriteLine("MK " + (i + 1) + " " + courses.code + " - " + courses.name);
                i++;
            }
        }
    }
}
