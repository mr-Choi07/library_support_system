using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace IFW.Data
{
    public enum DbCommandType { ExecuteQuery, ExecuteNonQuery, ExecuteScalar }

    public class DataCommandShell : IDisposable
    {
        private readonly string _connectionString;
        private readonly List<DataCommand> _commands = new List<DataCommand>();
        public int ErrorCode { get; private set; }
        public string ErrorMessage { get; private set; }

        public DataCommandShell(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SetSpCommand(string spName, DbCommandType commandType, DataParameterCollection parameters)
        {
            var cmd = new DataCommand
            {
                CommandText = spName,
                CommandType = CommandType.StoredProcedure,
                CommandExecuteType = commandType,
                Parameters = parameters
            };
            _commands.Add(cmd);
        }

        public List<DataCommand> Execute()
        {
            ErrorCode = 0;
            ErrorMessage = string.Empty;
            foreach (var cmd in _commands)
            {
                try
                {
                    using (var conn = new OracleConnection(_connectionString))
                    using (var oracleCmd = new OracleCommand(cmd.CommandText, conn))
                    {
                        oracleCmd.CommandType = cmd.CommandType;
                        foreach (var param in cmd.Parameters)
                        {
                            oracleCmd.Parameters.Add(param.Name, param.Value ?? DBNull.Value);
                        }

                        var adapter = new OracleDataAdapter(oracleCmd);
                        var ds = new DataSet();

                        if (cmd.CommandExecuteType == DbCommandType.ExecuteQuery)
                        {
                            adapter.Fill(ds);
                            cmd.DataSet = ds;
                        }
                        else if (cmd.CommandExecuteType == DbCommandType.ExecuteNonQuery)
                        {
                            conn.Open();
                            cmd.AffectedRows = oracleCmd.ExecuteNonQuery();
                        }
                        else if (cmd.CommandExecuteType == DbCommandType.ExecuteScalar)
                        {
                            conn.Open();
                            cmd.ScalarValue = oracleCmd.ExecuteScalar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorCode = -1;
                    ErrorMessage = ex.Message;
                    cmd.ErrorCode = ErrorCode;
                    cmd.ErrorMessage = ErrorMessage;
                }
            }
            return _commands;
        }

        public void Dispose()
        {
            // 필요시 리소스 정리
        }
    }
}