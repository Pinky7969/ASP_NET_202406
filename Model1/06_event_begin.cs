using System.ComponentModel;

Account account = new();
//3. 訂閱事件
account.ProgressChanged += Account_ProgressChanged;

//4. 事件處理函式
void Account_ProgressChanged(object? sender, ProgressChangedEventArgs e)
{
    Console.WriteLine(e.ProgressPercentage + "%");
}


Console.WriteLine("交易明細列印開始");
account.PrintTransactions();

class Account
{
    //1. 定義事件
    public event EventHandler<ProgressChangedEventArgs>? ProgressChanged;
    public void PrintTransactions()
    {
        for (int i = 1; i <= 10; i++)
        {
            //模擬查詢並列印交易明細...
            Thread.Sleep(300);
            //2. 觸發事件
            ProgressChanged?.Invoke(this, new ProgressChangedEventArgs(i * 10, null));
        }
        Console.WriteLine("交易明細列印完畢!");
    }
}
