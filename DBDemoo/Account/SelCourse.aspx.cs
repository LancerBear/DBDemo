using DBDemo.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Account
{
	public partial class SelCourse : PageBase
	{
		protected override void Page_Load(object sender, EventArgs e)
		{
			base.Page_Load(sender, e);
			string sqlSentence = "select c.* from sc, c where sc.cno = c.cno and sc.sid = \"" + Session["ID"] + "\"";
			DBconnetor conn = new DBconnetor(sqlSentence);
			List<EntityBase> list = conn.getList(new EntityCour());
			if (list == null || list.Count() == 0)
			{
				Response.Write("<script>alert('信息查询失败!')</script>");
				return;
			}
			else
			{
				this.BulletedList1.Items.Clear();
				foreach (EntityCour c in list)
				{
					this.BulletedList1.Items.Add(c.getCname());
				}
			}
		}

		protected void submitButton_Click(object sender, EventArgs e)
		{

		}
	}
}