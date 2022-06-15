
namespace UI.Styles
{
    partial class TableStyle<TModel>
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 35);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlData
            // 
            this.pnlData.AutoSize = true;
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.Location = new System.Drawing.Point(0, 35);
            this.pnlData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(400, 0);
            this.pnlData.TabIndex = 1;
            // 
            // TableStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TableStyle";
            this.Size = new System.Drawing.Size(400, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlData;
    }
}
