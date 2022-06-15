using BLL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Styles;
using UI.Utils;
using UI.Views;
using UI.Wrappers;

namespace UI.ViewModels
{
    public class PaymentViewModel : IViewModel
    {
        PaymentView paymentView;
        PaymentRepository paymentRepository = new PaymentRepository();
        List<Floor> floors;
        List<Room> rooms;
        List<Room> currRooms;
        List<Booking> currBookings;
        PaymentWrapper currPayment;
        public PaymentViewModel(PaymentView paymentView)
        {
            this.paymentView = paymentView;
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _floors = await paymentRepository.GetFloorsAsync();
            floors = new List<Floor>(_floors);
            var _rooms = await paymentRepository.GetRoomsIncludeAsync();
            rooms = new List<Room>(_rooms);

            currPayment = new PaymentWrapper(new Payment());
            LoadEvent();
        }

        private void LoadEvent()
        {
            paymentView.cbbFloor.Items.Clear();
            paymentView.cbbFloor.Items.Add("All");
            paymentView.cbbFloor.Items.AddRange(floors.Select(f => f.displayFloor).ToArray());
            paymentView.cbbFloor.SelectedIndexChanged -= CbbFloor_SelectedIndexChanged;
            paymentView.cbbFloor.SelectedIndexChanged += CbbFloor_SelectedIndexChanged;
            paymentView.cbbRoom.SelectedIndexChanged += CbbRoom_SelectedIndexChanged;
            paymentView.cbbRoom.SelectedIndexChanged += CbbRoom_SelectedIndexChanged;
            paymentView.btnClose.Click -= BtnClose_Click;
            paymentView.btnClose.Click += BtnClose_Click;
            paymentView.btnPay.Click -= BtnPay_Click;
            paymentView.btnPay.Click += BtnPay_Click;
            paymentView.cbbFloor.SelectedIndex = 0;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            paymentView.pnlEdit.Visible = false;
            currPayment.Model.Booking.isPaid = true;
            paymentRepository.AddOrUpdate(currPayment.Model);
            paymentRepository.AddBill(currPayment.Model);
            paymentRepository.Save();
            LoadAsync();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            paymentView.pnlEdit.Visible = false;
        }

        private void CbbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = paymentView.cbbRoom.SelectedIndex;
            currBookings = new List<Booking>();
            if(index == 0)
            {
                foreach(var room in currRooms)
                {
                    currBookings.AddRange(room.BookingRooms
                        .Select(br => br.Booking).Where(b => b.isPaid == false));
                }
            }
            else
            {
                currBookings.AddRange(currRooms[index - 1].BookingRooms
                        .Select(br => br.Booking).Where(b => b.isPaid == false));
            }
            FillBooking();
        }

        private void FillBooking()
        {
            paymentView.pnlContainBooking.Controls.Clear();
            var _headers = new List<string>() { "Phòng", "ID khách hàng", "Tên khách hàng", "Ngày sinh khách hàng", 
                "Giá phòng", "Checkin", "Checkout", "Ngày thanh toán", "Tổng tiền" };
            var iconEdit = Properties.Resources.icons8_expensive_price_50;
            var paymentWrapers = new List<PaymentWrapper>();
            currBookings.ForEach(booking =>
            {
                var timeSpan = booking.checkout - booking.checkin;
                var minutes = (int)timeSpan.TotalMinutes;
                var price = booking.Room.price;
                var total = (price * minutes / 60000) * 1000;
                var payment = new PaymentWrapper(new Payment()
                {
                    Booking = booking,
                    dateOfPayment = null,
                    total = total
                });
                paymentWrapers.Add(payment);
            });
            var tableStyle = new TableStyle<PaymentWrapper>(_headers, paymentWrapers, iconEdit, true);

            foreach(var row in tableStyle.rows)
            {
                row.btnEdit.Click -=
                       (sender, EventArgs) => BtnEdit_Click(sender, EventArgs, row.Model);
                row.btnEdit.Click +=
                    (sender, EventArgs) => BtnEdit_Click(sender, EventArgs, row.Model);

                //var timeSpan = row.Model.Model.Booking.checkin - DateTime.Now;
                //var minutes = timeSpan.TotalMinutes;
                //if (minutes > 10)
                //    row.btnRemove.Enabled = false;
                row.btnRemove.Click -=
                    (sender, EventArgs) => BtnRemove_Click(sender, EventArgs, row.Model);
                row.btnRemove.Click += 
                    (sender, EventArgs) => BtnRemove_Click(sender, EventArgs, row.Model);
            }
            paymentView.pnlContainBooking.Controls.Add(tableStyle);
        }

        private void BtnRemove_Click(object sender, EventArgs eventArgs, PaymentWrapper model)
        {
            paymentRepository.RemoveBooking(model.Model);
            paymentRepository.Save();
            LoadAsync();
        }

        private void BtnEdit_Click(object sender, EventArgs eventArgs, PaymentWrapper model)
        {
            currPayment = model;
            currPayment.Model.dateOfPayment = DateTime.Now;
            BindingData();
            paymentView.pnlEdit.Visible = true;
        }

        private void CbbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            currRooms = new List<Room>();
            var index = paymentView.cbbFloor.SelectedIndex;
            var _rooms = rooms.Where(room => 
                room.BookingRooms.Any(
                    br => br.Booking.isPaid == false
                )
            ).ToList();

            if(index == 0)
            {
                currRooms = _rooms;
            }
            else
            {
                currRooms = _rooms.Where(r => r.floorId == floors[index - 1].floorId).ToList();
            }
            paymentView.cbbRoom.Items.Clear();
            paymentView.cbbRoom.Items.Add("All");
            paymentView.cbbRoom.Items.AddRange(currRooms.Select(r => r.displayRoom).ToArray());
            paymentView.cbbRoom.SelectedIndex = 0;
        }

        private void BindingData()
        {
            VMControl.BindingText(paymentView.lblRoom, currPayment, "displayRoom");
            VMControl.BindingText(paymentView.txbCustomerId, currPayment, "customerId");
            VMControl.BindingText(paymentView.txbCustomerName, currPayment, "customerName");
            VMControl.BindingText(paymentView.txbCustomerBirthday, currPayment, "customerBirthday");
            VMControl.BindingText(paymentView.txbPrice, currPayment, "price");
            VMControl.BindingText(paymentView.txbCheckin, currPayment, "checkin");
            VMControl.BindingText(paymentView.txbCheckout, currPayment, "checkout");
            VMControl.BindingText(paymentView.txbDateOfPayment, currPayment, "dateOfPayment");
            VMControl.BindingText(paymentView.txbTotal, currPayment, "total");
        }


    }
}
