using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Utils;

namespace UI.Wrappers
{
    public class IncomeWrapper : ModelWrapper<Bill>
    {
        public IncomeWrapper(Bill model) : base(model)
        {
        }

        public int bill
        {
            get { return GetValue<int>(); }
        }
        public string displayRoom
        {
            get { return GetValue<string>(); }
        }

        public string customerName
        {
            get { return GetValue<string>(); }
        }
        public string checkin
        {
            get { return Convertor.TimeToString(Model.checkin); }
        }

        public string checkout
        {
            get { return Convertor.TimeToString(Model.checkout); }
        }

        public string dateOfPayment
        {
            get { return Convertor.DateToString(Model.dateOfPayment); }
        }
        public int total
        {
            get { return GetValue<int>(); }
        }
    }
}
