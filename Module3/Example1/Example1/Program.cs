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

var employee = new Employee();
Console.WriteLine(employee.EmpId);
Console.WriteLine(employee.EmpName);
employee.DisplayDetails();

Console.ReadKey();