// See https://aka.ms/new-console-template for more information
using Replace_Example;
RepChar rep = new RepChar();
Console.WriteLine("Please Enter input data ");
string input = Console.ReadLine();
Console.WriteLine("Enter char that you want cahnge");
string ol = Console.ReadLine();
Console.WriteLine("Enter new cahr you want replace ");
string ne = Console.ReadLine();
if((ol.Length==1) && (ne.Length == 1))
{
    try
    {
        char old = Convert.ToChar(ol);
        char neww = Convert.ToChar(ne);
        string output = rep.replace(input, old, neww);
        Console.WriteLine("output : " + output);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else if ((ol.Length != 1) || (ne.Length != 1))
{
    Console.WriteLine("Invalid Data");
}


