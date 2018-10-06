using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
namespace Phone
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string strUid = txtAccount.Text.Trim();
        //    string strPwd = txtPwd.Text.Trim();

        //    //如果用户名或密码为空
        //    if (strUid == String.Empty || strPwd == String.Empty)
        //    {
        //        return;
        //    }

        //    //密码加密
        //    strPwd = Common.MD5Util.GetMD5_32(strPwd).ToUpper();

        //    //Sql语句
        //    string strSql = String.Format("select * from User where Uid = '{0}' and Password = '{1}'",
        //        strUid,strPwd);

        //    //数据库连接串
        //    string _connectionString = ConfigurationManager.AppSettings["ConfigurationString"];

        //    //数据库连接对象
        //    SqlConnection conn = new SqlConnection(_connectionString);

        //    try
        //    {
        //        //打开数据库
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand(strSql, conn);

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        DataSet ds = new DataSet();
        //        da.Fill(ds);

        //        //返回记录的行数
        //        int nRow = ds.Tables[0].Rows.Count;

        //        //验证成功
        //        if (nRow == 1)
        //        {
        //            //页面跳转
        //            Response.Redirect("MainFrame.aspx");
        //        }


        //    }
        //    catch (SqlException ex)
        //    {
        //        //
        //    }
        //    finally
        //    {
        //        //关闭数据库连接
        //        conn.Close();
        //    }
        //}
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUid = txtAccount.Text.Trim();
            string strPwd = txtPwd.Text.Trim();

            //如果用户名或密码为空
            if (strUid == String.Empty || strPwd == String.Empty)
            {
                return;
            }

            //密码加密
            strPwd = Common.MD5Util.GetMD5_32(strPwd).ToUpper();

            //Sql语句
            string strSql = String.Format("select * from Us where Uno = '{0}' and Upassword = '{1}'",
                strUid, strPwd);

            //数据库连接串
            string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
       
            //数据库连接对象
            SqlConnection conn = new SqlConnection(_connectionString);

            try
            {
                //打开数据库
                conn.Open();

                SqlCommand cmd = new SqlCommand(strSql, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                //返回记录的行数
                int nRow = ds.Tables[0].Rows.Count;

                //验证成功
                if (nRow == 1)
                {
                    //页面跳转
                    Response.Redirect("register.aspx");
                }


            }
            catch (SqlException ex)
            {
                //
            }
            finally
            {
                //关闭数据库连接
                conn.Close();
            }

        }
    }
}