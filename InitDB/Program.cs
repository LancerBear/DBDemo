using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InitDB
{
	class Program
	{
		static void Main(string[] args)
		{
			MySqlConnection connection;
			MySqlCommand command;
			String mysqlStr = "Database=DBDemo;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
			connection = new MySqlConnection(mysqlStr);
			for (int i = 1; i < 100000; i++)
			{
				string sid = i.ToString();
				byte[] result = Encoding.Default.GetBytes(sid);   
				MD5 md5 = new MD5CryptoServiceProvider();
				byte[] output = md5.ComputeHash(result);
				string pwd = BitConverter.ToString(output).Replace("-","");

				String pwdInit = "insert into pwd values(\"" + sid + "\", \"" + pwd.ToLower() + "\")";
				Console.WriteLine(pwdInit);
				command = new MySqlCommand(pwdInit, connection);
				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			
		}
	}
}
