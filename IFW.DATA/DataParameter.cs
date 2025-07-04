using System.Data;

namespace IFW.Data
{
    public class DataParameter
    {
        public string Name { get; set; }
        public SqlDbType Type { get; set; }
        public int Size { get; set; }
        public object Value { get; set; }

        // 기존 생성자 (2개짜리)
        public DataParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        // ✅ 추가된 생성자 (4개짜리) → 이걸 써야 Add(name, SqlDbType, size, value)가 작동함
        public DataParameter(string name, SqlDbType type, int size, object value)
        {
            Name = name;
            Type = type;
            Size = size;
            Value = value;
        }
    }
}