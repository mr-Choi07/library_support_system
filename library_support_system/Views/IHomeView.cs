using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_support_system.Views
{
    public interface IHomeView
    {
        #region Properties
        string CurrentMenu1Text { set; }
        string CurrentMenu2Text { set; }
        void ShowChildForm(Form form);
        void ToggleAccountPanel();
        void ToggleBookPanel();
        void ToggleRentalPanel();
        #endregion

        #region Events
        event EventHandler BookMenu;
        event EventHandler UserMenu;
        event EventHandler RentalMenu;

        event EventHandler OpenUserRes;
        event EventHandler OpenUserRetrieve;
        event EventHandler OpenBookRes;
        event EventHandler OpenBookRetrieve;
        event EventHandler OpenBookRental;
        event EventHandler OpenBookReturn;
        event EventHandler OpenHomeSearch;
        event EventHandler ExitProgram;
        #endregion
    }
}
