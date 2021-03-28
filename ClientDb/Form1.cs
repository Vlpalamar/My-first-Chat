using ClassLibrary1.Entities;
using ClassLibrary1.Enums;
using ClassLibrary1.Messages;
using System;
using System.Windows.Forms;
using WindowsFormsApp27;
using DbServer;

namespace ClientDb
{
    public partial class Form1 : Form
    {
        private bool isConnected = false;
        private User currentUser = null;
        private string message = null;
        public Form1()
        {
            InitializeComponent();
            ServerConnect.getInstance();
        }




        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            currentUser=ServerConnect.getInstance()
                .LogIn(Email_txtBox.Text, Password_txtBox.Text);

            if (currentUser!=null)
            {
                Chat_txtBox.Text +=currentUser.name;
            }

        }

        private void Reg_Btn_Click(object sender, EventArgs e)
        {
            currentUser = ServerConnect.getInstance()
                .Reg(RegName_txtBox.Text, RegEMail_txtBox.Text, RegPassword_txtBox.Text);





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            if (currentUser!=null)
            {
                message = ServerConnect.getInstance().SendMessage(Send_txtBox.Text);
                if (message!=null)
                {
                    Chat_txtBox.Text += currentUser.name + message + "\n";
                }
                
            }
        }
    }
}
