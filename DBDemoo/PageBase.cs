using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBDemo
{
	public class PageBase : System.Web.UI.Page
	{
		protected virtual void Page_Load(object sender, EventArgs e)
		{
			if (Session["ID"] == null)
			{
				Response.Redirect("~/Account/Login.aspx");
			}
		}
	}
}