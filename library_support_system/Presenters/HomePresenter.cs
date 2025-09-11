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

        private void OpenUserRes(object sender, EventArgs e)
        {
            // 회원 등록 창 또는 관련 로직 실행
            User_Res popup = new User_Res();
            popup.ShowDialog();
        }

    }
}
