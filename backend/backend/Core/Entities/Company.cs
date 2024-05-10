using backend.Core.Enums;
using System.Runtime.Intrinsics.X86;

namespace backend.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        //Relations
        public ICollection<Job> Jobs { get; set; }
    }
}
