using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLoanStatusTypeBanker
{
    public class LoanStatus
    {
        public string Status_ID { get; set; }
        public int Status { get; set; }

    }

    public enum BankerLoanStaus : int
    {
        Submitted = 1,
        InReview = 2,
        Rejected = 3,
        MoreInfoRequested = 4,
        ApprovedForCredit = 5
    }
}
