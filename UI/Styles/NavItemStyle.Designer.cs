
namespace UI.Styles
{
    partial class NavItemStyle
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
            this.btnNavItem = new UI.Styles.RoundBorderButtonStyle();
            this.SuspendLayout();
            // 
            // btnNavItem
            // 
            this.btnNavItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.btnNavItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.btnNavItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.btnNavItem.BorderRadius = 15;
            this.btnNavItem.BorderSize = 3;
            this.btnNavItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNavItem.FlatAppearance.BorderSize = 0;
            this.btnNavItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.btnNavItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.btnNavItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavItem.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavItem.ForeColor = System.Drawing.Color.White;
            this.btnNavItem.Location = new System.Drawing.Point(0, 0);
            this.btnNavItem.Name = "btnNavItem";
            this.btnNavItem.Size = new System.Drawing.Size(230, 80);
            this.btnNavItem.TabIndex = 0;
            this.btnNavItem.TextColor = System.Drawing.Color.White;
            this.btnNavItem.UseVisualStyleBackColor = false;
            // 
            // NavItemStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnNavItem);
            this.Name = "NavItemStyle";
            this.Size = new System.Drawing.Size(230, 80);
            this.ResumeLayout(false);

        }

        #endregion

        public RoundBorderButtonStyle btnNavItem;
    }
}
