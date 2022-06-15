using BLL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
using UI.Utils;
using UI.Views;
using UI.Wrappers;

namespace UI.ViewModels
{
    public class RoomConfigViewModel : IViewModel
    {
        RoomRepository roomRepository = new RoomRepository();
        RoomConfigView roomConfigView;
        List<RoomWrapper> rooms;
        TableStyle<RoomWrapper> tableStyle;
        RoomWrapper currRoom;
        ICollection<Floor> floors;

        public RoomConfigViewModel(RoomConfigView roomConfigView)
        {
            this.roomConfigView = roomConfigView;
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _rooms = await roomRepository.GetIncludeAsync();
            floors = await roomRepository.GetFloorAsync();


            rooms = new List<RoomWrapper>();
            foreach(var model in _rooms)
            {
                var wrapper = new RoomWrapper(model);
                rooms.Add(wrapper);
            }
            LoadDataTable();
            currRoom = new RoomWrapper(new Room());
            BindingData();
            roomConfigView.btbnAdd.Click -=
                (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, currRoom); };
            roomConfigView.btbnAdd.Click +=
                (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, currRoom); };
            roomConfigView.btnClose.Click -= BtnClose_Click;
            roomConfigView.btnClose.Click += BtnClose_Click;
            roomConfigView.btnSave.Click -= BtnSave_Click;
            roomConfigView.btnSave.Click += BtnSave_Click;
        }

        private void BindingData()
        {
            VMControl.BindingText(roomConfigView.txbId, currRoom, "roomId");
            VMControl.BindingText(roomConfigView.txbDisplay, currRoom, "displayRoom");
            VMControl.BindingText(roomConfigView.txbPrice, currRoom, "price");
            VMControl.BindingText(roomConfigView.txbFloor, currRoom, "floorId");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var floor = floors.FirstOrDefault(f => f.floorId == currRoom.floorId);
            if (floor == null)
            {
                currRoom.Model.Floor = new Floor()
                {
                    floorId = currRoom.floorId,
                    displayFloor = "Tầng " + currRoom.floorId.ToString()
                };
            }
            else
                currRoom.Model.Floor = floor;

            roomRepository.AddOrUpdate(currRoom.Model);
            roomRepository.Save();
            roomConfigView.pnlEdit.Visible = false;
            LoadAsync();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            currRoom = new RoomWrapper(new Room());
            BindingData();
            roomConfigView.pnlEdit.Visible = false;
        }

        private void LoadDataTable()
        {
            var haeders = new List<string>() { "ID phòng", "Tên phòng", "Giá phòng", "Tầng" };
            tableStyle = new TableStyle<RoomWrapper>(haeders, rooms, canEdit:true);

            foreach(var row in tableStyle.rows)
            {
                row.btnEdit.Click -=
                    (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, row.Model); };
                row.btnEdit.Click +=
                    (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, row.Model); };
                row.btnRemove.Click -=
                    (sender, EventArgs) => { BtnRemove_Click(sender, EventArgs, row.Model); };
                row.btnRemove.Click +=
                    (sender, EventArgs) => { BtnRemove_Click(sender, EventArgs, row.Model); };
            }

            roomConfigView.pnlTable.Controls.Clear();
            roomConfigView.pnlTable.Controls.Add(tableStyle);
        }

        private void BtnRemove_Click(object sender, EventArgs eventArgs, RoomWrapper model)
        {
            var room = model.Model;
            roomRepository.Remove(room);
            roomRepository.Save();
            LoadAsync();
        }

        private void BtnEdit_Click(object sender, EventArgs eventArgs, RoomWrapper model)
        {
            currRoom = model;
            BindingData();
            roomConfigView.pnlEdit.Visible = true;
        }
    }
}
