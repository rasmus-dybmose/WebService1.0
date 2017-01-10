using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<postFac> hentpostinfo(string key)
    {
        postFac objpost = new postFac();
        DataTable dt = new DataTable();
        dt = objpost.GetPostByNr(key);

        List<postFac> postnumre = new List<postFac>();

        foreach (DataRow item in dt.Rows)
        {
            objpost = new postFac();
            objpost._id = Convert.ToInt32(item["fldID"]);
            objpost._postnr = item["fldPostNr"].ToString();
            objpost._bynavn = item["fldByNavn"].ToString();
            postnumre.Add(objpost);
        };
        return postnumre;
    }


}
