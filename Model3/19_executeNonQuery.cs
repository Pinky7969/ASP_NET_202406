using Microsoft.Data.SqlClient;

string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=Northwind;Integrated Security=True;encrypt=false;";

//1.建立Connection物件
using var cn = new SqlConnection(connectionString);

cn.Open();
//2.建立SqlCommand物件
var cmd = new SqlCommand("insert into region values (@regionid, @regiondescription)", cn);
cmd.Parameters.AddWithValue("@regionid", 9);
cmd.Parameters.AddWithValue("@regiondescription", "123");

int rseult = cmd.ExecuteNonQuery();
Console.WriteLine("Records affested: " + rseult);
