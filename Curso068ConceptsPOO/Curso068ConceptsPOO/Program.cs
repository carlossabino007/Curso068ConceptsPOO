// See https://aka.ms/new-console-template for more information
using Curso068ConceptsPOO;

Console.WriteLine("POO Conceptos!");
Console.WriteLine("==============");
Console.WriteLine("OK!");
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

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDay = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Hours = 123.5F,  /* Va para un float */
    HourValue = 12356.56M  /* Va para un decimal */ 


};


Employee employee4 = new BaseCommissionEmployee()
{
    Id = 3030,
    FirstName = "Carlos",
    LastName = "Contreeas",
    BirthDay = new Date(1972, 5, 23),
    HiringDate = new Date(2010, 10, 10),
    IsActive = true,
    Base = 800000.58M,  /* Va para un Money */
    ComissionPercentaje = 0.015F,
    Sales = 1000000M

    
     

};
//Console.WriteLine("====================");
//Console.WriteLine(employee1);
//Console.WriteLine("====================");
//Console.WriteLine(employee2);
//Console.WriteLine("====================");
//Console.WriteLine(employee3);
//Console.WriteLine("====================");
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>();
employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);
employees.Add(employee4);


ICollection<Employee> employees2 = new List<Employee>()
{ employee1,employee2,employee3,employee4 };


 decimal payRoll = 0;

foreach (Employee employee in employees2) 
{
    Console.WriteLine(" Uno mas");
    Console.WriteLine(employee);
    payRoll += employee.GetValueToPay();
}
Console.WriteLine(" ..............................: ================");
Console.WriteLine($" TOTAL..........................: {$"{payRoll:C2}",15} ");

Invoice invoice1 = new Invoice()
{
    Description = "IPhon 3",
    Id = 1,
    Price = 100000,
    Quantity = 6
};


Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 3200M,
    Quantity = 17.5F  /*  17 kilos y medio de carne*/ 
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);





