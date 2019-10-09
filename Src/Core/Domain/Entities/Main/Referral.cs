using Nexawo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Domain.Entities.Main
{
    public class Referral : AuditableEntity
    {
        public int Id { get; set; }
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public DateTime DOB { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public DateTime ReferralDate { get; set; }
        public string ReferralSource { get; set; }
        public string KeyWorker { get; set; }
    }
}
