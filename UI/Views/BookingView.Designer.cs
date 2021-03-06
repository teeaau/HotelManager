
namespace UI.Views
{
    partial class BookingView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlContainRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dpkCheckout = new System.Windows.Forms.DateTimePicker();
            this.dpkCheckin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFloor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlContainBooking = new System.Windows.Forms.Panel();
            this.dpkCustomerBirthday = new System.Windows.Forms.DateTimePicker();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txbCheckin = new System.Windows.Forms.TextBox();
            this.txbCheckout = new System.Windows.Forms.TextBox();
            this.btnBooking = new UI.Styles.AddButtonStyle();
            this.btnClose = new UI.Styles.CloseButtonStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 615);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(437, 615);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.pnlContainRoom);
            this.panel8.Controls.Add(this.panel4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(417, 595);
            this.panel8.TabIndex = 1;
            // 
            // pnlContainRoom
            // 
            this.pnlContainRoom.AutoScroll = true;
            this.pnlContainRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainRoom.Location = new System.Drawing.Point(0, 120);
            this.pnlContainRoom.Name = "pnlContainRoom";
            this.pnlContainRoom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainRoom.Size = new System.Drawing.Size(417, 475);
            this.pnlContainRoom.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dpkCheckout);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.dpkCheckin);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbbFloor);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 120);
            this.panel4.TabIndex = 1;
            // 
            // dpkCheckout
            // 
            this.dpkCheckout.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dpkCheckout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkCheckout.Location = new System.Drawing.Point(108, 43);
            this.dpkCheckout.Name = "dpkCheckout";
            this.dpkCheckout.Size = new System.Drawing.Size(200, 30);
            this.dpkCheckout.TabIndex = 19;
            // 
            // dpkCheckin
            // 
            this.dpkCheckin.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dpkCheckin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkCheckin.Location = new System.Drawing.Point(108, 3);
            this.dpkCheckin.Name = "dpkCheckin";
            this.dpkCheckin.Size = new System.Drawing.Size(200, 30);
            this.dpkCheckin.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(5, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tầng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbFloor
            // 
            this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFloor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFloor.FormattingEnabled = true;
            this.cbbFloor.Location = new System.Drawing.Point(110, 86);
            this.cbbFloor.Margin = new System.Windows.Forms.Padding(5);
            this.cbbFloor.Name = "cbbFloor";
            this.cbbFloor.Size = new System.Drawing.Size(150, 30);
            this.cbbFloor.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(65, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Checkin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(65, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Checkout";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlEdit
            // 
            this.pnlEdit.AutoScroll = true;
            this.pnlEdit.BackColor = System.Drawing.Color.LightGray;
            this.pnlEdit.Controls.Add(this.panel2);
            this.pnlEdit.Controls.Add(this.txbCheckout);
            this.pnlEdit.Controls.Add(this.txbCheckin);
            this.pnlEdit.Controls.Add(this.btnBooking);
            this.pnlEdit.Controls.Add(this.dpkCustomerBirthday);
            this.pnlEdit.Controls.Add(this.txbPrice);
            this.pnlEdit.Controls.Add(this.label8);
            this.pnlEdit.Controls.Add(this.label7);
            this.pnlEdit.Controls.Add(this.label9);
            this.pnlEdit.Controls.Add(this.txbRoom);
            this.pnlEdit.Controls.Add(this.label6);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.txbCustomerName);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.txbCustomerId);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.btnClose);
            this.pnlEdit.Controls.Add(this.lblRoom);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEdit.Location = new System.Drawing.Point(437, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(400, 615);
            this.pnlEdit.TabIndex = 0;
            this.pnlEdit.Visible = false;
            // 
            // pnlContainBooking
            // 
            this.pnlContainBooking.AutoScroll = true;
            this.pnlContainBooking.AutoSize = true;
            this.pnlContainBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainBooking.Location = new System.Drawing.Point(0, 0);
            this.pnlContainBooking.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainBooking.Name = "pnlContainBooking";
            this.pnlContainBooking.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainBooking.Size = new System.Drawing.Size(400, 196);
            this.pnlContainBooking.TabIndex = 15;
            // 
            // dpkCustomerBirthday
            // 
            this.dpkCustomerBirthday.CalendarFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkCustomerBirthday.CustomFormat = "dd/MM/yyyy";
            this.dpkCustomerBirthday.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkCustomerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkCustomerBirthday.Location = new System.Drawing.Point(166, 158);
            this.dpkCustomerBirthday.Name = "dpkCustomerBirthday";
            this.dpkCustomerBirthday.Size = new System.Drawing.Size(220, 30);
            this.dpkCustomerBirthday.TabIndex = 2;
            // 
            // txbPrice
            // 
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(166, 241);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(220, 30);
            this.txbPrice.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(10, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá phòng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbRoom
            // 
            this.txbRoom.Enabled = false;
            this.txbRoom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRoom.Location = new System.Drawing.Point(166, 201);
            this.txbRoom.Name = "txbRoom";
            this.txbRoom.Size = new System.Drawing.Size(220, 30);
            this.txbRoom.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(10, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phòng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerName.Location = new System.Drawing.Point(166, 121);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(220, 30);
            this.txbCustomerName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerId.Location = new System.Drawing.Point(166, 81);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.Size = new System.Drawing.Size(220, 30);
            this.txbCustomerId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID khách hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoom
            // 
            this.lblRoom.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRoom.Location = new System.Drawing.Point(0, 40);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(400, 30);
            this.lblRoom.TabIndex = 14;
            this.lblRoom.Text = "Phòng";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCheckin
            // 
            this.txbCheckin.Enabled = false;
            this.txbCheckin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCheckin.Location = new System.Drawing.Point(166, 283);
            this.txbCheckin.Name = "txbCheckin";
            this.txbCheckin.Size = new System.Drawing.Size(220, 30);
            this.txbCheckin.TabIndex = 18;
            // 
            // txbCheckout
            // 
            this.txbCheckout.Enabled = false;
            this.txbCheckout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCheckout.Location = new System.Drawing.Point(166, 323);
            this.txbCheckout.Name = "txbCheckout";
            this.txbCheckout.Size = new System.Drawing.Size(220, 30);
            this.txbCheckout.TabIndex = 19;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBooking.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnBooking.BorderRadius = 20;
            this.btnBooking.BorderSize = 2;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBooking.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBooking.Location = new System.Drawing.Point(271, 364);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(10);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(115, 49);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Booking";
            this.btnBooking.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooking.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderSize = 2;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(15, 15);
            this.btnClose.Location = new System.Drawing.Point(367, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Checkin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(5, 45);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 30);
            this.label10.TabIndex = 21;
            this.label10.Text = "Checkout";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlContainBooking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 196);
            this.panel2.TabIndex = 20;
            // 
            // BookingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BookingView";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(877, 655);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel pnlEdit;
        public Styles.CloseButtonStyle btnClose;
        public System.Windows.Forms.DateTimePicker dpkCustomerBirthday;
        public System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbCustomerId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbbFloor;
        public Styles.AddButtonStyle btnBooking;
        public System.Windows.Forms.FlowLayoutPanel pnlContainRoom;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel pnlContainBooking;
        public System.Windows.Forms.DateTimePicker dpkCheckout;
        public System.Windows.Forms.DateTimePicker dpkCheckin;
        public System.Windows.Forms.TextBox txbCheckout;
        public System.Windows.Forms.TextBox txbCheckin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
    }
}
