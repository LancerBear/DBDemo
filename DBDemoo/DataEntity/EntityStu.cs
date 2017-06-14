using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDemo.DataEntity
{
	public class EntityStu : EntityBase
	{
		private string sid;
		private string sname;
		private string ssex;
		private string sbirth;
		private string sdept;

		public EntityStu()
		{

		}

		public string getSid()
		{
			return this.sid;
		}
		public string getSname()
		{
			return this.sname;
		}
		public string getSsex()
		{
			return this.ssex;
		}
		public string getSbirth()
		{
			return this.sbirth;
		}
		public string getSdept()
		{
			return this.sdept;
		}

		private void setSid(string s)
		{
			this.sid = s;
		}
		private void setSname(string name)
		{
			this.sname = name;
		}
		private void setSsex(string s)
		{
			this.ssex = s;
		}
		private void setSbirth(DateTime b)
		{

			this.sbirth = b.ToShortDateString();
		}
		private void setSdept(string d)
		{
			this.sdept = d;
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
						EntityStu entity = new EntityStu();

						entity.setSid(reader.GetString(0));
						entity.setSname(reader.GetString(1));
						entity.setSsex(reader.GetString(2));
						entity.setSbirth(reader.GetDateTime(3));
						entity.setSdept(reader.GetString(4));
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