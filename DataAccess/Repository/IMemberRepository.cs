using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<Member> GetMembers();
        public Member GetMemberById(int id);
        public void Insert(Member member);
        public void Update(Member member);
        public void Remove(int id);
        public Member Login(string email, string password);
    }
}
