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

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        private Member loginUser;
        public frmMain(Member admin)
        {
            InitializeComponent();
            loginUser = admin;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberManagement fM = new frmMemberManagement();
            fM.ShowDialog();
            
        }
    }
}
