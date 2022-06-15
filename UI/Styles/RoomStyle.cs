using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public partial class RoomStyle : UserControl
    {
        public RoomStyle()
        {
            InitializeComponent();
        }
        public RoomStyle(Room room) : this()
        {
            btnRoom.Text = room.displayRoom;
        }
    }
}
