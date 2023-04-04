using System;
using System.Diagnostics.Metrics;
using System.Text.Json;

public class TeamMembers1302213043
{
	public void ReadJSON()
	{
		string JSONfolder = File.ReadAllText("D:\\modul7_kelompok_03\\jurnal7_2_1302213043.json");
		Team team = JsonSerializer.Deserialize<Team>(JSONfolder);

		for(int i = 0; i< team.members.Count; i++)
		{
			Console.WriteLine("Nama : " + team.members[i].firstName + " " + team.members[i].lastName);
			Console.WriteLine("Gender : " + team.members[i].gender);
            Console.WriteLine("Age : " + team.members[i].age);
            Console.WriteLine("NIM : " + team.members[i].nim);
		}


	}
}

public class Team
{
	public List<Member> members {get; set;}

	public Team() { }

	public Team(List<Member> member)
    {
        this.members = member;
    }
}

public class Member
{
	public string firstName { get; set; }
	public string lastName { get; set; }
	public string gender { get; set; }
	public string age { get; set; }
	public string nim { get; set; }

	public Member() { }

	public Member(string firstName, string lastName, string gender, string age, string nim)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
        this.nim = nim;
    }
}
