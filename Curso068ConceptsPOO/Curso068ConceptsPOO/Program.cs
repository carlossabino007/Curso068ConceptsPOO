// See https://aka.ms/new-console-template for more information
using Curso068ConceptsPOO;

Console.WriteLine("POO Conceptos!");
Console.WriteLine("==============");

Date date1 = new Date(2022,2,22);
Console.WriteLine(date1.ToString());

try
{
    Console.WriteLine(new Date(2022, 2, 20));
    Console.WriteLine(new Date(1674, 4, 21));
    Console.WriteLine(new Date(1985, 11, 31));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
    
}



