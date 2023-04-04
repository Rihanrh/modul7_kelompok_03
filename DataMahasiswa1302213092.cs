using System;
namespace modul7_kelompok_03;
using System.Text.Json;
public class DataMahasiswa1302213092
{
	Identity id = new Identity();
	

	string text = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_1_nim.json");

	public void readJSON1()
	{
		id = JsonSerializer.Deserialize<Identity>(text);
		Console.WriteLine($"Nama: {id.firstName}{id.lastName}");
		Console.WriteLine($"Gender: {id.gender}");
		Console.WriteLine($"Age: {id.age}");
		Console.WriteLine($"Address: {id.address.streetAddress}, {id.address.city}, {id.address.state	}");
		for(int i = 0; i < id.courses.Count; i++)
		{
			Console.WriteLine($"Courses {i + 1}: <{id.courses[i].code}> - <{id.courses[i].name}>");
		}
	}
	public DataMahasiswa1302213092()
	{
	}
}
