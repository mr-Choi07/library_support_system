namespace library_support_system
{
    partial class home
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.home_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rental_panel = new System.Windows.Forms.Panel();
            this.rental_button = new System.Windows.Forms.Button();
            this.account_panel = new System.Windows.Forms.Panel();
            this.account_button = new System.Windows.Forms.Button();
            this.book_panel = new System.Windows.Forms.Panel();
            this.book_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home_picturebox = new System.Windows.Forms.PictureBox();
            this.home_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.book_enroll_button = new System.Windows.Forms.Button();
            this.book_check_button = new System.Windows.Forms.Button();
            this.user_check_button = new System.Windows.Forms.Button();
            this.user_register_button = new System.Windows.Forms.Button();
            this.book_rental_button = new System.Windows.Forms.Button();
            this.book_return_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.rental_panel.SuspendLayout();
            this.account_panel.SuspendLayout();
            this.book_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_picturebox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_label
            // 
            this.home_label.Enabled = false;
            this.home_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home_label.ForeColor = System.Drawing.SystemColors.Control;
            this.home_label.Location = new System.Drawing.Point(-2, 0);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(85, 54);
            this.home_label.TabIndex = 0;
            this.home_label.Text = "도서관리\r\n시스템";
            this.home_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home_label.Click += new System.EventHandler(this.home_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.rental_panel);
            this.panel1.Controls.Add(this.rental_button);
            this.panel1.Controls.Add(this.account_panel);
            this.panel1.Controls.Add(this.account_button);
            this.panel1.Controls.Add(this.book_panel);
            this.panel1.Controls.Add(this.book_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 684);
            this.panel1.TabIndex = 1;
            // 
            // rental_panel
            // 
            this.rental_panel.Controls.Add(this.book_rental_button);
            this.rental_panel.Controls.Add(this.book_return_button);
            this.rental_panel.Location = new System.Drawing.Point(0, 511);
            this.rental_panel.Name = "rental_panel";
            this.rental_panel.Size = new System.Drawing.Size(150, 141);
            this.rental_panel.TabIndex = 6;
            // 
            // rental_button
            // 
            this.rental_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rental_button.FlatAppearance.BorderSize = 0;
            this.rental_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rental_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rental_button.ForeColor = System.Drawing.SystemColors.Control;
            this.rental_button.Location = new System.Drawing.Point(0, 474);
            this.rental_button.Name = "rental_button";
            this.rental_button.Size = new System.Drawing.Size(150, 40);
            this.rental_button.TabIndex = 7;
            this.rental_button.Text = "대여관리";
            this.rental_button.UseVisualStyleBackColor = false;
            this.rental_button.Click += new System.EventHandler(this.rental_button_Click);
            // 
            // account_panel
            // 
            this.account_panel.Controls.Add(this.user_check_button);
            this.account_panel.Controls.Add(this.user_register_button);
            this.account_panel.Location = new System.Drawing.Point(0, 336);
            this.account_panel.Name = "account_panel";
            this.account_panel.Size = new System.Drawing.Size(150, 141);
            this.account_panel.TabIndex = 4;
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.account_button.ForeColor = System.Drawing.SystemColors.Control;
            this.account_button.Location = new System.Drawing.Point(0, 299);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(150, 40);
            this.account_button.TabIndex = 5;
            this.account_button.Text = "회원관리";
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // book_panel
            // 
            this.book_panel.Controls.Add(this.book_check_button);
            this.book_panel.Controls.Add(this.book_enroll_button);
            this.book_panel.Location = new System.Drawing.Point(0, 160);
            this.book_panel.Name = "book_panel";
            this.book_panel.Size = new System.Drawing.Size(150, 141);
            this.book_panel.TabIndex = 3;
            // 
            // book_button
            // 
            this.book_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.book_button.FlatAppearance.BorderSize = 0;
            this.book_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_button.ForeColor = System.Drawing.SystemColors.Control;
            this.book_button.Location = new System.Drawing.Point(0, 127);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(150, 40);
            this.book_button.TabIndex = 3;
            this.book_button.Text = "도서관리";
            this.book_button.UseVisualStyleBackColor = false;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.home_label);
            this.panel2.Controls.Add(this.home_picturebox);
            this.panel2.Controls.Add(this.home_button);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 51);
            this.panel2.TabIndex = 2;
            // 
            // home_picturebox
            // 
            this.home_picturebox.Enabled = false;
            this.home_picturebox.Image = global::library_support_system.Properties.Resources.Clipboard___2025년_6월_30일_오후_1시_48분;
            this.home_picturebox.Location = new System.Drawing.Point(82, 0);
            this.home_picturebox.Name = "home_picturebox";
            this.home_picturebox.Size = new System.Drawing.Size(68, 52);
            this.home_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_picturebox.TabIndex = 1;
            this.home_picturebox.TabStop = false;
            this.home_picturebox.Click += new System.EventHandler(this.home_picturebox_Click);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home_button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button.Location = new System.Drawing.Point(0, 0);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(150, 55);
            this.home_button.TabIndex = 9;
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(149, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 54);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = global::library_support_system.Properties.Resources.free_icon_power_switch_4139573__1_;
            this.button4.Location = new System.Drawing.Point(1061, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 54);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.Window;
            this.top_panel.Location = new System.Drawing.Point(2, 54);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(148, 74);
            this.top_panel.TabIndex = 8;
            // 
            // book_enroll_button
            // 
            this.book_enroll_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_enroll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_enroll_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_enroll_button.Location = new System.Drawing.Point(0, 68);
            this.book_enroll_button.Name = "book_enroll_button";
            this.book_enroll_button.Size = new System.Drawing.Size(150, 70);
            this.book_enroll_button.TabIndex = 1;
            this.book_enroll_button.Text = "도서등록";
            this.book_enroll_button.UseVisualStyleBackColor = false;
            // 
            // book_check_button
            // 
            this.book_check_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_check_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_check_button.Location = new System.Drawing.Point(0, 0);
            this.book_check_button.Name = "book_check_button";
            this.book_check_button.Size = new System.Drawing.Size(150, 70);
            this.book_check_button.TabIndex = 2;
            this.book_check_button.Text = "도서조회";
            this.book_check_button.UseVisualStyleBackColor = false;
            // 
            // user_check_button
            // 
            this.user_check_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.user_check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_check_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_check_button.Location = new System.Drawing.Point(0, 0);
            this.user_check_button.Name = "user_check_button";
            this.user_check_button.Size = new System.Drawing.Size(150, 70);
            this.user_check_button.TabIndex = 4;
            this.user_check_button.Text = "회원조회";
            this.user_check_button.UseVisualStyleBackColor = false;
            // 
            // user_register_button
            // 
            this.user_register_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.user_register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_register_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_register_button.Location = new System.Drawing.Point(0, 67);
            this.user_register_button.Name = "user_register_button";
            this.user_register_button.Size = new System.Drawing.Size(150, 70);
            this.user_register_button.TabIndex = 3;
            this.user_register_button.Text = "회원등록";
            this.user_register_button.UseVisualStyleBackColor = false;
            // 
            // book_rental_button
            // 
            this.book_rental_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_rental_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_rental_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_rental_button.Location = new System.Drawing.Point(0, 0);
            this.book_rental_button.Name = "book_rental_button";
            this.book_rental_button.Size = new System.Drawing.Size(150, 70);
            this.book_rental_button.TabIndex = 6;
            this.book_rental_button.Text = "도서대여";
            this.book_rental_button.UseVisualStyleBackColor = false;
            // 
            // book_return_button
            // 
            this.book_return_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_return_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_return_button.Location = new System.Drawing.Point(0, 67);
            this.book_return_button.Name = "book_return_button";
            this.book_return_button.Size = new System.Drawing.Size(150, 70);
            this.book_return_button.TabIndex = 5;
            this.book_return_button.Text = "도서반납";
            this.book_return_button.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.rental_panel.ResumeLayout(false);
            this.account_panel.ResumeLayout(false);
            this.book_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home_picturebox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label home_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox home_picturebox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.Panel book_panel;
        private System.Windows.Forms.Panel rental_panel;
        private System.Windows.Forms.Button rental_button;
        private System.Windows.Forms.Panel account_panel;
        private System.Windows.Forms.Button account_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button book_check_button;
        private System.Windows.Forms.Button book_enroll_button;
        private System.Windows.Forms.Button book_rental_button;
        private System.Windows.Forms.Button book_return_button;
        private System.Windows.Forms.Button user_check_button;
        private System.Windows.Forms.Button user_register_button;
    }
}

