using DBDemo.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Admin
{
	public partial class SetGrade : System.Web.UI.Page
	{
		static List<EntityBase> list;
		protected void Page_Load(object sender, EventArgs e)
		{
			Master.FindControl("AdminBar").Visible = true;
			Master.FindControl("NavBar").Visible = false;
		}

		protected void submit_Click(object sender, EventArgs e)
		{
			if (this.gradeTB.Text == "")
			{
				Response.Write("<script>alert('请填写成绩!')</script>");
				//Response.Redirect("../Admin/SetGrade.aspx");
			}
			else
			{

				string sid = this.stuIDTB.Text;
				bool flag = false;
				int grade = int.Parse(this.gradeTB.Text);
				if (grade < 0 || grade > 100)
				{
					Response.Write("<script>alert('成绩不合法!')</script>");
				}
				else
				{
					foreach (ListItem li in RadioButtonList1.Items)
					{
						if (li.Selected)
						{
							flag = true;
							foreach (EntityCour c in list)
							{
								if (c.getCname() == li.Value.ToString())
								{
									string sql = "update sc set grade = " + grade + " where sid = \"" + sid + "\" and cno = \"" + c.getCno() + "\"";
									Response.Write(sql);
									DBconnetor conn = new DBconnetor(sql);
									conn.updata();
								}
							}
						}
					}
					if (flag == false)
					{
						Response.Write("<script>alert('请选择课程!')</script>");
						//Response.Redirect("../Admin/SetGrade.aspx");
					}
				}
			}	
		}

		protected void stuIDTB_TextChanged(object sender, EventArgs e)
		{
			
		}

		protected void submitIDBt_Click(object sender, EventArgs e)
		{
			string sid = this.stuIDTB.Text;
			string sql = "select c.* from c,sc where sc.cno = c.cno and sid = \"" + sid + "\"";
			DBconnetor conn = new DBconnetor(sql);
			list = conn.getList(new EntityCour());
			if (list == null)
			{
				Response.Write("<script>alert('数据查询失败!')</script>");
			}
			else if (list.Count() == 0)
			{
				Response.Write("<script>alert('该生没有选课!')</script>");
			}
			//if (!IsPostBack)
			{
				this.RadioButtonList1.Items.Clear();
				foreach (EntityCour c in list)
				{
					this.RadioButtonList1.Items.Add(c.getCname());
				}
			}
		}
	}
}