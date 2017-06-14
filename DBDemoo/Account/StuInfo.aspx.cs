using DBDemo.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBDemo.Account
{
	public partial class StuInfo : PageBase
	{
		protected override void Page_Load(object sender, EventArgs e)
		{
			base.Page_Load(sender, e);

			string sqlSentence = "select * from s where sid = \"" + Session["ID"] + "\"";
			DBconnetor conn = new DBconnetor(sqlSentence);
			List<EntityBase> list = conn.getList(new EntityStu());
			if (list == null || list.Count() == 0)
			{
				Response.Write("<script>alert('信息查询错误！')</script>");
				return;
			}
			else
			{
				EntityStu entity = (EntityStu)list.ElementAt(0);
				this.sidLable.Text = entity.getSid();
				this.snameLable.Text = entity.getSname();
				this.ssexLable.Text = entity.getSsex();
				this.sbirthLable.Text = entity.getSbirth();
				this.sdeptLable.Text = entity.getSdept();
			}
		}

	}
}