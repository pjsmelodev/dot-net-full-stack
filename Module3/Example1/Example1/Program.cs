using Example1;

SavingsAccount savingsAccount = new SavingsAccount();

savingsAccount.Deposit();
savingsAccount.Withdraw();
savingsAccount.Balance();
savingsAccount.GetMessage();

Console.WriteLine("--------------------------------------------------");

SavingAcc savingAcc = new SavingAcc();
savingAcc.OpenAccount();
savingAcc.Deposit();
savingAcc.Withdraw();
savingAcc.Balance();
savingAcc.CloseAccount();

Console.ReadKey();