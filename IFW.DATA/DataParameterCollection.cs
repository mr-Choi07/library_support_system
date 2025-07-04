using System.Collections.Generic;
using System.Data;

namespace IFW.Data
{
    
    public class DataParameterCollection : List<DataParameter>
    {
        public void Add(string name, object value)
        {
            this.Add(new DataParameter(name, value));
        }

        public void Add(string name, SqlDbType type, int size, object value)
        {
            this.Add(new DataParameter(name, type, size, value));
        }
    }
}