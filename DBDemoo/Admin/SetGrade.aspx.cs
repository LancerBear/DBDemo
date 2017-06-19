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
		protected void Page_Load(object sender, EventArgs e)
		{
			Master.FindControl("AdminBar").Visible = true;
			Master.FindControl("NavBar").Visible = false;
		}

		protected void submit_Click(object sender, EventArgs e)
		{
			string sid = this.stuIDTB.Text;
			string cno = this.cnoTB.Text;
			int grade = int.Parse(this.gradeTB.Text);
			string sql = "update sc set grade = " + grade + " where sid = \"" + sid + "\" and cno = \"" + cno + "\"";
			//Response.Write(sql);
			DBconnetor conn = new DBconnetor(sql);
			conn.updata();
		}
	}
}