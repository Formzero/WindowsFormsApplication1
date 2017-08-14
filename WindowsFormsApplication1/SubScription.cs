using System;
/// <summary>
///    This is the brief description imformation of SubScription class
/// </summary>
     public class SubScription
    {
        public enum Status
        {
            Temporary,
            Financial,
            Unfinancial,
            Suspended,
            Test,
            TestAgain
        }

        public DateTime? PaidUpTo { get; set; }
        //TODO: The Premeter will return the status value
        public Status CurrentStatus
        {
            get
            {
                if (this.PaidUpTo.HasValue == false)
                    return Status.Temporary;
                if (this.PaidUpTo > DateTime.Today)
                    return Status.Financial;
                else
                {
                    if (this.PaidUpTo >= DateTime.Today.AddMonths(-3))
                        return Status.Unfinancial;
                    else
                        return Status.Suspended;
                } 
            }
        }
    }
