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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.home_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rental_panel = new System.Windows.Forms.Panel();
            this.book_rental_button = new System.Windows.Forms.Button();
            this.book_return_button = new System.Windows.Forms.Button();
            this.rental_button = new System.Windows.Forms.Button();
            this.account_panel = new System.Windows.Forms.Panel();
            this.user_check_button = new System.Windows.Forms.Button();
            this.user_register_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.book_panel = new System.Windows.Forms.Panel();
            this.book_check_button = new System.Windows.Forms.Button();
            this.book_enroll_button = new System.Windows.Forms.Button();
            this.book_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home_picturebox = new System.Windows.Forms.PictureBox();
            this.home_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCurrentMenu2 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.labelCurrentMenu1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.search_button = new System.Windows.Forms.Button();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.rental_panel.SuspendLayout();
            this.account_panel.SuspendLayout();
            this.book_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_picturebox)).BeginInit();
            this.panel3.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_label
            // 
            this.home_label.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home_label.Enabled = false;
            this.home_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home_label.ForeColor = System.Drawing.SystemColors.Control;
            this.home_label.Location = new System.Drawing.Point(0, 0);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(101, 40);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 855);
            this.panel1.TabIndex = 1;
            // 
            // rental_panel
            // 
            this.rental_panel.Controls.Add(this.book_rental_button);
            this.rental_panel.Controls.Add(this.book_return_button);
            this.rental_panel.Location = new System.Drawing.Point(0, 639);
            this.rental_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rental_panel.Name = "rental_panel";
            this.rental_panel.Size = new System.Drawing.Size(171, 176);
            this.rental_panel.TabIndex = 6;
            // 
            // book_rental_button
            // 
            this.book_rental_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_rental_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_rental_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_rental_button.Location = new System.Drawing.Point(0, 0);
            this.book_rental_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_rental_button.Name = "book_rental_button";
            this.book_rental_button.Size = new System.Drawing.Size(171, 88);
            this.book_rental_button.TabIndex = 6;
            this.book_rental_button.Text = "도서대여";
            this.book_rental_button.UseVisualStyleBackColor = false;
            this.book_rental_button.Click += new System.EventHandler(this.book_rental_button_Click);
            // 
            // book_return_button
            // 
            this.book_return_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_return_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_return_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_return_button.Location = new System.Drawing.Point(0, 84);
            this.book_return_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_return_button.Name = "book_return_button";
            this.book_return_button.Size = new System.Drawing.Size(171, 88);
            this.book_return_button.TabIndex = 5;
            this.book_return_button.Text = "도서반납";
            this.book_return_button.UseVisualStyleBackColor = false;
            this.book_return_button.Click += new System.EventHandler(this.book_return_button_Click);
            // 
            // rental_button
            // 
            this.rental_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rental_button.FlatAppearance.BorderSize = 0;
            this.rental_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rental_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rental_button.ForeColor = System.Drawing.SystemColors.Control;
            this.rental_button.Location = new System.Drawing.Point(0, 592);
            this.rental_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rental_button.Name = "rental_button";
            this.rental_button.Size = new System.Drawing.Size(171, 50);
            this.rental_button.TabIndex = 7;
            this.rental_button.Text = "대여관리";
            this.rental_button.UseVisualStyleBackColor = false;
            this.rental_button.Click += new System.EventHandler(this.rental_button_Click);
            // 
            // account_panel
            // 
            this.account_panel.Controls.Add(this.user_check_button);
            this.account_panel.Controls.Add(this.user_register_button);
            this.account_panel.Location = new System.Drawing.Point(0, 420);
            this.account_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.account_panel.Name = "account_panel";
            this.account_panel.Size = new System.Drawing.Size(171, 176);
            this.account_panel.TabIndex = 4;
            // 
            // user_check_button
            // 
            this.user_check_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.user_check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_check_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_check_button.Location = new System.Drawing.Point(0, 0);
            this.user_check_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_check_button.Name = "user_check_button";
            this.user_check_button.Size = new System.Drawing.Size(171, 88);
            this.user_check_button.TabIndex = 4;
            this.user_check_button.Text = "회원조회";
            this.user_check_button.UseVisualStyleBackColor = false;
            this.user_check_button.Click += new System.EventHandler(this.user_check_button_Click);
            // 
            // user_register_button
            // 
            this.user_register_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.user_register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_register_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_register_button.Location = new System.Drawing.Point(0, 84);
            this.user_register_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_register_button.Name = "user_register_button";
            this.user_register_button.Size = new System.Drawing.Size(171, 88);
            this.user_register_button.TabIndex = 3;
            this.user_register_button.Text = "회원등록";
            this.user_register_button.UseVisualStyleBackColor = false;
            this.user_register_button.Click += new System.EventHandler(this.user_register_button_Click);
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.account_button.ForeColor = System.Drawing.SystemColors.Control;
            this.account_button.Location = new System.Drawing.Point(0, 374);
            this.account_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(171, 50);
            this.account_button.TabIndex = 5;
            this.account_button.Text = "회원관리";
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // book_panel
            // 
            this.book_panel.Controls.Add(this.book_check_button);
            this.book_panel.Controls.Add(this.book_enroll_button);
            this.book_panel.Location = new System.Drawing.Point(0, 200);
            this.book_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_panel.Name = "book_panel";
            this.book_panel.Size = new System.Drawing.Size(171, 176);
            this.book_panel.TabIndex = 3;
            // 
            // book_check_button
            // 
            this.book_check_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_check_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_check_button.Location = new System.Drawing.Point(0, 0);
            this.book_check_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_check_button.Name = "book_check_button";
            this.book_check_button.Size = new System.Drawing.Size(171, 88);
            this.book_check_button.TabIndex = 2;
            this.book_check_button.Text = "도서조회";
            this.book_check_button.UseVisualStyleBackColor = false;
            this.book_check_button.Click += new System.EventHandler(this.book_check_button_Click);
            // 
            // book_enroll_button
            // 
            this.book_enroll_button.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.book_enroll_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_enroll_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_enroll_button.Location = new System.Drawing.Point(0, 85);
            this.book_enroll_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_enroll_button.Name = "book_enroll_button";
            this.book_enroll_button.Size = new System.Drawing.Size(171, 88);
            this.book_enroll_button.TabIndex = 1;
            this.book_enroll_button.Text = "도서등록";
            this.book_enroll_button.UseVisualStyleBackColor = false;
            this.book_enroll_button.Click += new System.EventHandler(this.book_enroll_button_Click);
            // 
            // book_button
            // 
            this.book_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.book_button.FlatAppearance.BorderSize = 0;
            this.book_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.book_button.ForeColor = System.Drawing.SystemColors.Control;
            this.book_button.Location = new System.Drawing.Point(0, 159);
            this.book_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(171, 50);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 64);
            this.panel2.TabIndex = 2;
            // 
            // home_picturebox
            // 
            this.home_picturebox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home_picturebox.Enabled = false;
            this.home_picturebox.Image = global::library_support_system.Properties.Resources.deu_logo;
            this.home_picturebox.Location = new System.Drawing.Point(94, 0);
            this.home_picturebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home_picturebox.Name = "home_picturebox";
            this.home_picturebox.Size = new System.Drawing.Size(78, 69);
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
            this.home_button.ForeColor = System.Drawing.SystemColors.Control;
            this.home_button.Location = new System.Drawing.Point(0, 0);
            this.home_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(171, 69);
            this.home_button.TabIndex = 9;
            this.home_button.Text = "bb";
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.labelCurrentMenu2);
            this.panel3.Controls.Add(this.exit_button);
            this.panel3.ForeColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(170, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1278, 66);
            this.panel3.TabIndex = 2;
            // 
            // labelCurrentMenu2
            // 
            this.labelCurrentMenu2.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCurrentMenu2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCurrentMenu2.Location = new System.Drawing.Point(8, 1);
            this.labelCurrentMenu2.Name = "labelCurrentMenu2";
            this.labelCurrentMenu2.Size = new System.Drawing.Size(200, 65);
            this.labelCurrentMenu2.TabIndex = 2;
            this.labelCurrentMenu2.Text = "홈";
            this.labelCurrentMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Crimson;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.Red;
            this.exit_button.Image = global::library_support_system.Properties.Resources.exit_logo1;
            this.exit_button.Location = new System.Drawing.Point(1213, 1);
            this.exit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(62, 65);
            this.exit_button.TabIndex = 0;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.Window;
            this.top_panel.Controls.Add(this.labelCurrentMenu1);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Location = new System.Drawing.Point(2, 68);
            this.top_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(169, 92);
            this.top_panel.TabIndex = 8;
            // 
            // labelCurrentMenu1
            // 
            this.labelCurrentMenu1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCurrentMenu1.Location = new System.Drawing.Point(27, 39);
            this.labelCurrentMenu1.Name = "labelCurrentMenu1";
            this.labelCurrentMenu1.Size = new System.Drawing.Size(111, 22);
            this.labelCurrentMenu1.TabIndex = 1;
            this.labelCurrentMenu1.Text = "홈";
            this.labelCurrentMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(47, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재메뉴";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.main_panel);
            this.panel4.Location = new System.Drawing.Point(170, 68);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1273, 786);
            this.panel4.TabIndex = 9;
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.search_button);
            this.main_panel.Controls.Add(this.search_textbox);
            this.main_panel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1274, 784);
            this.main_panel.TabIndex = 0;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // search_button
            // 
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Image = global::library_support_system.Properties.Resources.search_logo;
            this.search_button.Location = new System.Drawing.Point(921, 352);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(50, 51);
            this.search_button.TabIndex = 9;
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // search_textbox
            // 
            this.search_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_textbox.Location = new System.Drawing.Point(310, 352);
            this.search_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_textbox.Multiline = true;
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(604, 51);
            this.search_textbox.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1445, 851);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
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
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
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
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button book_check_button;
        private System.Windows.Forms.Button book_enroll_button;
        private System.Windows.Forms.Button book_rental_button;
        private System.Windows.Forms.Button book_return_button;
        private System.Windows.Forms.Button user_check_button;
        private System.Windows.Forms.Button user_register_button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label labelCurrentMenu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentMenu2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_textbox;
    }
}

