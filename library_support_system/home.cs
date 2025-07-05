using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_support_system
{

    public partial class home : Form
    {
        private int bookPanelOriginalHeight;
        private int accountPanelOriginalHeight;
        private int rentalPanelOriginalHeight;
        private Control previousScreen = null; // 이전 화면 저장
private bool isHome = true;            // 현재 홈 상태 여부


        public home()
        {
            InitializeComponent();

            Panel top_panel = new Panel();
            top_panel.Dock = DockStyle.Top;
            top_panel.Height = 127;
            top_panel.BackColor = Color.LightGray; // 필요시 색상 설정
            panel1.Controls.Add(top_panel);

            // 먼저 Dock, Margin, Padding 설정
            book_button.Dock = DockStyle.Top;
            book_button.Margin = new Padding(0);
            book_button.Padding = new Padding(0);
            book_panel.Dock = DockStyle.Top;
            book_panel.Margin = new Padding(0);
            book_panel.Padding = new Padding(0);

            account_button.Dock = DockStyle.Top;
            account_button.Margin = new Padding(0);
            account_button.Padding = new Padding(0);
            account_panel.Dock = DockStyle.Top;
            account_panel.Margin = new Padding(0);
            account_panel.Padding = new Padding(0);

            rental_button.Dock = DockStyle.Top;
            rental_button.Margin = new Padding(0);
            rental_button.Padding = new Padding(0);
            rental_panel.Dock = DockStyle.Top;
            rental_panel.Margin = new Padding(0);
            rental_panel.Padding = new Padding(0);


            // Dock 설정 후에 패널의 높이 저장
            bookPanelOriginalHeight = book_panel.Height;
            accountPanelOriginalHeight = account_panel.Height;
            rentalPanelOriginalHeight = rental_panel.Height;

            // 시작 시 모두 접기
            book_panel.Height = 0;
            account_panel.Height = 0;
            rental_panel.Height = 0;
        }
        private const int PANEL_HEIGHT = 140; // 패널 펼칠 때 높이
        private void home_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            TogglePanel(book_panel);
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            TogglePanel(account_panel);
        }

        private void rental_button_Click(object sender, EventArgs e)
        {
            TogglePanel(rental_panel);
        }

        private void TogglePanel(Panel panelToToggle)
        {
            if (panelToToggle.Height == 0)
                panelToToggle.Height = PANEL_HEIGHT;
            else
                panelToToggle.Height = 0;
        }
        private void home_button_Click(object sender, EventArgs e)
        {
            
        }

        private void home_label_Click(object sender, EventArgs e)
        {
            home_button.PerformClick();
        }

        private void home_picturebox_Click(object sender, EventArgs e)
        {
            home_button.PerformClick();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void book_check_button_Click(object sender, EventArgs e)
        {
            labelCurrentMenu1.Text = labelCurrentMenu2.Text = "도서조회";
            book_check form = new book_check();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            main_panel.Controls.Clear();    // 이전 화면 제거
            main_panel.Controls.Add(form);
            form.Show();
        }

        private void book_enroll_button_Click(object sender, EventArgs e)
        {
            labelCurrentMenu1.Text = labelCurrentMenu2.Text = "도서등록";
            book_enroll form = new book_enroll();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            main_panel.Controls.Clear();    // 이전 화면 제거
            main_panel.Controls.Add(form);
            form.Show();
        }

        private void user_check_button_Click(object sender, EventArgs e)
        {
            labelCurrentMenu1.Text = labelCurrentMenu2.Text = "회원조회";
            user_check form = new user_check();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            main_panel.Controls.Clear();    // 이전 화면 제거
            main_panel.Controls.Add(form);
            form.Show();
        }

        private void user_register_button_Click(object sender, EventArgs e)
        {
            labelCurrentMenu1.Text = labelCurrentMenu2.Text = "회원등록";
            user_register popup = new user_register();
            popup.ShowDialog();
        }

        private void book_rental_button_Click(object sender, EventArgs e)
        {
            Font font1 = new Font(FontManager.fontFamilys[0], 12, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            labelCurrentMenu1.Text = labelCurrentMenu2.Text = "도서대여";
            book_rental form = new book_rental();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            main_panel.Controls.Clear();    // 이전 화면 제거
            main_panel.Controls.Add(form);
            form.Show();
        }

        private void book_return_button_Click(object sender, EventArgs e)
        {
            labelCurrentMenu1.Text = labelCurrentMenu2.Text = "도서반납";
            book_return form = new book_return();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            main_panel.Controls.Clear();    // 이전 화면 제거
            main_panel.Controls.Add(form);
            form.Show();
        }
    }
}
