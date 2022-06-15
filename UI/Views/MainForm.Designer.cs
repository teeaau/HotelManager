
namespace UI.Views
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlNavControl = new System.Windows.Forms.Panel();
            this.pnlNavItem = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNavHeader = new System.Windows.Forms.Panel();
            this.pnlViewControl = new System.Windows.Forms.Panel();
            this.pnlViewContent = new System.Windows.Forms.Panel();
            this.pnlHeaderView = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNavControl.SuspendLayout();
            this.pnlViewControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavControl
            // 
            this.pnlNavControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(48)))), ((int)(((byte)(98)))));
            this.pnlNavControl.Controls.Add(this.pnlNavItem);
            this.pnlNavControl.Controls.Add(this.pnlNavHeader);
            this.pnlNavControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavControl.Location = new System.Drawing.Point(0, 0);
            this.pnlNavControl.Name = "pnlNavControl";
            this.pnlNavControl.Size = new System.Drawing.Size(280, 511);
            this.pnlNavControl.TabIndex = 0;
            // 
            // pnlNavItem
            // 
            this.pnlNavItem.AutoScroll = true;
            this.pnlNavItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavItem.Location = new System.Drawing.Point(0, 35);
            this.pnlNavItem.Name = "pnlNavItem";
            this.pnlNavItem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlNavItem.Size = new System.Drawing.Size(280, 476);
            this.pnlNavItem.TabIndex = 1;
            // 
            // pnlNavHeader
            // 
            this.pnlNavHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlNavHeader.Name = "pnlNavHeader";
            this.pnlNavHeader.Size = new System.Drawing.Size(280, 35);
            this.pnlNavHeader.TabIndex = 0;
            // 
            // pnlViewControl
            // 
            this.pnlViewControl.Controls.Add(this.pnlViewContent);
            this.pnlViewControl.Controls.Add(this.pnlHeaderView);
            this.pnlViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewControl.Location = new System.Drawing.Point(280, 0);
            this.pnlViewControl.Name = "pnlViewControl";
            this.pnlViewControl.Size = new System.Drawing.Size(604, 511);
            this.pnlViewControl.TabIndex = 1;
            // 
            // pnlViewContent
            // 
            this.pnlViewContent.AutoScroll = true;
            this.pnlViewContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewContent.Location = new System.Drawing.Point(0, 0);
            this.pnlViewContent.Name = "pnlViewContent";
            this.pnlViewContent.Size = new System.Drawing.Size(604, 511);
            this.pnlViewContent.TabIndex = 4;
            // 
            // pnlHeaderView
            // 
            this.pnlHeaderView.AutoSize = true;
            this.pnlHeaderView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlHeaderView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderView.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderView.Name = "pnlHeaderView";
            this.pnlHeaderView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlHeaderView.Size = new System.Drawing.Size(604, 0);
            this.pnlHeaderView.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pnlViewControl);
            this.Controls.Add(this.pnlNavControl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "II\'s Hotel";
            this.pnlNavControl.ResumeLayout(false);
            this.pnlViewControl.ResumeLayout(false);
            this.pnlViewControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlNavControl;
        public System.Windows.Forms.FlowLayoutPanel pnlNavItem;
        public System.Windows.Forms.Panel pnlNavHeader;
        public System.Windows.Forms.Panel pnlViewControl;
        public System.Windows.Forms.Panel pnlViewContent;
        public System.Windows.Forms.FlowLayoutPanel pnlHeaderView;
    }
}