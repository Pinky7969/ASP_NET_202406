// 2. 建立陣列包含SavingsAccount和CreditCardAccount
Account[] accounts = [
    new SavingsAccount(1, "SavingsAccount 1"),
    new SavingsAccount(2, "SavingsAccount 2"),
    new SavingsAccount(3, "SavingsAccount 3"),
    new SavingsAccount(4, "SavingsAccount 4"),
    new CreditCardAccount(5, "CreditCardAccount 1"),
    new CreditCardAccount(6, "CreditCardAccount 2"),
    new CreditCardAccount(7, "CreditCardAccount 3"),
];

// 3. 取得SavingsAccount
var result =accounts.OfType<CreditCardAccount>();

// 4. 顯示結果
foreach (var item in result)
{
    Console.WriteLine((item.AccountId, item.AccountName));
}


// 1. 定義資料結構
record Account(int AccountId, string AccountName);
record SavingsAccount(int AccountId, string AccountName) : Account(AccountId, AccountName);
record CreditCardAccount(int AccountId, string AccountName) : Account(AccountId, AccountName);
