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
            // 🔥 다른 패널은 건드리지 않고, 클릭한 패널만 토글
            if (panelToToggle.Height == 0)
                panelToToggle.Height = PANEL_HEIGHT;
            else
                panelToToggle.Height = 0;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
