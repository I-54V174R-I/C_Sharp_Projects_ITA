

//FUNCIÓN PURA
int Sub(int a, int b)
{
    return a - b;
}

Console.WriteLine(Sub(2, 1));

//FUNCIÓN NO PURA

DateTime getTomorrow()
{
    return DateTime.Now.AddDays(1);
}

Console.WriteLine(getTomorrow().ToString());

//FUNCIÓN ANTERIOR DE FORMA PURA

DateTime getTom2(DateTime date)
{
    return date.AddDays(1);
}

var libro = new Libro()
{
    Nombre = "Moby Dick"
};

Console.WriteLine("Libro tal cual: " + libro.Nombre);
Console.WriteLine("Libro en mayusculas: " + ToUpper(libro).Nombre);
Console.WriteLine("Libro mayusculas funcion pura: " + ToUpper2(libro).Nombre);

//funcion no pura
Libro ToUpper (Libro libro)
{
    libro.Nombre = libro.Nombre.ToUpper();
    return libro;
}
//funcion anterior pura
Libro ToUpper2 (Libro libro)
{
    var libro2 = new Libro()
    {
        Nombre = libro.Nombre.ToUpper(),
    };
    return libro2;
}

public class Libro
{
    public string Nombre { get; set; }
}
