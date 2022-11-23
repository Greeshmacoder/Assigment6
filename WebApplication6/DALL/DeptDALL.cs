using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication6.BAL;

namespace WebApplication6.DALL
{
    public class DeptDALL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DeptDALL()

        {


            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }

        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int deptmentInsert(BAL.DeptBAL obj)
        {
            string qry = "insert into Des values ('" + obj.Desginationname + "','" + obj.Depid + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewDepartment()
        {
            string s = "Select * from Des";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int departmentupdate(BAL.DeptBAL obj)
        {
            string s = "update Des set Designationname='" + obj.Desginationname + "'where Desid='" + obj.Desid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int departmentdelet(BAL.DeptBAL obj)
        {
            string s = "delete from Des where Desid='" + obj.Desid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable GetProductDetails(BAL.DeptBAL obj)
        {
            string s = "Select * from dep";
            SqlCommand cmd = new SqlCommand(s, Getcon());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}