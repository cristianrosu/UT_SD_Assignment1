using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_POCO
{
    public class AccountPOCO
    {

        public int ID { get; set; }
        public string Number { get; set; }
        public int ClientID { get; set; }
        public int Type { get; set; }
        public int Currency { get; set; }
        public double Amount { get; set; }
        public string CreationDate { get; set; }

        public virtual ClientPOCO Client { get; set; }
        public virtual ICollection<TransactionPOCO> Transactions { get; set; }
        public virtual ICollection<TransactionPOCO> Transactions1 { get; set; }

    }
}
