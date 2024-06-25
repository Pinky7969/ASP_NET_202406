//1. 資料來源
string[] names = ["Mary", "Cindy", "Alice", "Janet", "Amy"];

//2. 定義查詢
var query = from name in names
            //where name.Contains("A")
            orderby name
            select name;

//3. 執行查詢
foreach (var item in query)
{
    Console.Write(item + " ");
}