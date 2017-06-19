using DBDemo.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Admin
{
	public partial class AddCour : System.Web.UI.Page
	{
		List<EntityBase> list;
		protected void Page_Load(object sender, EventArgs e)
		{
			Master.FindControl("AdminBar").Visible = true;
			Master.FindControl("NavBar").Visible = false;
			string sql = "select distinct * from c";
			DBconnetor conn = new DBconnetor(sql);
			list = conn.getList(new EntityCour());
			if (!IsPostBack)
			{
				foreach (EntityCour c in list)
				{
					this.CheckBoxList1.Items.Add(c.getCname());
				}
			}
		}

		protected void submitBt_Click(object sender, EventArgs e)
		{
			string cno = this.CnoTB.Text;
			string cname = this.CnameTB.Text;
			float ccredit = float.Parse(this.CcreditTB.Text);
			string sqlsen = "insert into c value (\"" + cno + "\", \"" + cname + "\", " + ccredit + ")";
			//Response.Write(sqlsen);
			DBconnetor conn = new DBconnetor(sqlsen);
			conn.updata();
			Response.Redirect("../Admin/AddCour.aspx");
		}

		protected void cancelCourBt_Click(object sender, EventArgs e)
		{
			foreach(ListItem li in CheckBoxList1.Items)
			{
				if (li.Selected)
				{
					foreach(EntityCour c in list)
					{
						if (c.getCname() == li.Value.ToString())
						{
							string sql = "delete from c where cno = \"" + c.getCno() + "\"";
							DBconnetor conn = new DBconnetor(sql);
							conn.updata();
						}
					}
				}
			}
			Response.Redirect("../Admin/AddCour.aspx");
		}
	}
}