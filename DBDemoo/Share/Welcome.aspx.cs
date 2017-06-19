using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Share
{
	public partial class Welcome : PageBase
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Master.FindControl("NavBar").Visible = true;
			Master.FindControl("AdminBar").Visible = false;
			base.Page_Load(sender, e);
			if (Session["ID"] != null)
			{
				Master.FindControl("AdminBar").Visible = false;
				Master.FindControl("NavBar").Visible = true;
			}
			else
			{
				Master.FindControl("NavBar").Visible = false;
				Master.FindControl("AdminBar").Visible = false;
			}
		}
	}
}