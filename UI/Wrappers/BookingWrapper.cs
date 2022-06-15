using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Utils;

namespace UI.Wrappers
{
    public class BookingWrapper : ModelWrapper<Booking>
    {
        public BookingWrapper(Booking model) : base(model)
        {
        }

        public string displayRoom
        {
            get { return Model.Room.displayRoom; }
        }

        public string customerId
        {
            get { return Model.Customer.customerId; }
            set
            {
                Model.Customer.customerId = value;
            }
        }

        public string customerName
        {
            get { return Model.Customer.customerName; }
            set { Model.Customer.customerName = value; }
        }

        public string customerBirthday
        {
            get
            {
                if (Model.Customer.customerBirthday != null)
                    return Convertor.DateToString(Model.Customer.customerBirthday.Value);
                return "";
            }
            set { Model.Customer.customerBirthday = Convertor.StringToDate(value); }
        }

        public int price
        {
            get { return Model.Room.price; }
            set { Model.Room.price = value; }
        }

        public string checkin
        {
            get { return Convertor.TimeToString(Model.checkin); }
            set { Model.checkin = Convertor.StringToTime(value).Value; }
        }

        public string checkout
        {
            get { return Convertor.TimeToString(Model.checkout); }
            set { Model.checkout = Convertor.StringToTime(value).Value; }
        }
    }
}
