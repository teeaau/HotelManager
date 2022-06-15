
namespace UI.Views
{
    partial class PaymentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentView));
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCheckout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCheckin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCustomerBirthday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCustomerName = new System.Windows.Forms.TextBox();
            this.txbCustomerId = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlContainBooking = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.cbbFloor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new UI.Styles.AddButtonStyle();
            this.btnClose = new UI.Styles.CloseButtonStyle();
            this.txbDateOfPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.AutoScroll = true;
            this.pnlEdit.BackColor = System.Drawing.Color.LightGray;
            this.pnlEdit.Controls.Add(this.label9);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.btnPay);
            this.pnlEdit.Controls.Add(this.txbDateOfPayment);
            this.pnlEdit.Controls.Add(this.label8);
            this.pnlEdit.Controls.Add(this.txbTotal);
            this.pnlEdit.Controls.Add(this.label7);
            this.pnlEdit.Controls.Add(this.txbCheckout);
            this.pnlEdit.Controls.Add(this.label6);
            this.pnlEdit.Controls.Add(this.txbCheckin);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.txbPrice);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.txbCustomerBirthday);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.txbCustomerName);
            this.pnlEdit.Controls.Add(this.txbCustomerId);
            this.pnlEdit.Controls.Add(this.btnClose);
            this.pnlEdit.Controls.Add(this.lblRoom);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEdit.Location = new System.Drawing.Point(338, 10);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(400, 491);
            this.pnlEdit.TabIndex = 0;
            this.pnlEdit.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(10, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 30);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên khách hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(10, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID khách hàng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(186, 341);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(200, 30);
            this.txbTotal.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(10, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tổng tiền";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCheckout
            // 
            this.txbCheckout.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCheckout.Location = new System.Drawing.Point(186, 301);
            this.txbCheckout.Name = "txbCheckout";
            this.txbCheckout.Size = new System.Drawing.Size(200, 30);
            this.txbCheckout.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(10, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Checkout";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCheckin
            // 
            this.txbCheckin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCheckin.Location = new System.Drawing.Point(186, 261);
            this.txbCheckin.Name = "txbCheckin";
            this.txbCheckin.Size = new System.Drawing.Size(200, 30);
            this.txbCheckin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(10, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Checkin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(186, 221);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(200, 30);
            this.txbPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(10, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá phòng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCustomerBirthday
            // 
            this.txbCustomerBirthday.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerBirthday.Location = new System.Drawing.Point(186, 181);
            this.txbCustomerBirthday.Name = "txbCustomerBirthday";
            this.txbCustomerBirthday.Size = new System.Drawing.Size(200, 30);
            this.txbCustomerBirthday.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerName.Location = new System.Drawing.Point(186, 141);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.Size = new System.Drawing.Size(200, 30);
            this.txbCustomerName.TabIndex = 1;
            // 
            // txbCustomerId
            // 
            this.txbCustomerId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerId.Location = new System.Drawing.Point(186, 101);
            this.txbCustomerId.Name = "txbCustomerId";
            this.txbCustomerId.Size = new System.Drawing.Size(200, 30);
            this.txbCustomerId.TabIndex = 0;
            // 
            // lblRoom
            // 
            this.lblRoom.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRoom.Location = new System.Drawing.Point(0, 40);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(400, 40);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Phòng";
            this.lblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlContainBooking);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(328, 491);
            this.panel2.TabIndex = 1;
            // 
            // pnlContainBooking
            // 
            this.pnlContainBooking.AutoScroll = true;
            this.pnlContainBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainBooking.Location = new System.Drawing.Point(10, 118);
            this.pnlContainBooking.Name = "pnlContainBooking";
            this.pnlContainBooking.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainBooking.Size = new System.Drawing.Size(308, 363);
            this.pnlContainBooking.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbRoom);
            this.panel3.Controls.Add(this.cbbFloor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 108);
            this.panel3.TabIndex = 0;
            // 
            // cbbRoom
            // 
            this.cbbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(86, 51);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(150, 30);
            this.cbbRoom.TabIndex = 6;
            // 
            // cbbFloor
            // 
            this.cbbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFloor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFloor.FormattingEnabled = true;
            this.cbbFloor.Location = new System.Drawing.Point(86, 11);
            this.cbbFloor.Name = "cbbFloor";
            this.cbbFloor.Size = new System.Drawing.Size(150, 30);
            this.cbbFloor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tầng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPay.BorderRadius = 20;
            this.btnPay.BorderSize = 2;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPay.Location = new System.Drawing.Point(236, 431);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 50);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextColor = System.Drawing.Color.SteelBlue;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
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
            this.btnClose.Location = new System.Drawing.Point(365, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // txbDateOfPayment
            // 
            this.txbDateOfPayment.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDateOfPayment.Location = new System.Drawing.Point(186, 380);
            this.txbDateOfPayment.Name = "txbDateOfPayment";
            this.txbDateOfPayment.Size = new System.Drawing.Size(200, 30);
            this.txbDateOfPayment.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(10, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày thanh toán";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEdit);
            this.Name = "PaymentView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(748, 511);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnlContainBooking;
        private System.Windows.Forms.Panel panel3;
        public Styles.CloseButtonStyle btnClose;
        public System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbCustomerId;
        public System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbCheckout;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbCheckin;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbCustomerBirthday;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbCustomerName;
        private System.Windows.Forms.Label label2;
        public Styles.AddButtonStyle btnPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cbbRoom;
        public System.Windows.Forms.ComboBox cbbFloor;
        public System.Windows.Forms.TextBox txbDateOfPayment;
        private System.Windows.Forms.Label label8;
    }
}
