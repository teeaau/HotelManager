using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Utils;

namespace UI.Wrappers
{
    public class PaymentWrapper : ModelWrapper<Payment>
    {
        public PaymentWrapper(Payment model) : base(model)
        {
        }

        public string displayRoom
        {
            get { return Model.Booking.Room.displayRoom; }
            set { Model.Booking.Room.displayRoom = value; }
        }

        public string customerId
        {
            get { return Model.Booking.Customer.customerId; }
            set { Model.Booking.Customer.customerId = value; }
        }

        public string customerName
        {
            get { return Model.Booking.Customer.customerName; }
            set { Model.Booking.Customer.customerName = value; }
        }

        public string customerBirthDay
        {
            get
            {
                var birthday = Model.Booking.Customer.customerBirthday.Value;
                return Convertor.DateToString(birthday);
            }
            set
            {
                Model.Booking.Customer.customerBirthday = Convertor.StringToDate(value).Value;
            }
        }

        public int price
        {
            get { return Model.Booking.Room.price; }
            set { Model.Booking.Room.price = value; }
        }

        public string checkin
        {
            get { return Convertor.TimeToString(Model.Booking.checkin); }
            set { Model.Booking.checkin = Convertor.StringToTime(value).Value; }
        }

        public string checkout
        {
            get { return Convertor.TimeToString(Model.Booking.checkout); }
            set { Model.Booking.checkout = Convertor.StringToTime(value).Value; }
        }

        public string dateOfPayment
        {
            get
            {
                if (Model.dateOfPayment == null)
                    return "Invalid";
                return Convertor.DateToString(Model.dateOfPayment.Value);
            }
            set { Model.dateOfPayment = Convertor.StringToDate(value).Value; }
        }

        public int total
        {
            get { return GetValue<int>(); }
            set { SetValue<int>(value); }
        }
    }
}
