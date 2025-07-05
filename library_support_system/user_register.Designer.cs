using System.Drawing;

namespace library_support_system
{
    partial class user_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_register));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();

            this.exit_button = new System.Windows.Forms.Button();
            this.deu_logo = new System.Windows.Forms.PictureBox();
            
            this.user_pn_label = new System.Windows.Forms.Label();
            this.user_pn_textbox = new System.Windows.Forms.TextBox();
            this.jungbok = new System.Windows.Forms.Button();
            
            this.user_nm_label = new System.Windows.Forms.Label();
            this.user_nm_textbox = new System.Windows.Forms.TextBox();
            
            this.user_bth_label = new System.Windows.Forms.Label();
            this.user_bth_textbox = new System.Windows.Forms.TextBox();
            
            this.user_gen_label = new System.Windows.Forms.Label();
            this.user_gen_combobox = new System.Windows.Forms.ComboBox();
            
            this.user_em_label = new System.Windows.Forms.Label();
            this.user_em_textbox = new System.Windows.Forms.TextBox();
            
            this.pictureBoxUpload = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpload_label = new System.Windows.Forms.Label();
            
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deu_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).BeginInit();
            this.SuspendLayout();

            //********************************************************************************
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.exit_button);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 54);
            this.panel3.TabIndex = 3;

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "회원 등록";

            this.exit_button.BackColor = System.Drawing.Color.Crimson;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.Red;
            this.exit_button.Image = global::library_support_system.Properties.Resources.exit_logo1;
            this.exit_button.Location = new System.Drawing.Point(426, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(54, 54);
            this.exit_button.TabIndex = 0;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);

            this.deu_logo.Image = global::library_support_system.Properties.Resources.deu_logo;
            this.deu_logo.Location = new System.Drawing.Point(150, 250);
            this.deu_logo.Name = "deu_logo";
            this.deu_logo.Size = new System.Drawing.Size(174, 182);
            this.deu_logo.TabIndex = 4;
            this.deu_logo.TabStop = false;
            //********************************************************************************

            //********************************************************************************
            this.user_pn_label.AutoSize = true;
            this.user_pn_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_pn_label.Location = new System.Drawing.Point(100, 92);
            this.user_pn_label.Name = "user_pn_label";
            this.user_pn_label.Size = new System.Drawing.Size(75, 21);
            this.user_pn_label.TabIndex = 6;
            this.user_pn_label.Text = "전화번호";
            
            this.user_pn_textbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.user_pn_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pn_textbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_pn_textbox.Location = new System.Drawing.Point(100, 116);
            this.user_pn_textbox.Multiline = true;
            this.user_pn_textbox.Name = "user_pn_textbox";
            this.user_pn_textbox.Size = new System.Drawing.Size(263, 25);
            this.user_pn_textbox.TabIndex = 5;

            this.jungbok.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.jungbok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jungbok.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.jungbok.Location = new System.Drawing.Point(100, 143);
            this.jungbok.Name = "jungbok";
            this.jungbok.Size = new System.Drawing.Size(75, 27);
            this.jungbok.TabIndex = 7;
            this.jungbok.Text = "중복확인";
            this.jungbok.UseVisualStyleBackColor = false;
            //********************************************************************************

            //******************************************************************************** 
            this.user_nm_label.AutoSize = true;
            this.user_nm_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_nm_label.Location = new System.Drawing.Point(100, 182);
            this.user_nm_label.Name = "user_nm_label";
            this.user_nm_label.Size = new System.Drawing.Size(41, 21);
            this.user_nm_label.TabIndex = 9;
            this.user_nm_label.Text = "이름";
  
            this.user_nm_textbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.user_nm_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_nm_textbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_nm_textbox.Location = new System.Drawing.Point(100, 206);
            this.user_nm_textbox.Multiline = true;
            this.user_nm_textbox.Name = "user_nm_textbox";
            this.user_nm_textbox.Size = new System.Drawing.Size(263, 25);
            this.user_nm_textbox.TabIndex = 8;
            //******************************************************************************** 
           

            //******************************************************************************** 
            this.user_bth_label.AutoSize = true;
            this.user_bth_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_bth_label.Location = new System.Drawing.Point(100, 272);
            this.user_bth_label.Name = "user_bth_label";
            this.user_bth_label.Size = new System.Drawing.Size(74, 21);
            this.user_bth_label.TabIndex = 11;
            this.user_bth_label.Text = "생년월일";
 
            this.user_bth_textbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.user_bth_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_bth_textbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_bth_textbox.Location = new System.Drawing.Point(100, 296);
            this.user_bth_textbox.Multiline = true;
            this.user_bth_textbox.Name = "user_bth_textbox";
            this.user_bth_textbox.Size = new System.Drawing.Size(263, 25);
            this.user_bth_textbox.TabIndex = 10;
            //******************************************************************************** 

            //********************************************************************************  
            this.user_gen_label.AutoSize = true;
            this.user_gen_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_gen_label.Location = new System.Drawing.Point(100, 362);
            this.user_gen_label.Name = "user_gen_label";
            this.user_gen_label.Size = new System.Drawing.Size(43, 21);
            this.user_gen_label.TabIndex = 13;
            this.user_gen_label.Text = "성별";
       
            this.user_gen_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_gen_combobox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_gen_combobox.FormattingEnabled = true;
            this.user_gen_combobox.Items.AddRange(new object[] { "", "남", "여"});
            this.user_gen_combobox.Location = new System.Drawing.Point(104, 386);
            this.user_gen_combobox.Name = "user_gen_combobox";
            this.user_gen_combobox.Size = new System.Drawing.Size(121, 29);
            this.user_gen_combobox.TabIndex = 18;

            //********************************************************************************  

            //******************************************************************************** 
            this.user_em_label.AutoSize = true;
            this.user_em_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_em_label.Location = new System.Drawing.Point(100, 452);
            this.user_em_label.Name = "user_em_label";
            this.user_em_label.Size = new System.Drawing.Size(57, 21);
            this.user_em_label.TabIndex = 15;
            this.user_em_label.Text = "이메일";
        
            this.user_em_textbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.user_em_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_em_textbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_em_textbox.Location = new System.Drawing.Point(100, 476);
            this.user_em_textbox.Multiline = true;
            this.user_em_textbox.Name = "user_em_textbox";
            this.user_em_textbox.Size = new System.Drawing.Size(263, 25);
            this.user_em_textbox.TabIndex = 14;
            //******************************************************************************** 
            
            //******************************************************************************** 
            this.pictureBoxUpload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxUpload.Location = new System.Drawing.Point(100, 536);
            this.pictureBoxUpload.Name = "pictureBoxUpload";
            this.pictureBoxUpload.Size = new System.Drawing.Size(100, 130);
            this.pictureBoxUpload.TabIndex = 16;
            this.pictureBoxUpload.TabStop = false;
            this.pictureBoxUpload.Click += new System.EventHandler(this.pictureBoxUpload_Click);
            
            this.pictureBoxUpload_label.AutoSize = true;
            this.pictureBoxUpload_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pictureBoxUpload_label.Location = new System.Drawing.Point(206, 624);
            this.pictureBoxUpload_label.Name = "pictureBoxUpload_label";
            this.pictureBoxUpload_label.Size = new System.Drawing.Size(177, 42);
            this.pictureBoxUpload_label.TabIndex = 19;
            this.pictureBoxUpload_label.Text = "박스를 클릭하여 \r\n이미지를 추가하십시오.​";
            //******************************************************************************** 


         
            //******************************************************************************** 
            this.save_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.save_button.Location = new System.Drawing.Point(125, 712);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 30);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "저장";
            this.save_button.UseVisualStyleBackColor = false;
            //******************************************************************************** 
            
            //******************************************************************************** 
            this.cancel_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_button.Location = new System.Drawing.Point(231, 712);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 30);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "취소";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);

            //********************************************************************************  
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.pictureBoxUpload_label);
            this.Controls.Add(this.user_gen_combobox);
            this.Controls.Add(this.pictureBoxUpload);
            this.Controls.Add(this.user_em_label);
            this.Controls.Add(this.user_em_textbox);
            this.Controls.Add(this.user_gen_label);
            this.Controls.Add(this.user_bth_label);
            this.Controls.Add(this.user_bth_textbox);
            this.Controls.Add(this.user_nm_label);
            this.Controls.Add(this.user_nm_textbox);
            this.Controls.Add(this.jungbok);
            this.Controls.Add(this.user_pn_label);
            this.Controls.Add(this.user_pn_textbox);
            this.Controls.Add(this.deu_logo);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 등록";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deu_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox deu_logo;
        private System.Windows.Forms.Button exit_button;

        private System.Windows.Forms.Label user_pn_label;
        private System.Windows.Forms.TextBox user_pn_textbox;
        private System.Windows.Forms.Button jungbok;
        
        private System.Windows.Forms.Label user_nm_label;
        private System.Windows.Forms.TextBox user_nm_textbox;

        private System.Windows.Forms.Label user_bth_label;
        private System.Windows.Forms.TextBox user_bth_textbox;

        private System.Windows.Forms.Label user_gen_label;
        private System.Windows.Forms.ComboBox user_gen_combobox;
        
        private System.Windows.Forms.Label user_em_label;
        private System.Windows.Forms.TextBox user_em_textbox;

        private System.Windows.Forms.Label pictureBoxUpload_label;
        private System.Windows.Forms.PictureBox pictureBoxUpload;

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}