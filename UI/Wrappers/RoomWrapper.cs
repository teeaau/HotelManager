using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Wrappers
{
    public class RoomWrapper : ModelWrapper<Room>
    {
        public RoomWrapper(Room model) : base(model)
        {

        }

        public int roomId
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string displayRoom
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public int price
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public int floorId
        {
            get { return GetValue<int>(); }
            set{ SetValue(value); }
        }
    }
}
