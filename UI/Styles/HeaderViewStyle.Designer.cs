
namespace UI.Styles
{
    partial class HeaderViewStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderViewStyle));
            this.btnCloseView = new UI.Styles.RoundBorderButtonStyle();
            this.btnTitleView = new UI.Styles.RoundBorderButtonStyle();
            this.SuspendLayout();
            // 
            // btnCloseView
            // 
            this.btnCloseView.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseView.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCloseView.BorderColor = System.Drawing.Color.Transparent;
            this.btnCloseView.BorderRadius = 10;
            this.btnCloseView.BorderSize = 0;
            this.btnCloseView.FlatAppearance.BorderSize = 0;
            this.btnCloseView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCloseView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCloseView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseView.ForeColor = System.Drawing.Color.Black;
            this.btnCloseView.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseView.Image")));
            this.btnCloseView.ImageSize = new System.Drawing.Size(10, 10);
            this.btnCloseView.Location = new System.Drawing.Point(155, 5);
            this.btnCloseView.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseView.Name = "btnCloseView";
            this.btnCloseView.Size = new System.Drawing.Size(20, 20);
            this.btnCloseView.TabIndex = 4;
            this.btnCloseView.TextColor = System.Drawing.Color.Black;
            this.btnCloseView.UseVisualStyleBackColor = false;
            // 
            // btnTitleView
            // 
            this.btnTitleView.BackColor = System.Drawing.Color.Transparent;
            this.btnTitleView.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTitleView.BorderColor = System.Drawing.Color.Transparent;
            this.btnTitleView.BorderRadius = 5;
            this.btnTitleView.BorderSize = 0;
            this.btnTitleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTitleView.FlatAppearance.BorderSize = 0;
            this.btnTitleView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnTitleView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnTitleView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleView.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitleView.ForeColor = System.Drawing.Color.White;
            this.btnTitleView.Location = new System.Drawing.Point(0, 0);
            this.btnTitleView.Margin = new System.Windows.Forms.Padding(0);
            this.btnTitleView.Name = "btnTitleView";
            this.btnTitleView.Size = new System.Drawing.Size(180, 30);
            this.btnTitleView.TabIndex = 3;
            this.btnTitleView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitleView.TextColor = System.Drawing.Color.White;
            this.btnTitleView.UseVisualStyleBackColor = false;
            // 
            // HeaderViewStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCloseView);
            this.Controls.Add(this.btnTitleView);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.Name = "HeaderViewStyle";
            this.Size = new System.Drawing.Size(180, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public RoundBorderButtonStyle btnTitleView;
        public RoundBorderButtonStyle btnCloseView;
    }
}
