using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_POCO
{
    public class TransactionPOCO
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public Nullable<int> FromAccountID { get; set; }
        public int ToAccountID { get; set; }
        public double Amount { get; set; }
        public int Type { get; set; }

        public virtual AccountPOCO Account { get; set; }
        public virtual AccountPOCO Account1 { get; set; }
        public virtual UserPOCO User { get; set; }
    }
}
