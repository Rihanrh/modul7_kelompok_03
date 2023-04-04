using System;
using System.Net.Cache;
using System.Text.Json;

public class DataMahasiswa1302210033_PRAKTIKAN
{
	public void ReadJSON()
	{
		String json = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_1_1302210033.json");

		Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
		Console.WriteLine("Nama  : " + mahasiswa.firstName + " " + mahasiswa.lastName);
		Console.WriteLine("Gender : " + mahasiswa.gender);
		Console.WriteLine("Age : " + mahasiswa.age);
		//Console.WriteLine("Address : " + mahasiswa.address.streetAddress + mahasiswa.address.city + mahasiswa.address.state);

		int i = 1;
		foreach(Courses courses in mahasiswa.courses)
		{
            Console.WriteLine("Courses : " + mahasiswa.courses.code);
        }
		
		
	}
}

public class Mahasiswa
{

    public string firstName { get; set; }
	public string lastName { get; set; }
	public string gender { get; set; }
	public int age { get; set; }
	public Address address { get; set; }

	public List<Courses> courses{ get; set; }

	public Mahasiswa(string firstName, string lastName, string gender, int age, Address address,List<Courses> courses)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.gender = gender;
		this.age = age;
		this.courses = courses;
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

public class Courses
{
	public string code { get; set; }
	public string name { get; set; }

	public Courses() { }

	public Courses(string code, string name)
	{
		this.code = code;
		this.name = name;
	}
}
