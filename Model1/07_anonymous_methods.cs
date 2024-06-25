using System.ComponentModel;
using System.Reflection;

Account account = new();
//3. 訂閱事件
//account.ProgressChanged += delegate(object ? sender, ProgressChangedEventArgs e)
//{
//    Console.WriteLine(e.ProgressPercentage + "%");
//};

account.ProgressChanged += delegate
{
    Console.WriteLine($"處理中...");
};

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
