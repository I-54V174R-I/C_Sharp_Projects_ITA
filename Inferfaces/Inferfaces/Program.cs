
var a = new Sale();
var b = new Cocer();

Hacer(a);
Hacer(b);

void Hacer(ISave z)
{
    z.Save();
}
interface ISave
{//s
    public void Save();
}
interface ISale
{
    decimal Total { get; set; }
}
public class Sale : ISave, ISale
{
    public decimal Total { get; set; }
    public void Save() { }

}
public class Cocer : ISave
{
    public void Save()
    {
        Console.WriteLine("Guardado en Cacerola.");
    }
}
public class Hervir : ISave
{
    public void Save()
    {
        Console.WriteLine("Guardado en la Hervidera.");
    }
}