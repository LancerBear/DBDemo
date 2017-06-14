using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBDemo.DataEntity;
using System.Text;
using System.Security.Cryptography;
using DBDemo;

namespace DBDemo.Acount
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["ID"] != null)
				Master.FindControl("NavBar").Visible = true;
			else
				Master.FindControl("NavBar").Visible = false;
		}

		protected void submit_Click(object sender, EventArgs e)
		{
			byte[] result = Encoding.Default.GetBytes(this.txtPassWord.Text);   
			MD5 md5 = new MD5CryptoServiceProvider();
			byte[] output = md5.ComputeHash(result);
			string pwd = BitConverter.ToString(output).Replace("-","");
			pwd = pwd.ToLower();
			string sqlSentence = "select * from pwd where sid = \"" + this.txtUserName.Text + "\"";
			DBconnetor conenctor = new DBconnetor(sqlSentence);
			List<EntityBase> list = conenctor.getList(new EntityPwd());
			if (list.Count() == 0)
			{
				Response.Write("<script>alert('学号或密码错误!')</script>");
			}
			else
			{
				EntityPwd entity = (EntityPwd)list.ElementAt(0);
				if (entity.getPwd() == pwd)
				{
					Session["ID"] = this.txtUserName.Text;
					Response.Redirect("~/Share/Welcome.aspx");
				}
				else
				{
					Response.Write("<script>alert('学号或密码错误!')</script>");
				}
			}
		}
	}
}