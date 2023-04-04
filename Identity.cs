using System;
namespace modul7_kelompok_03;
public class Identity
{
	public String firstName { get; set; }
	public String lastName { get; set; }
	public String gender { get; set; }
	public int age { get; set; }
	public Address address { get; set; }

    public List<Courses> courses { get; set; }

    public Identity()
	{
	}
}
