using B_Commerce.Common.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace B_Commerce.Login.DomainClass
{
    public class Token : BaseEntity
    {
        public int ID { get; set; }
        public string TokenText { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
