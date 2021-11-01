﻿using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.MemberManagement
{
    public partial class frmMemberInsert : Form
    {
        IMemberRepository mr = new MemberRepository();
        public frmMemberInsert()
        {
            InitializeComponent();
        }
        private Boolean checkValid(Member member)
        {
            Boolean result = true;
            if (member.Email.Trim().Length == 0)
                result = false;
            if (member.CompanyName.Trim().Length == 0)
                result = false;
            if (member.City.Trim().Length == 0)
                result = false;
            if (member.Country.Trim().Length == 0)
                result = false;
            if (member.Password.Trim().Length == 0)
                result = false;
            return result;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newMember = new Member
            {
                MemberId = -1,
                Email = txtEmail.Text,
                CompanyName = txtCompany.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Password = txtPassword.Text
            };
            if (checkValid(newMember))
            {
                try
                {
                    mr.Insert(newMember);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            } 
            else
            {
                MessageBox.Show("Invalid value!", "Error");
            }
        }
    }
}
