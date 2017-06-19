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
		List<EntityBase> list;
		List<EntityBase> leftList;
		protected override void Page_Load(object sender, EventArgs e)
		{
			base.Page_Load(sender, e);
			Master.FindControl("NavBar").Visible = true;
			Master.FindControl("AdminBar").Visible = false;
			string sqlSentence = "select c.* from sc, c where sc.cno = c.cno and sc.sid = \"" + Session["ID"] + "\"";
			DBconnetor conn = new DBconnetor(sqlSentence);
			list = conn.getList(new EntityCour());


			string leftListSql = "select distinct * from c where cno not in (select c.cno from c,sc where c.cno = sc.cno and sid = \"" + Session["ID"] + "\")";
			DBconnetor conn2 = new DBconnetor(leftListSql);
			leftList = conn2.getList(new EntityCour());

			if (list == null || leftList == null)
			{
				Response.Write("<script>alert('信息查询失败!')</script>");
				return;
			}
			else
			{
				if (!IsPostBack)
				{
					foreach (EntityCour c in list)
					{
						this.CheckBoxList2.Items.Add(c.getCname());
					}

					foreach (EntityCour c in leftList)
					{
						this.CheckBoxList1.Items.Add(c.getCname());
					}
				}
			}
		}

		protected void submitButton_Click(object sender, EventArgs e)
		{
			foreach(ListItem li in CheckBoxList1.Items)
			{
				if (li.Selected)
				{
					foreach(EntityCour c in leftList)
					{
						if (li.Value.ToString() == c.getCname())
						{
							string sql = "insert into sc(sid, cno) values(\"" + Session["ID"] + "\", \"" + c.getCno() + "\")";
							Response.Write(sql);
							DBconnetor coon = new DBconnetor(sql);
							coon.updata();
						}
					}
				}
			}
			Response.Redirect("../Account/SelCourse.aspx");
		}

		protected void DeSelectButton_Click(object sender, EventArgs e)
		{
			foreach (ListItem li in CheckBoxList2.Items)
			{
				if (li.Selected)
				{
					foreach (EntityCour c in list)
					{
						if (li.Value.ToString() == c.getCname())
						{
							string sql = "delete from sc where sid = \"" + Session["ID"] + "\" and cno = \"" + c.getCno() + "\""; 
							Response.Write(sql);
							DBconnetor coon = new DBconnetor(sql);
							coon.updata();
						}
					}
				}
			}
			Response.Redirect("../Account/SelCourse.aspx");
		}



		protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		

	}
}