using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebViewTest
{
    public class CandPDAL
    {
        private static SqlConnection conn = new SqlConnection(DALC.sqlConn);

        public static DataView GetInfo()
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            string parsedCommand = "SELECT * FROM CandP";

            SqlCommand cmd = new SqlCommand(parsedCommand, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count == 0) return null;
            return ds.Tables[0].DefaultView;
        }

        public static DataView GetInfo(string CategoryName, string UnitPrice, string ProductName)
        {
            if (conn.State != ConnectionState.Open) conn.Open();
            string parsedCommand = "SELECT * FROM CandP WHERE";
            int currentParam = 0;

            if (CategoryName != "")
            {
                currentParam++;
                parsedCommand += " CategoryName = @CategoryName";
            }
            if (UnitPrice != "")
            {
                currentParam++;
                if (currentParam > 1)
                {
                    parsedCommand += " AND UnitPrice = @UnitPrice";
                }
                else
                {
                    parsedCommand += " UnitPrice = @UnitPrice";
                }
            }
            if (ProductName != "")
            {
                currentParam++;
                if (currentParam > 1)
                {
                    parsedCommand += " AND ProductName = @ProductName";
                }
                else
                {
                    parsedCommand += " ProductName = @ProductName";
                }
            }

            SqlCommand cmd = new SqlCommand(parsedCommand, conn);

            if (CategoryName != "") cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            if (UnitPrice != "") cmd.Parameters.AddWithValue("@UnitPrice", int.Parse(UnitPrice));
            if (ProductName != "") cmd.Parameters.AddWithValue("@ProductName", ProductName);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count == 0) return null;
            return ds.Tables[0].DefaultView;
        }
    }
}