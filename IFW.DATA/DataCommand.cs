using System.Data;

namespace IFW.Data
{
    public class DataCommand
    {
        /// <summary>
        /// 실행할 명령문(프로시저명 또는 쿼리)
        /// </summary>
        public string CommandText { get; set; }

        /// <summary>
        /// 명령 타입 (StoredProcedure, Text 등)
        /// </summary>
        public CommandType CommandType { get; set; }

        /// <summary>
        /// 명령 실행 방식 (ExecuteQuery, ExecuteNonQuery, ExecuteScalar 등)
        /// </summary>
        public DbCommandType CommandExecuteType { get; set; }

        /// <summary>
        /// 파라미터 컬렉션
        /// </summary>
        public DataParameterCollection Parameters { get; set; }

        /// <summary>
        /// 실행 결과 DataSet (SELECT/프로시저 결과 등)
        /// </summary>
        public DataSet DataSet { get; set; }

        /// <summary>
        /// NonQuery 실행 시 영향받은 행 수
        /// </summary>
        public int AffectedRows { get; set; }

        /// <summary>
        /// Scalar 실행 시 반환값
        /// </summary>
        public object ScalarValue { get; set; }

        /// <summary>
        /// 오류 코드 (0: 정상, 음수: 시스템 오류, 양수: 사용자 오류)
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// 오류 메시지
        /// </summary>
        public string ErrorMessage { get; set; }

        public DataCommand()
        {
            Parameters = new DataParameterCollection();
            DataSet = null;
            ErrorCode = 0;
            ErrorMessage = string.Empty;
        }
    }
}