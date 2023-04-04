// See https://aka.ms/new-console-template for more information

using modul7_kelompok_03;

class Program
{
    public static void Main(string[] args)
    {

        TeamMembers1302210028 tm = new TeamMembers1302210028();
        tm.ReadJSON();

        DataMahasiswa1302210028 dm = new DataMahasiswa1302210028();
        dm.ReadJSON();
        
        TeamMembers1302213043 teamMembers = new TeamMembers1302213043();
        teamMembers.ReadJSON();
        
        DataMahasiswa1302213043 dataMahasiswa = new DataMahasiswa1302213043();  
        dataMahasiswa.ReadJSON();
    }
}
