using Microsoft.Data.SqlClient;
using System.Data;

string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True;encrypt=false;";

//1.建立Connection物件
using var cn = new SqlConnection(connectionString);

//2.建立SqlDataAdapter物件
var da = new SqlDataAdapter("SELECT * FROM region", cn);

//3.建立DataTable物件
var dt = new DataTable("Region");
// 若要進行多次Query, 可手動 Open connection, 最後結束再手動 Close
//cn.Open(); 
Console.WriteLine(cn.State);
//4.將資料填入DataTable: DB connection 會 Open --> Query --> Close
da.Fill(dt);
Console.WriteLine(cn.State);
//cn.Close();
Console.WriteLine(cn.State);

//5.顯示DataTable資料
foreach (DataRow row in dt.Rows)
{
    Console.WriteLine((row[0], row["RegionDescription"].ToString()?.Trim()));
}

