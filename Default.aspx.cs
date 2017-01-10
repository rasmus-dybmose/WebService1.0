using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    postFac objpost = new postFac();
    DataTable dt = new DataTable();
    StringBuilder sb = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt = objpost.getpost();

            foreach (DataRow item in dt.Rows)
            {
                sb.AppendFormat("<p>{0}</p>", item["fldPostNr"]);
            };
            litResult.Text = sb.ToString();
            sb.Clear();
        }
    }
}