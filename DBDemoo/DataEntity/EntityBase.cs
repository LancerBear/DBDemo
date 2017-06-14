using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDemo.DataEntity
{
	public class EntityBase
	{
		public virtual List<EntityBase> readDataSet(MySqlDataReader reader)
		{
			return null;
		}
	}
}