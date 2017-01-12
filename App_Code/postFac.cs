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
    public int _postnr { get; set; }
    public string _bynavn { get; set; }

    public DataTable getpost()
    {
        cmd = new SqlCommand("SELECT * FROM tblPostInfo");
        return DA.GetData(cmd);
    }
    public DataRow getpost2()
    {
        cmd = new SqlCommand("SELECT TOP 1 fldID FROM tblPostInfo ORDER BY fldID DESC");
        return DA.GetDataRow(cmd);
    }
    public DataTable GetPostByNr(string key)
    {
        cmd = new SqlCommand("SELECT fldID,fldPostNr,fldByNavn FROM tblPostInfo WHERE fldID LIKE @key OR fldPostNr LIKE @key OR fldByNavn LIKE @key");
        cmd.Parameters.AddWithValue("@key", key + "%");
        return DA.GetData(cmd);
    }
    public void insert ()
    {
        cmd = new SqlCommand("INSERT INTO tblPostInfo (fldPostNr, fldByNavn) VALUES (@postnr, @bynavn)");
        cmd.Parameters.AddWithValue("@postnr", _postnr);
        cmd.Parameters.AddWithValue("@bynavn", _bynavn);
        DA.ModifyData(cmd);
    }
}