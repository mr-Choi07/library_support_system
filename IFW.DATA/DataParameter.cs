using System.Collections.Generic;

namespace IFW.Data
{
    public class DataParameter
    {
        public string Name { get; }
        public object Value { get; }

        public DataParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }

    public class DataParameterCollection : List<DataParameter>
    {
        public void Add(string name, object value)
        {
            this.Add(new DataParameter(name, value));
        }
    }
}