using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Utils;

namespace UI.Styles
{
    public partial class RowTableStyle<TModel> : UserControl
    {
        public RowTableStyle()
        {
            InitializeComponent();
        }

        List<string> rowData;
        List<Size> sizes;
        bool canEdit;
        public RoundBorderButtonStyle btnEdit { get; set; }
        public RoundBorderButtonStyle btnRemove { get; set; }
        public TModel Model;
        Bitmap iconEdit;
        public RowTableStyle(List<string> rowData, List<Size> sizes, bool canEdit = false) : this()
        {
            this.rowData = rowData;
            this.sizes = sizes;
            this.canEdit = canEdit;
            DesignHeader();
        }

        private void DesignHeader()
        {
            int x = 0;
            for (int i = 0; i < rowData.Count; i++)
            {
                var location = new Point(x, 0);
                x += sizes[i].Width;
                var lbl = GetLabel(rowData[i], sizes[i], location);
                Controls.Add(lbl);
            }
        }

        public RowTableStyle(TModel model, List<Size> sizes, Bitmap iconEdit, bool canEdit = false) : this()
        {
            this.canEdit = canEdit;
            this.iconEdit = iconEdit;
            DesignRowTable(model, sizes);
        }

        private void DesignRowTable(TModel model, List<Size> sizes)
        {
            this.Model = model;
            var properties = typeof(TModel).GetProperties();
            int x = 0;
            for (int i = 0; i < properties.Length - 1; i++)
            {
                var location = new Point(x, 0);
                x += sizes[i].Width;
                if (properties[i].PropertyType == typeof(string)
                        || properties[i].PropertyType == typeof(DateTime)
                        || properties[i].PropertyType == typeof(DateTime?)
                        || properties[i].PropertyType == typeof(int))
                {
                    string text;
                    if(properties[i].GetValue(model) == null)
                    {
                        text = "";
                    }
                    else if(properties[i].Name == "userPassword")
                    {
                        text = "●●●●●●●●●●●●●●●●●●●●";
                    }
                    else if (properties[i].PropertyType == typeof(DateTime)
                        || properties[i].PropertyType == typeof(DateTime?))
                        text = (properties[i].GetValue(model) as DateTime?).Value.ToString("dd/MM/yyyy");
                    else
                        text = properties[i].GetValue(model).ToString();
                    var lbl = GetLabel(text, sizes[i], location);
                    Controls.Add(lbl);
                }
                if (properties[i].PropertyType == typeof(byte[]))
                {
                    Bitmap image;
                    if (properties[i].GetValue(model) == null)
                    {
                        image = Properties.Resources.icons8_customer_50;
                    }
                    else
                    {
                        var bytes = properties[i].GetValue(model) as byte[];
                        image = Convertor.ToImage(bytes);
                    }
                    var pnl = GetImage(image, sizes[i], location);
                    Controls.Add(pnl);
                }
                if (properties[i].PropertyType == typeof(Bitmap))
                {
                    Bitmap image;
                    if (properties[i].GetValue(model) == null)
                    {
                        image = Properties.Resources.icons8_customer_50;
                    }
                    else
                    {
                        image = properties[i].GetValue(model) as Bitmap;
                    }
                    var pnl = GetImage(image, sizes[i], location);
                    Controls.Add(pnl);
                }
            }
            if(canEdit)
            {
                AddEdit(x);
            }
        }

        private void AddEdit(int x)
        {
            var imgEdit = iconEdit;
            var imgRemove = Properties.Resources.icons8_trash_can_50;
            btnEdit = GetButton(imgEdit, new Size(60, 35), new Point(x, 0));
            btnRemove = GetButton(imgRemove, new Size(80, 35), new Point(x + 60, 0));

            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
        }

        private Label GetLabel(string text, Size size, Point location)
        {
            return new Label()
            {
                Text = text,
                Size = size,
                Location = location,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Consolas", 14, FontStyle.Regular)
            };
        }

        private RoundBorderButtonStyle GetButton(Bitmap image, Size size, Point location)
        {
            return new RoundBorderButtonStyle()
            {
                Size = size,
                Image = image,
                ImageSize = new Size(20, 20),
                BorderSize = 1,
                Text = "",
                BorderRadius = 0,
                Location = location
            };
        }

        private Panel GetImage(Bitmap image, Size size, Point location)
        {
            var pnl = new Panel()
            {
                Size = size,
                Margin = new Padding(0),
                Location = location,
                BorderStyle = BorderStyle.FixedSingle
            };

            var picture = new RoundPictureStyle()
            {
                BackgroundImage = image,
                Size = new Size(30, 30),
                Location = new Point(size.Width/2 - 15, 2)
            };

            pnl.Controls.Add(picture);
            return pnl;
        }
    }
}
