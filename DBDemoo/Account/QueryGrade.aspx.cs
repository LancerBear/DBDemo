using DBDemo.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Account
{
	public partial class QueryGrade : PageBase
	{
		static List<EntityBase> SClist;
		static List<EntityBase> CList;
		protected override void Page_Load(object sender, EventArgs e)
		{
			base.Page_Load(sender, e);
			Master.FindControl("NavBar").Visible = true;
			Master.FindControl("AdminBar").Visible = false;

			string sql = "select c.* from c,sc where sc.cno = c.cno and sid = \"" + Session["ID"] + "\"";
			DBconnetor conn = new DBconnetor(sql);
			CList = conn.getList(new EntityCour());
			if (CList.Count() == 0)
			{
				Response.Write(sql);
				Response.Write("<script>alert('选课记录为空!')</script>");
			}
			else
			{
				if (!IsPostBack)
				{
					foreach (EntityCour c in CList)
					{
						string s = "select * from sc where cno = \"" + c.getCno() + "\" and sid = \"" + Session["ID"] + "\"";
						//Response.Write(s);
						DBconnetor cc = new DBconnetor(s);
						SClist = cc.getList(new EntitySC());
						if (SClist.Count == 0 || SClist == null)
						{
							this.BulletedList1.Items.Add(c.getCname() + "\t\t\t\t成绩:\t\t\t\t" + "N/A");
						}
						else
						{
							EntitySC sc = (EntitySC)SClist.ElementAt(0);
							this.BulletedList1.Items.Add(c.getCname() + "\t\t\t\t成绩:\t\t\t\t" + sc.getGrade().ToString());
						}
					}
				}
			}
		}
	}
}