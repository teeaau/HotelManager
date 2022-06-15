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
    public class BookingViewModel : IViewModel
    {
        BookingView bookingView;
        BookingRepository bookingRepository = new BookingRepository();
        List<Floor> floors;
        List<Room> rooms;
        List<Room> currRooms;
        BookingWrapper currBooking;

        public BookingViewModel(BookingView bookingView)
        {
            this.bookingView = bookingView;
            LoadAsync();
        }

        private void BindingData()
        {
            VMControl.BindingText(bookingView.lblRoom, currBooking, "displayRoom");
            VMControl.BindingText(bookingView.txbCustomerId, currBooking, "customerId");
            VMControl.BindingText(bookingView.txbCustomerName, currBooking, "customerName");
            VMControl.BindingText(bookingView.txbRoom, currBooking, "displayRoom");
            VMControl.BindingText(bookingView.txbPrice, currBooking, "price");
            VMControl.BindingText(bookingView.dpkCustomerBirthday, currBooking, "customerBirthday");
            VMControl.BindingText(bookingView.txbCheckin, currBooking, "checkin");
            VMControl.BindingText(bookingView.txbCheckout, currBooking, "checkout");
        }

        private async void LoadAsync()
        {
            var _floors = await bookingRepository.GetFloorsAsync();
            floors = new List<Floor>(_floors);
            var _rooms = await bookingRepository.GetRoomsIncludeAsync();
            rooms = new List<Room>(_rooms);
            currBooking = new BookingWrapper(new Booking()
            {
                Customer = new Customer() { customerBirthday = DateTime.Now },
                Room = new Room()
            });
            BindingData();
            LoadEvent();
        }


        private void LoadEvent()
        {
            bookingView.cbbFloor.Items.Clear();
            bookingView.cbbFloor.Items.Add("All");
            bookingView.cbbFloor.Items.AddRange(floors.Select(f => f.displayFloor).ToArray());
            bookingView.cbbFloor.SelectedIndexChanged -= CbbFloor_SelectedIndexChanged;
            bookingView.cbbFloor.SelectedIndexChanged += CbbFloor_SelectedIndexChanged;
            bookingView.dpkCheckin.ValueChanged -= DpkCheckin_ValueChanged;
            bookingView.dpkCheckin.ValueChanged += DpkCheckin_ValueChanged;
            bookingView.dpkCheckout.ValueChanged -= DpkCheckout_ValueChanged;
            bookingView.dpkCheckout.ValueChanged += DpkCheckout_ValueChanged;
            bookingView.cbbFloor.SelectedIndex = 0;
            bookingView.txbCustomerId.TextChanged -= TxbCustomerId_TextChanged;
            bookingView.txbCustomerId.TextChanged += TxbCustomerId_TextChanged;
            bookingView.btnClose.Click -= BtnClose_Click;
            bookingView.btnClose.Click += BtnClose_Click;
            bookingView.btnBooking.Click -= BtnBooking_Click;
            bookingView.btnBooking.Click += BtnBooking_Click;
        }

        private void DpkCheckout_ValueChanged(object sender, EventArgs e)
        {
            RoomsBookable_Changed();
        }

        private void DpkCheckin_ValueChanged(object sender, EventArgs e)
        {
            RoomsBookable_Changed();
        }

        private void CbbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomsBookable_Changed();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            if (currBooking.Model.Customer.customerBirthday == null)
                currBooking.Model.Customer.customerBirthday = DateTime.Now;
            bookingRepository.AddBooking(currBooking.Model);
            bookingRepository.Save();
            bookingView.pnlEdit.Visible = false;
            LoadAsync();
        }

        private void FillBooking(Room room)
        {
            bookingView.pnlContainBooking.Controls.Clear();
            var haeders = new List<string>() { "Phòng", "ID khách hàng", "Tên khách hàng", "Ngày sinh khách hàng", "Giá phòng", "Checkin", "Checkout" };
            var _bookings = bookingRepository.GetBookingsByRoom(room);
            var bookings = new List<BookingWrapper>();
            foreach(var bk in _bookings)
            {
                bookings.Add(new BookingWrapper(bk));
            }

            var tableStyle = new TableStyle<BookingWrapper>(haeders, bookings);
            bookingView.pnlContainBooking.Controls.Add(tableStyle);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            bookingView.pnlEdit.Visible = false;
        }

        private void TxbCustomerId_TextChanged(object sender, EventArgs e)
        {
            var id = bookingView.txbCustomerId.Text;
            var customer = bookingRepository.GetCustomerById(id);
            if (customer != null)
                currBooking.Model.Customer = customer;
        }

        private void RoomsBookable_Changed()
        {
            bookingView.pnlEdit.Visible = false;
            currRooms = new List<Room>();
            var index = bookingView.cbbFloor.SelectedIndex;
            var checkin = bookingView.dpkCheckin.Value;
            var checkout = bookingView.dpkCheckout.Value;

            if(checkin < (DateTime.Now - new TimeSpan(0, 10, 0)))
            {
                ShowRoomsBookable();
                return;
            }
            if(checkout <= checkin)
            {
                ShowRoomsBookable();
                return;
            }

            if(index == 0)
            {
                currRooms = rooms.Where(room =>                
                    room.BookingRooms
                    .Select(br => br.Booking)
                    .All(b => b.checkin > checkout || b.checkout < checkin)
                ).ToList();
            }
            else
            {
                currRooms = rooms.Where(room =>
                    room.BookingRooms
                    .Select(br => br.Booking)
                    .All(b => b.checkin > checkout || b.checkout < checkin)
                    && room.Floor == floors[index - 1]
                ).ToList();
            }

            ShowRoomsBookable();
        }

        private void ShowRoomsBookable()
        {
            bookingView.pnlContainRoom.Controls.Clear();
            foreach(var room in currRooms)
            {
                var roomStyle = new RoomStyle(room);
                roomStyle.btnRoom.Click -=
                    (sender, EventArgs) => BtnRoom_Click(sender, EventArgs, room);
                roomStyle.btnRoom.Click +=
                    (sender, EventArgs) => BtnRoom_Click(sender, EventArgs, room);
                bookingView.pnlContainRoom.Controls.Add(roomStyle);
            }
        }

        private void BtnRoom_Click(object sender, EventArgs eventArgs, Room room)
        {
            currBooking.Model.checkin = bookingView.dpkCheckin.Value;
            currBooking.Model.checkout = bookingView.dpkCheckout.Value;
            currBooking.Model.Room = room;
            currBooking.Model.Customer = new Customer();
            BindingData();

            bookingView.pnlEdit.Visible = true;
            FillBooking(room);
        }
    }
}
