using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_support_system.Views
{
    public interface IUser_Res
    {
        #region Properties
        PictureBox pictureBoxUpload { get; }
        #endregion

        #region Events
        event EventHandler ExitUserRes;
        event EventHandler btnCancel_Click;
        event EventHandler pictureBoxUpload_Click;
        void CloseView();
        #endregion
    }
}
