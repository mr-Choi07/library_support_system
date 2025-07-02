using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace library_support_system
{

    public class OracleProcedureHelper
    {
        private string connectionString = "Data Source=localhost:1521/xe;User ID=system;Password=1234;";

        // 프로시저 호출 및 결과 DataTable 반환 (OUT 커서 사용)
        public DataTable ExecuteProcedureWithCursor(string procName, params OracleParameter[] parameters)
        {
            using (var conn = new OracleConnection(connectionString))
            {
                using (var cmd = new OracleCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);

                    // 커서 파라미터 추가 (필요시)
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

        // 프로시저 호출(결과값 없는 경우)
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
