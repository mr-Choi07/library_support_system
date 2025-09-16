using library_support_system.Views;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_support_system.Presenters
{
    public class HomePresenter
    {
        #region Fields
        private readonly IHomeView view;
        #endregion

        public HomePresenter(IHomeView view)
        {
            this.view = view;

            //회원등록 팝업
            this.view.OpenUserRes += OpenUserRes;
        }

        //회원등록 팝업 함수
        private void OpenUserRes(object sender, EventArgs e)
        {
            User_Res popup = new User_Res();
            popup.ShowDialog();
        }

    }
}
