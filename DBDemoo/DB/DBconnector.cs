using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBDemo.DataEntity;

namespace DBDemo
{
	class DBconnetor
	{
		private MySqlConnection connection;
		private MySqlCommand command;

		public DBconnetor(string sqlSentence)
		{
			String mysqlStr = "Database=DBDemo;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
			connection = new MySqlConnection(mysqlStr);
			command = new MySqlCommand(sqlSentence, connection);
		}

		public List<EntityBase> getList(EntityBase entity)
		{
			try
			{
				connection.Open();
			}
			catch (Exception)
			{
				Console.WriteLine("DB open failed!");
				return null;
			}
			MySqlDataReader reader = command.ExecuteReader();
			List<EntityBase> list = entity.readDataSet(reader);
			return list;
		}
	}
}