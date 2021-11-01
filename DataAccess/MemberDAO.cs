using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetListMembers()
        {
            var list = new List<Member>();
            using (var db = new FStoreContext())
            {
                list = db.Members.ToList();
            }
            return list;
        }
        public Member GetMemberById(int id)
        {
            Member member = null;
            using (var db = new FStoreContext())
            {
                member = db.Members.Find(id);
            }
            return member;
        }
        public void InsertMember(Member member)
        {
            Member check = GetMemberById(member.MemberId);
            if (check == null)
            {
                using (var db = new FStoreContext())
                {
                    db.Members.Add(new Member { 
                        City = member.City,
                        Country = member.Country,
                        CompanyName = member.CompanyName,
                        Email = member.Email,
                        Password = member.Password
                    });
                    db.SaveChanges();
                }
            } 
            else
            {
                throw new Exception("Member exists already!");
            }
        }
        public void UpdateMember(Member member)
        {
            Member check = GetMemberById(member.MemberId);
            if (check != null)
            {
                using (var db = new FStoreContext())
                {

                    check = db.Members.Where(m => m.MemberId == member.MemberId).First();
                    check.City = member.City;
                    check.Country = member.Country;
                    check.CompanyName = member.CompanyName;
                    check.Email = member.Email;
                    check.Password = member.Password;
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Member does not exist!");
            }
        }
        public Member Login(string Email, string Password)
        {
            Member login = null;
            using(var db = new FStoreContext())
            {
                login = db.Members.Where(member => member.Email == Email && member.Password == Password).SingleOrDefault();
            }
            return login;
        }
        public void RemoveMember(int id)
        {
            Member check = GetMemberById(id);
            if (check != null)
            {
                using (var db = new FStoreContext())
                {
                    db.Members.Remove(check);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Member does not exist!");
            }
        }
    }
}
