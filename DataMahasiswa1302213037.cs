﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul7_kelompok_03.DataMahasiswa1302213037.Address;


namespace modul7_kelompok_03
{
    internal class DataMahasiswa1302213037
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }

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
        }

        public DataMahasiswa1302213037(string firstName, string lastName, string gender, int age, Address address, List<Course> courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }

        public DataMahasiswa1302213037()
        {
        }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_1_1302213037.json");
            DataMahasiswa1302213037 mhs = JsonSerializer.Deserialize<DataMahasiswa1302213037>(jsonString);

            Console.WriteLine("Nama :" + mhs.firstName + " " + mhs.lastName
                                    + "\nUsia : " + mhs.age
                                    + "\nJenis Kelamin : " + mhs.gender
                                    + "\nAlamat :" + mhs.address.streetAddress + " " + mhs.address.city + " " + mhs.address.state);

            Console.WriteLine("\n Daftar matakuliah yang diambil :");
            
            for (int i =0;i<mhs.courses.Count;i++)
            {
                Console.WriteLine("MK " + (i+1) + " " + mhs.courses[i].code + " - " + mhs.courses[i].name);
                
            }
        }
        
    }

            
           
       
 }
    

