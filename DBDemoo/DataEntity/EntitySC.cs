using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDemo.DataEntity 
{
	public class EntitySC : EntityBase
	{
		private string sid;
		private string cno;
		private int grade;

		public string getSid()
		{
			return this.sid;
		}
		public string getCno()
		{
			return this.cno;
		}
		public int getGrade()
		{
			return this.grade;
		}

		private void setSid(string s)
		{
			this.sid = s;
		}
		private void setCno(string c)
		{
			this.cno = c;
		}
		private void setGrade(int g)
		{
			this.grade = g;
		}

		public override List<EntityBase> readDataSet(MySqlDataReader reader)
		{
			List<EntityBase> list = new List<EntityBase>();
			try
			{
				while (reader.Read())
				{
					if (reader.HasRows)
					{
						EntitySC entity = new EntitySC();

						entity.setSid(reader.GetString(0));
						entity.setCno(reader.GetString(1));
						entity.setGrade(reader.GetInt16(2));
						list.Add(entity);
					}
				}
			}
			catch (Exception)
			{
				//Console.WriteLine("查询失败了！");
				//MessageBox.Show("数据库查询失败");
			}
			finally
			{
				reader.Close();
			}
			return list;
		}
	}
}