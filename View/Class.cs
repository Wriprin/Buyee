using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace View
{
    public static class Class
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string strConn = "Data Source=.;User Id=sa;Pwd=sasa;Initial Catalog=MyDb";

        /// <summary>
        /// 执行SQL语句返回影响行数,通常为Inser,Update和Delete命令
        /// </summary>
        /// <param name="SQL">SQL语句</param>
        /// <returns>影响行数</returns>
        public static int ExcuteSQL(string SQL)
        {
            int rst = -1;
            SqlConnection objConn = new SqlConnection(strConn);
            objConn.Open();
            SqlCommand objCmd = new SqlCommand(SQL, objConn);
            rst = objCmd.ExecuteNonQuery();
            objConn.Close();
            return rst;
        }

        /// <summary>
        /// 执行SQL语句返回数据集，SQL语句通常为SELECT
        /// </summary>
        /// <param name="SQL">SQL语句</param>
        /// <returns>查询结果数据集</returns>
        public static DataSet CreateDataSet(string SQL)
        {
            SqlDataAdapter objDa = new SqlDataAdapter(SQL, strConn);
            DataSet objDs = new DataSet();
            objDa.Fill(objDs);
            return objDs;
        }

    }
}
