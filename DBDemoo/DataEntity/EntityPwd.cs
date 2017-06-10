using DBDemo.DataEntity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDemo.DataEntity
{
	public class EntityPwd : EntityBase
	{
		private string sid;
		private string pwd;
		public EntityPwd()
		{

		}
		public EntityPwd(string ss, string pp)
		{
			this.sid = ss;
			this.pwd = pp;
		}
		public void setSid(string ss)
		{
			this.sid = ss;
		}
		public void setPwd(string pp)
		{
			this.pwd = pp;
		}
		public string getSid()
		{
			return this.sid;
		}
		public string getPwd()
		{
			return this.pwd;
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
						EntityPwd entity = new EntityPwd();

						entity.setSid(reader.GetString(0));
						entity.setPwd(reader.GetString(1));
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