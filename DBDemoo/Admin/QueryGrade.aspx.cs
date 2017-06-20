using DBDemo.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Admin
{
	public partial class QueryGrade : PageBase
	{
		static List<EntityBase> list;
		protected override void Page_Load(object sender, EventArgs e)
		{
			base.Page_Load(sender, e);
			Master.FindControl("AdminBar").Visible = true;
			Master.FindControl("NavBar").Visible = false;
			string sql = "select distinct * from c";
			DBconnetor conn = new DBconnetor(sql);
			list = conn.getList(new EntityCour());
			if (!IsPostBack)
			{
				foreach (EntityCour c in list)
				{
					this.RadioButtonList1.Items.Add(c.getCname());
				}
			}
		}

		protected void queryAvgBt_Click(object sender, EventArgs e)
		{
			foreach (ListItem li in RadioButtonList1.Items)
			{
				if (li.Selected)
				{
					foreach(EntityCour c in list)
					{
						if (c.getCname() == li.Value.ToString())
						{
							string avgSql = "select sid, cno, avg(grade) from sc_v" + c.getCno();
							//Response.Write(avgSql);
							DBconnetor conn = new DBconnetor(avgSql);
							List<EntityBase> avgList = conn.getList(new EntitySC());
							EntitySC sc = (EntitySC)avgList.ElementAt(0);
							this.AvgLable.Text = sc.getGrade().ToString();

							string maxSql = "select sid, cno, max(grade) from sc_v" + c.getCno();
							//Response.Write(maxSql);
							DBconnetor conn1 = new DBconnetor(maxSql);
							List<EntityBase> maxList = conn1.getList(new EntitySC());
							sc = (EntitySC)maxList.ElementAt(0); 
							this.MaxLable.Text = sc.getGrade().ToString();

							string minSql = "select sid, cno, min(grade) from sc_v" + c.getCno();
							//Response.Write(minSql);
							DBconnetor conn2 = new DBconnetor(minSql);
							List<EntityBase> minList = conn2.getList(new EntitySC());
							sc = (EntitySC)minList.ElementAt(0);
							this.MinLable.Text = sc.getGrade().ToString();
						}
					}
					 
				}
			}
		}
	}
}