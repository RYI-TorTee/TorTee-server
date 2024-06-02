using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorTee.BLL.Models.Requests.PaymentMoMo
{
    public class PaymentRequestModel
    {
        public Guid TransactionId { get; set; }
        public long Amount { get; set; }
   
    }


}
