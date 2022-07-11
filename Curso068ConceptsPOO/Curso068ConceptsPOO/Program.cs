// See https://aka.ms/new-console-template for more information
using Curso068ConceptsPOO;

Console.WriteLine("POO Conceptos!");
Console.WriteLine("==============");

//Date date1 = new Date(2022,2,22);
//Date date2 = new Date(2022, 2, 4);
//Console.WriteLine(date1);
//Console.WriteLine(date2);

try
{
    Console.WriteLine(new Date(2022, 2, 20));
    Console.WriteLine(new Date(1674, 4, 21));
    Console.WriteLine(new Date(1985, 11, 48));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);

}

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDay = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary= 1815543.45M
      
};

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDay = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    ComissionPercentaje = 0.03F,
    Sales=10000000M

};
Console.WriteLine("====================");
Console.WriteLine(employee1);
Console.WriteLine("====================");
Console.WriteLine(employee2);






