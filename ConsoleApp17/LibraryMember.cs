using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public sealed class LibraryMember : Person
    {
        public DateTime MembershipDate { get; }

        public LibraryMember(int id, string name, DateTime membershipDate) : base(id, name)
        {
            MembershipDate = membershipDate;
        }
    }
}
