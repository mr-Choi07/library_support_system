 using System.Configuration; // 추가
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace library_support_system
{
    public class OracleConnector
    {
        private string connectionString;

        public OracleConnector()
        {
            // App.config의 name="OracleDb"와 일치해야 함
            connectionString = ConfigurationManager.ConnectionStrings["OracleDb"].ConnectionString;
        }

        public DataTable ExecuteQuery(string sql)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand(sql, conn))
                {
                    using (var adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new OracleCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}