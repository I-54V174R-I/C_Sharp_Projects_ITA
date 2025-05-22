using System.Text.Json;

var Mario = new Personas() 
{
    Name = "Mario", 
    Age = 26 
};

string json = JsonSerializer.Serialize(Mario);
Console.WriteLine(json);

string myJson = @"{ 
""Name"":""Mich"",
""Age"":22
}";

Personas? mich = JsonSerializer.Deserialize<Personas>(myJson);
Console.WriteLine(mich?.Name);
Console.WriteLine(mich?.Age);

public class Personas
{
    public string Name {  get; set; }
    public int Age { get; set; }
    public Personas()
    {

    }
}