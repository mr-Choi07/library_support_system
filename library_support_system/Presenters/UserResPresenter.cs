using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using library_support_system.Views;

namespace library_support_system.Presenters
{
    public class UserResPresenter
    {
        #region Fields
        private readonly IUser_Res view;
        #endregion

        public UserResPresenter(IUser_Res view)
        {
            this.view = view;

            //우측 위 종료 버튼
            this.view.ExitUserRes += exit_button_Click;
            //취소 버튼
            this.view.btnCancel_Click += cancel_button_Click;
            //사진 업로드
            this.view.pictureBoxUpload_Click += pictureBoxUpload_Click;
        }



        private void exit_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "정말로 가입을 중단하시겠습니까?",
            "가입 중단 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                view.CloseView();  // View 닫기 요청
            }
            // 아니요: 아무 동작 없음 (그냥 복귀)
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "정말로 가입을 중단하시겠습니까?",
            "가입 중단 확인",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                view.CloseView();
            }
        }

        private void pictureBoxUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png",
                Title = "사진 업로드",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                view.pictureBoxUpload.Image = Image.FromFile(dialog.FileName);
                view.pictureBoxUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
