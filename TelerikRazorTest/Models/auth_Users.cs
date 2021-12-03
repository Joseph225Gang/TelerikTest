using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikRazorTest.Models
{
    public partial class auth_Users
    {
        public int UserId { get; set; }
        public Nullable<int> AffiliateId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<short> SignOnRetryLimit { get; set; }
        public Nullable<short> SignOnErrorCnt { get; set; }
        public Nullable<bool> Suspended { get; set; }
        public Nullable<System.DateTime> SuspendedDate { get; set; }
        public Nullable<System.DateTime> LastPasswordChangedDate { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public string Domain { get; set; }
        public string Lst_Maint_Usr { get; set; }
        public Nullable<System.DateTime> Lst_Maint_Dt { get; set; }
    }
}
