using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DoAnLapTrinhTrucQuan.Helpers
{
    /// <summary>
    /// Tiện ích kết nối và thực thi truy vấn Cơ sở dữ liệu SQL Server (ADO.NET)
    /// </summary>
    public static class DbHelper
    {
        public static string ConnectionString { get; set; } =
            "Server=localhost;Database=MocCafeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            DataTable dt = new DataTable();
            using SqlConnection conn = GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            using SqlConnection conn = GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static object? ExecuteScalar(string query, SqlParameter[]? parameters = null)
        {
            using SqlConnection conn = GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }
            conn.Open();
            return cmd.ExecuteScalar();
        }
    }
}
