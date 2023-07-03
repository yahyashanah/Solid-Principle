using System;
using System.Collections.Generic;
using System.Text;

namespace ProbSolv
{
    public interface IOrder : ICashOrder , IOnlineOrder , ICreditOrder
    {
        
    }

    public interface ICashOrder { void ProccessCashInvoice(); void Complete(); }
    public interface IOnlineOrder { void ProccessOnlinePaymentInvoice(); }
    public interface ICreditOrder { void ProccessCreditInvoice(); }
}
