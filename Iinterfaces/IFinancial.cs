using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Iinterfaces
{
    public interface IFinancial
    {
        IncomeSummary GetIncomeSummary();
        List<AdminFinancialReport> GetFinancialHistory();
    }
}
