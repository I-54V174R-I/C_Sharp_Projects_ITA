
var venta = new VentacImpuestos(15, 1.16m);
var msj = venta.Obtenerinfo();
Console.WriteLine(msj);

class VentacImpuestos : Venta
{
    public decimal Impuesto {  get; set; }
    public VentacImpuestos(decimal total, decimal impuesto) : base(total)
    {
        Impuesto = impuesto;
    }
    public override string Obtenerinfo()
    {
        return "El total es de: " + Total + " con impuesto de " + Impuesto;
    }
    public string Obtenerinfo(string cadena)
    {
        return cadena;
    }
} 
class Venta
{
    public decimal Total {  get; set; } //
    public Venta(decimal total) //constructor
    {
        Total = total;
    }
    public virtual string Obtenerinfo()
    {
        return "El total fue de " + Total;
    }
}