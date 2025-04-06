using Example1;

//SavingsAccount savingsAccount = new SavingsAccount();

//savingsAccount.Deposit();
//savingsAccount.Withdraw();
//savingsAccount.Balance();
//savingsAccount.GetMessage();

//Console.WriteLine("--------------------------------------------------");

//SavingAcc savingAcc = new SavingAcc();
//savingAcc.OpenAccount();
//savingAcc.Deposit();
//savingAcc.Withdraw();
//savingAcc.Balance();
//savingAcc.CloseAccount();

// A class é static, não pode ser instanciada
//Calculate calculate = new Calculate();
//Console.WriteLine("Increment: " + Calculate.Increment());
//Console.WriteLine("Increment: " + Calculate.Increment());
//Console.WriteLine("Increment: " + Calculate.Increment());

//Console.WriteLine("Decrement: " + Calculate.Decrement());

/* Extension Methods: */
//int number = 100;

//bool result = number.IsGreaterThan(1000);

//Console.WriteLine(result);

//var employee = new Employee();
//Console.WriteLine(employee.EmpId);
//Console.WriteLine(employee.EmpName);
//employee.DisplayDetails();

// Demonstrating Properties
//User user = new User();
//user.Name = "King Kochhar";
//user.Age = 34;

///*
// * Vai gerar exception
//user.Age = 14;
//*/

//Console.WriteLine(user.Name);
////user.CompanyName = "ABC";
//Console.WriteLine(user.CompanyName);
//Console.WriteLine(user.Age);

// Demonstrating Indexes
//StringIndexerType stringIndexer = new StringIndexerType();
//stringIndexer[0] = "String One";
//stringIndexer[1] = "String Two";
//stringIndexer[2] = "String Three";
//stringIndexer[3] = "String Four";

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine(stringIndexer[i]);
//}

// Demonstrating Enunmerations
//EnumDemo enumDemo = new EnumDemo();
//enumDemo.Display();

//Calculation calculation = new Calculation();
////calculation.Calculate(100, 20);
//calculation.Calculate(100, 0);

//calculation.CalculateAnother();

var obj = new
{
    firstName = "King",
    lastName = "Kochhar",
    salary = 12000,
    address = new
    {
        streetName = "Civil Lines",
        city = "Delhi"
    }
};

Console.WriteLine(obj.firstName);
Console.WriteLine(obj.lastName);
Console.WriteLine(obj.salary);
Console.WriteLine(obj.address.streetName);
Console.WriteLine(obj.address.city);

Console.ReadKey();