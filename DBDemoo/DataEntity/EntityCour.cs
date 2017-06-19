using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDemo.DataEntity
{
	public class EntityCour : EntityBase
	{
		private string Cname;
		private float Ccredit;
		private string Cno;

		public string getCname()
		{
			return this.Cname;
		}
		public string getCno()
		{
			return this.Cno;
		}
		public float getCcredit()
		{
			return this.Ccredit;
		}

		private void setCname(string cn)
		{
			this.Cname = cn;
		}
		private void setCno(string c)
		{
			this.Cno = c;
		}
		private void setCcredit(float c)
		{
			this.Ccredit = c;
		}

		public string toString()
		{
			string res =  "\t\t课程号:" + this.getCno() + "\t\t课程名:" + this.getCname() + "\t\t学分:" + this.getCcredit();
			return res;
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
						EntityCour entity = new EntityCour();

						entity.setCno(reader.GetString(0));
						entity.setCname(reader.GetString(1));
						entity.setCcredit(reader.GetFloat(2));
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