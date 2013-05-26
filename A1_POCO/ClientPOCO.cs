using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_POCO
{
    public class ClientPOCO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CNP { get; set; }
        public string ICN { get; set; }

        public virtual ICollection<AccountPOCO> Accounts { get; set; }
    }
}
