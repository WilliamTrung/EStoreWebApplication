using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private Member admin;
        public Member loginUser { get; set; } = null;
        IMemberRepository mR = new MemberRepository();
        public frmLogin(Member admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (email.Equals(admin.Email))
            {
                if (password.Equals(admin.Password))
                {
                    loginUser = admin;
                }
            }
            else
            {
                loginUser = mR.Login(email, password);
            }

            if(loginUser == null)
            {
                MessageBox.Show("Wrong email or password!", "Login Failed!");
            } 
            else
            {
                this.Close();
            }
        }
    }
}
