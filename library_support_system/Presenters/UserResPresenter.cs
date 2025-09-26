using library_support_system.Model;
using library_support_system.Repositories;
using library_support_system.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_support_system.Presenters
{
    public class UserResPresenter
    {
        #region Fields
        private readonly IUser_Res view;
        private readonly UserRepository userRepository;
        #endregion

        public UserResPresenter(IUser_Res view)
        {
            this.view = view;
            this.userRepository = new UserRepository();

            //우측 위 종료 버튼
            this.view.ExitUserRes += exit_button_Click;
            this.view.btnSave_Click += btnSave_Click;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserModel newUser = new UserModel
            {
                 User_Phone = view.UserPhone
               , User_Name = view.UserName
               , User_Birthdate = view.UserBirthdate
               , User_Gender = view.UserGender
               , User_Mail = view.UserMail
               , User_Image = view.UserImage
               , User_WithDR = 0 // 기본값 설정
            };

            bool result = userRepository.Create(newUser);

            if (result)
            {
                MessageBox.Show("회원 등록 성공");
                view.CloseView();
            }
            else
            {
                MessageBox.Show("회원 등록 실패");
            }
        }
    }
}
