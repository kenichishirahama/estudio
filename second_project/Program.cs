

using System.Dynamic;
using System.Net.Security;

//var sale = new Sale(15);//instancia de la clase sale 
var sale = new SaleWithTax(15, 1.6m);//instacia de la clase sale with tax
var message = sale.GetINfo();//metodo

Console.WriteLine(message);

class SaleWithTax : Sale//herencia
{
    public decimal Tax { get; set; }
    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetINfo()//metodo override
    {
        return "el total es " + Total + " el impuesto es " + Tax;
    }

    public string GetINfo(string message)
    {
        return message;
    }
}

class Sale
{
    public decimal Total { get; set; }//propiedad publica, accede en cualquier parte del programa 
    private decimal _some;//Propiedad privada, solo se accede a ella dentro de la clase 

    public Sale(decimal total)//constructor
    {//que es un constructor? es un metodo especial que se llama igual que la clase y no tiene tipo de retorno
        Total = total;//
        _some = 8;
    }

    public virtual string GetINfo()//metodo
    {
        return "el total es " + Total;//retorna un string
    }

}