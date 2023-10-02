using EmployeeOOP.Classes;

try
{
    int day, month, year, hours, sales;
    string firstName, lastName;
    decimal salary, hourValue, commission, baseValue;

    Console.WriteLine("OOP Application Juan Andres Gutierrez");
    Console.WriteLine("--------------------------\n");

    Console.Write("Ingresar el dia: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());


    Console.Write("Ingresar nombre: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    //Salary Employee

    Console.Write("Ingresar salario: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };
    Console.WriteLine("\nSalary Employee:\n");
    Console.WriteLine(salaryEmployee.ToString());
    Console.WriteLine("\n");

   //Hourly Employee

    Console.Write("Ingrese las horas trabajadas: ");
    hours = Int32.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor por hora: ");
    hourValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = hours,
        HourValue = hourValue,
    };

    Console.WriteLine("\nHourly Employee:\n");
    Console.WriteLine(hourlyEmployee.ToString());

    Console.WriteLine("\n");

    //Comission Employee

    Console.Write("Ingrese el porcentaje de comisión: ");
    commission = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingrese el número de ventas: ");
    sales = Convert.ToInt32(Console.ReadLine());

    CommissionEmployee commissionEmployee = new CommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentaje = commission,
      
    };

    Console.WriteLine("\nCommission Employee:\n");
    Console.WriteLine(commissionEmployee.ToString());

    Console.WriteLine("\n");

    //Base Comission Employee

    Console.Write("Ingrese el pago base: ");
    baseValue = Decimal.Parse(Console.ReadLine());

    BaseCommissionEmployee baseComissionEmployee = new BaseCommissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        CommissionPercentaje = commission,
        Sales = sales,
        Base = baseValue,
    };

    Console.WriteLine("\nBase Comission Employee:\n");
    Console.WriteLine(baseComissionEmployee.ToString());

    Console.WriteLine("\n");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}