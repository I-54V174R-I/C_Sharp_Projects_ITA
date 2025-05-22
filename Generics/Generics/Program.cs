
using System.Globalization;

var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var libros = new MyList<Libro>(5);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

names.Add("Mario");
names.Add("Mela");
names.Add("Mich");
names.Add("Alex");
names.Add("Araceli");

libros.Add(new Libro()
{
    Name = "Moby Dick",
    Price = 8
});
libros.Add(new Libro()
{
    Name = "OP",
    Price = 20
});
libros.Add(new Libro()
{
    Name = "BK",
    Price = 12
});
libros.Add(new Libro()
{
    Name = "Clena Code",
    Price = 10
});

Console.WriteLine(numbers.GetContent());
Console.WriteLine(names.GetContent());
Console.WriteLine(libros.GetContent());

public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit)
    {
        _limit = limit;
        _list = new List<T>();
    }
    public void Add(T item)
    {
        if (_list.Count < _limit)
        {
            _list.Add(item);
        }
    }
    public string GetContent()
    {
        string content = "";
        foreach (var item in _list) 
        {
            content += item + ", ";
        }
        return content;
    }
}

public class Libro
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return "Nombre: " + Name + " Precio: " + Price;
    }
}