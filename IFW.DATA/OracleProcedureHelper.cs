using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace IFW.Data
{
    public class OracleProcedureHelper
    {
        private readonly string connectionString;

        public OracleProcedureHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["OracleDb"].ConnectionString;
        }

        // OUT 커서 반환 프로시저 호출
        public DataTable ExecuteProcedureWithCursor(string procName, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                using (var cmd = new OracleCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    // OUT 커서 파라미터 추가
                    var cursor = new OracleParameter("OUT_CURSOR", OracleDbType.RefCursor, ParameterDirection.Output);
                    cmd.Parameters.Add(cursor);

                    using (var adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // 결과값 없는 프로시저 호출
        public int ExecuteProcedureNonQuery(string procName, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                using (var cmd = new OracleCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}