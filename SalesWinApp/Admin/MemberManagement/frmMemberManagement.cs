using BusinessObject.Models;
using DataAccess.Repository;
using SalesWinApp.Admin.MemberManagement;
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
    public partial class frmMemberManagement : Form
    {
        BindingSource source = new BindingSource();
        IMemberRepository mr = new MemberRepository();
        public frmMemberManagement()
        {
            InitializeComponent();
            LoadMembers();
        }
        private void LoadMembers()
        {
            List<Member> list = mr.GetMembers();
            try
            {
                source.DataSource = list;
                txtMemberId.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMember.DataSource = source;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            

            
        }
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmMemberInsert fmi = new frmMemberInsert();
            fmi.ShowDialog();
            LoadMembers();
        }
        private Member Selected()
        {
            var member = new Member
            {
                MemberId = Int32.Parse(txtMemberId.Text),
                Email = txtEmail.Text,
                CompanyName = txtCompanyName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text
            };
            return member;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberUpdate fmu = new frmMemberUpdate(Selected());
            fmu.ShowDialog();
            LoadMembers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                mr.Remove(Selected().MemberId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            LoadMembers();
        }
    }
}
