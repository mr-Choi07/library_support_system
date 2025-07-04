using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFW.Data;

namespace library_support_system
{
    public partial class user_register : Form
    {
        private void user_register_Load(object sender, EventArgs e)
        {
            retrieve();
        }

        #region Method
        private void retrieve()
        {
            string connectionString = "YOUR_ORACLE_CONNECTION_STRING_HERE";

            using (var shell = new DataCommandShell(connectionString))
            {
                var p = new DataParameterCollection();
                p.Add(new DataParameter("@user_id", SqlDbType.NVarChar, 50, "test_user"));

                shell.SetSpCommand("USP_회원정보조회", DbCommandType.ExecuteQuery, p);

                var results = shell.Execute();

                if (shell.ErrorCode != 0)
                {
                    MessageBox.Show("오류 발생: " + shell.ErrorMessage);
                    return;
                }

                // 결과 사용 예시
                var resultDataSet = results[0].DataSet;
                if (resultDataSet != null && resultDataSet.Tables.Count > 0)
                {
                    DataTable table = resultDataSet.Tables[0];
                    // 예: DataGridView에 바인딩
                  
                }
            }
        }
        #endregion

        #region Event
        private void exit_button_Click(object sender, EventArgs e)
        {
        var result = MessageBox.Show(
        "정말로 가입을 중단하시겠습니까?",
        "가입 중단 확인",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 예: 창 닫기 (현재 폼만 닫힘)
                this.Close();
            }
            // 아니요: 아무 동작 없음 (그냥 복귀)
        }
        private void pictureBoxUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            dialog.Title = "사진 업로드";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUpload.Image = Image.FromFile(dialog.FileName);
                pictureBoxUpload.SizeMode = PictureBoxSizeMode.StretchImage; // 또는 Zoom
            }
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
                // 예: 창 닫기 (현재 폼만 닫힘)
                this.Close();
            }
            // 아니요: 아무 동작 없음 (그냥 복귀)
        }
        #endregion

        #region GridEvent   
        #endregion

    }
}
