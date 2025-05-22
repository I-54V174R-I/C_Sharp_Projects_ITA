

var show = Show; //se guarda la funcion en una variable
var show2 = Show2;
show("hola");
Algodon(show, "Action retornado");
Algodon2(show2, "Func retornado en uppercase");
void Show(string message)
{
    Console.WriteLine(message);
}
string Show2(string message)
{
    return message.ToUpper();
}

void Algodon(Action<string> func, string message)
{
    Console.WriteLine("Hace algo al inicio");
    func(message);
    Console.WriteLine("Hace algo al final");
}
void Algodon2(Func<string, string> func, string message)
{
    Console.WriteLine("Hace algo al inicio 2");
    Console.WriteLine(func(message));
    Console.WriteLine("Hace algo al final 2");
}