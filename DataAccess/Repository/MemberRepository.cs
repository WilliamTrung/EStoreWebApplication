using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository :IMemberRepository
    {
        public List<Member> GetMembers() => MemberDAO.Instance.GetListMembers();
        public Member GetMemberById(int id) => MemberDAO.Instance.GetMemberById(id);
        public void Insert(Member member) => MemberDAO.Instance.InsertMember(member);
        public void Update(Member member) => MemberDAO.Instance.UpdateMember(member);
        public void Remove(int id) => MemberDAO.Instance.RemoveMember(id);

        public Member Login(string email, string password) => MemberDAO.Instance.Login(email, password);
    }
}
