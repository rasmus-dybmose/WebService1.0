using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for postFac
/// </summary>
public class postFac
{
    DataAccess DA = new DataAccess();
    SqlCommand cmd = new SqlCommand();

    public int _id { get; set; }
    public string _postnr { get; set; }
    public string _bynavn { get; set; }

    public DataTable getpost()
    {
        cmd = new SqlCommand("SELECT * FROM tblPostInfo");
        return DA.GetData(cmd);
    }
    public DataTable GetPostByNr(string key)
    {
        cmd = new SqlCommand("SELECT fldID,fldPostNr,fldByNavn FROM tblPostInfo WHERE fldID LIKE @key OR fldPostNr LIKE @key OR fldByNavn LIKE @key");
        cmd.Parameters.AddWithValue("@key", key + "%");
        return DA.GetData(cmd);
    }
}