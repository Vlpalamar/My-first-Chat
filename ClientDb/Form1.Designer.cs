
namespace ClientDb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Chat_txtBox = new System.Windows.Forms.RichTextBox();
            this.chat_lbl = new System.Windows.Forms.Label();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.Email_txtBox = new System.Windows.Forms.TextBox();
            this.Password_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reg_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegPassword_txtBox = new System.Windows.Forms.TextBox();
            this.RegEMail_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegName_txtBox = new System.Windows.Forms.TextBox();
            this.Send_txtBox = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chat_txtBox
            // 
            this.Chat_txtBox.Location = new System.Drawing.Point(14, 179);
            this.Chat_txtBox.Name = "Chat_txtBox";
            this.Chat_txtBox.Size = new System.Drawing.Size(320, 198);
            this.Chat_txtBox.TabIndex = 0;
            this.Chat_txtBox.Text = "";
            // 
            // chat_lbl
            // 
            this.chat_lbl.AutoSize = true;
            this.chat_lbl.Location = new System.Drawing.Point(153, 138);
            this.chat_lbl.Name = "chat_lbl";
            this.chat_lbl.Size = new System.Drawing.Size(29, 13);
            this.chat_lbl.TabIndex = 1;
            this.chat_lbl.Text = "Chat";
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Location = new System.Drawing.Point(320, 37);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(75, 23);
            this.LogIn_btn.TabIndex = 2;
            this.LogIn_btn.Text = "Log In";
            this.LogIn_btn.UseVisualStyleBackColor = true;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // Email_txtBox
            // 
            this.Email_txtBox.Location = new System.Drawing.Point(38, 39);
            this.Email_txtBox.Name = "Email_txtBox";
            this.Email_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Email_txtBox.TabIndex = 3;
            // 
            // Password_txtBox
            // 
            this.Password_txtBox.Location = new System.Drawing.Point(182, 39);
            this.Password_txtBox.Name = "Password_txtBox";
            this.Password_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Password_txtBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "EMail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Reg_Btn
            // 
            this.Reg_Btn.Location = new System.Drawing.Point(703, 114);
            this.Reg_Btn.Name = "Reg_Btn";
            this.Reg_Btn.Size = new System.Drawing.Size(75, 23);
            this.Reg_Btn.TabIndex = 7;
            this.Reg_Btn.Text = "Reg";
            this.Reg_Btn.UseVisualStyleBackColor = true;
            this.Reg_Btn.Click += new System.EventHandler(this.Reg_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "EMail";
            // 
            // RegPassword_txtBox
            // 
            this.RegPassword_txtBox.Location = new System.Drawing.Point(566, 163);
            this.RegPassword_txtBox.Name = "RegPassword_txtBox";
            this.RegPassword_txtBox.Size = new System.Drawing.Size(100, 20);
            this.RegPassword_txtBox.TabIndex = 9;
            // 
            // RegEMail_txtBox
            // 
            this.RegEMail_txtBox.Location = new System.Drawing.Point(566, 117);
            this.RegEMail_txtBox.Name = "RegEMail_txtBox";
            this.RegEMail_txtBox.Size = new System.Drawing.Size(100, 20);
            this.RegEMail_txtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // RegName_txtBox
            // 
            this.RegName_txtBox.Location = new System.Drawing.Point(566, 78);
            this.RegName_txtBox.Name = "RegName_txtBox";
            this.RegName_txtBox.Size = new System.Drawing.Size(100, 20);
            this.RegName_txtBox.TabIndex = 12;
            // 
            // Send_txtBox
            // 
            this.Send_txtBox.Location = new System.Drawing.Point(340, 197);
            this.Send_txtBox.Name = "Send_txtBox";
            this.Send_txtBox.Size = new System.Drawing.Size(100, 20);
            this.Send_txtBox.TabIndex = 14;
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(446, 194);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(75, 23);
            this.Send_btn.TabIndex = 15;
            this.Send_btn.Text = "Send";
            this.Send_btn.UseVisualStyleBackColor = true;
            this.Send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Send_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegName_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegPassword_txtBox);
            this.Controls.Add(this.RegEMail_txtBox);
            this.Controls.Add(this.Reg_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_txtBox);
            this.Controls.Add(this.Email_txtBox);
            this.Controls.Add(this.LogIn_btn);
            this.Controls.Add(this.chat_lbl);
            this.Controls.Add(this.Chat_txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Chat_txtBox;
        private System.Windows.Forms.Label chat_lbl;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.TextBox Email_txtBox;
        private System.Windows.Forms.TextBox Password_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reg_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegPassword_txtBox;
        private System.Windows.Forms.TextBox RegEMail_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RegName_txtBox;
        private System.Windows.Forms.TextBox Send_txtBox;
        private System.Windows.Forms.Button Send_btn;
    }
}

