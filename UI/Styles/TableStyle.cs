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
    public partial class TableStyle<TModel> : UserControl
    {
        public TableStyle()
        {
            InitializeComponent();
        }

        List<string> headers;
        List<TModel> models;
        List<Size> sizes;
        bool canEdit;
        Bitmap iconEdit = Properties.Resources.icons8_edit_50;
        public List<RowTableStyle<TModel>> rows;
        public TableStyle(List<string> headers, List<TModel> models, Bitmap iconEdit = null,  bool canEdit = false) : this()
        {
            if (iconEdit != null)
                this.iconEdit = iconEdit;

            this.headers = headers;
            this.models = models;
            this.canEdit = canEdit;
            sizes = new List<Size>();
            rows = new List<RowTableStyle<TModel>>();
            if(canEdit)
            {
                headers.Add("Edit");
                headers.Add("Remove");
            }
            GetSizes();
            DesignHeader();
            DesignTable();
        }

        private void DesignTable()
        {
            int y = 0;
            foreach(var model in models)
            {
                var row = new RowTableStyle<TModel>(model, sizes, iconEdit, canEdit);
                row.Location = new Point(0, y);
                y += 35;
                rows.Add(row);
                pnlData.Controls.Add(row);
            }
        }

        private void DesignHeader()
        {
            var row = new RowTableStyle<TModel>(headers, sizes, canEdit);
            pnlHeader.Controls.Add(row);
        }

        private void GetSizes()
        {
            foreach(var header in headers)
            {
                var w = header.Length * 10 + 20;
                var size = new Size(w, 35);
                sizes.Add(size);
            }
            var properties = typeof(TModel).GetProperties();
            int x = 0;
            foreach (var model in models)
            {
                for (int i = 0; i < properties.Length - 1; i++)
                {
                    if (properties[i].PropertyType == typeof(string)
                            || properties[i].PropertyType == typeof(DateTime)
                            || properties[i].PropertyType == typeof(DateTime?)
                            || properties[i].PropertyType == typeof(int))
                    {
                        if (properties[i].GetValue(model) == null)
                            continue;
                        string text;
                        if (properties[i].PropertyType == typeof(DateTime)
                            || properties[i].PropertyType == typeof(DateTime?))
                            text = (properties[i].GetValue(model) as DateTime?).Value.ToString("dd/MM/yyyy");
                        else
                            text = properties[i].GetValue(model).ToString();
                        var w = text.Length * 10 + 20;
                        if(sizes[i].Width < w)
                        {
                            sizes[i] = new Size(w, 35);
                        }
                    }                    
                }
            }
        }
    }
}
