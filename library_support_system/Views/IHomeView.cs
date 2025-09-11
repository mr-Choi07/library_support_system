using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_support_system.Views
{
    public interface IHomeView
    {
        #region Properties
        string Name { get; }
        #endregion

        #region Events
        event EventHandler OpenUserRes;
        #endregion
    }
}
