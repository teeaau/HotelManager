
namespace UI.Styles
{
    partial class RoomStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomStyle));
            this.btnRoom = new UI.Styles.RoundBorderButtonStyle();
            this.SuspendLayout();
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoom.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRoom.BorderRadius = 50;
            this.btnRoom.BorderSize = 3;
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageSize = new System.Drawing.Size(100, 100);
            this.btnRoom.Location = new System.Drawing.Point(0, 0);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(150, 150);
            this.btnRoom.TabIndex = 0;
            this.btnRoom.Text = "Phòng AAA";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoom.TextColor = System.Drawing.Color.SteelBlue;
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRoom.UseVisualStyleBackColor = false;
            // 
            // RoomStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRoom);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomStyle";
            this.ResumeLayout(false);

        }

        #endregion

        public RoundBorderButtonStyle btnRoom;
    }
}
