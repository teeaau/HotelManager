using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Wrappers
{
    public class CustomerWrapper : ModelWrapper<Customer>
    {
        public CustomerWrapper(Customer model) : base(model)
        {
        }
        public string customerId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string customerName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public DateTime? customerBirthday
        {
            get { return GetValue<DateTime?>(); }
            set { SetValue(value); }
        }
    }
}
