using Microsoft.Data.SqlClient;

string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True;encrypt=false;";

//1.建立Connection物件
using var cn = new SqlConnection(connectionString);
cn.Disposed += (s, e) => Console.WriteLine((3, cn.State));

//2.建立SqlCommand物件
var cmd = new SqlCommand("SELECT * FROM region", cn);

cn.Open();

//3.建立DataReader物件
using var reader = cmd.ExecuteReader();

//4.讀取資料
while (reader.Read())
{
    Console.WriteLine(reader[0] + " " + reader["RegionDescription"]);
}

Console.WriteLine((1, cn.State));
Console.WriteLine((2, "end"));
