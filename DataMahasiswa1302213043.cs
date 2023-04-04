using System;
using System.Text.Json;

public class DataMahasiswa1302213043
{
	public void ReadJSON()
	{
		string JSONFolder = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_1_1302213043.json");
		Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(JSONFolder);

		Console.WriteLine("Name : " + mahasiswa.firstName + " " + mahasiswa.lastName);
		Console.WriteLine("Gender : " + mahasiswa.gender);
		Console.WriteLine("Age : " + mahasiswa.age);
		Console.WriteLine("Address : " + mahasiswa.adr.streetAddress + " " + mahasiswa.adr.city + " " + mahasiswa.adr.state);

		int i = 1;
		foreach(MataKuliah matakuliah in mahasiswa.courses)
		{
			Console.WriteLine("MK " + i + " " + matakuliah.code + " - " + matakuliah.name);
		}


	}
}


public class Mahasiswa
{
	public List<MataKuliah> courses { get; set;}
	public Address adr { get; set;}
	
	public string firstName { get; set;}
	public string lastName { get; set;}
	public string gender { get; set;}
	public int age { get; set;}

	public Mahasiswa() { }

	public Mahasiswa(string firstname,string lastname,string gender,int age,Address adr,List<MataKuliah> matakuliah)
	{
		this.firstName = firstname;
		this.lastName = lastname;
		this.gender = gender;
		this.age = age;
		this.adr = adr;
		this.courses = matakuliah;

	}
}



public class MataKuliah
{
	public string code { get; set; }
	public string name { get; set; }

	public MataKuliah() { }

	public MataKuliah(string code,string name)
	{
		this.code = code;
		this.name = name;
	}
}

public class Address
{
	public string streetAddress { get; set;}
	public string city { get; set;}
	public string state { get; set;}

	public Address() { }

	public Address(string streetAddress, string city, string state)
	{
		this.streetAddress = streetAddress;
		this.city = city;
		this.state = state;
	}
}
