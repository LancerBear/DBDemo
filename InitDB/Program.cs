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
			connection.Open();
			string[] c = { "C语言", "C++", "JAVA", "数据结构", "计算机组成原理", "编译原理", "操作系统", "数据库原理", "嵌入式系统", "微机接口原理" };
			double[] credit = { 2.0, 2.0, 2.0, 3.5, 3.0, 3.0, 3.5, 2.5, 1.0, 3.5 };
			string cInit;
			for (int i = 1; i < 100000; i++)
			{
				string sid = i.ToString();
				//byte[] result = Encoding.Default.GetBytes(sid);
				//MD5 md5 = new MD5CryptoServiceProvider();
				//byte[] output = md5.ComputeHash(result);
				//string pwd = BitConverter.ToString(output).Replace("-", "");

				//String pwdInit = "insert into pwd values(\"" + sid + "\", \"" + pwd.ToLower() + "\")";
				//Console.WriteLine(pwdInit);
				//command = new MySqlCommand(pwdInit, connection);
				
				//string[] sex = {"男", "女"};
				//string[] name = { "Mark", "Lucy" };
				//Random rd = new Random();
				//int index = rd.Next(0, 2);
				//string sInit = "insert into s values(\"" + sid + "\", \"" + name[index] + "\", \"" + sex[index] + "\", \"" + "19960101" + "\", \"" + "计算机学院\"" + ")";
				//Console.WriteLine(sInit);
				//command = new MySqlCommand(sInit, connection);
				//command.ExecuteNonQuery();
				for (int j = 1; j <= 10; j++)
				{
					cInit = "insert into sc(sid, cno) values (\"" + i.ToString() + "\", \"" + j.ToString() + "\")";
					command = new MySqlCommand(cInit, connection);
					command.ExecuteNonQuery();
					Console.WriteLine(cInit);
				}

			}
			//string[] c = { "C语言", "C++", "JAVA", "数据结构", "计算机组成原理", "编译原理", "操作系统", "数据库原理", "嵌入式系统", "微机接口原理" };
			//double[] credit = { 2.0, 2.0, 2.0, 3.5, 3.0, 3.0, 3.5, 2.5, 1.0, 3.5 };
			//string cInit;
			//for (int j = 0; j < 10; j++)
			//{
			//	cInit = "insert into c values (\"" + (j + 1).ToString() + "\", \"" + c[j] + "\", \"" + credit[j].ToString() + "\")";
			//	command = new MySqlCommand(cInit, connection);
			//	command.ExecuteNonQuery();
			//	Console.WriteLine(cInit);
			//}
			connection.Close();
		}
	}
}
