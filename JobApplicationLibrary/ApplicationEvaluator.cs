using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplicationLibrary
{
    public class ApplicationEvaluator
    {
        private const int MinAge = 18;
        public ApplicationResult EvaluateApplication(Models.JobApplication form)
        {
            if (form.Application.Age< MinAge)
            {
                return ApplicationResult.AutoRejected;
            }
            return ApplicationResult.AutoAccepted;
        }
    }
    public enum ApplicationResult
    {
        AutoRejected,
        TransferredToHR,
        TransferredToLead,
        TransferredToCTO,
        AutoAccepted
    }
}
