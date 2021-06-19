namespace QLNhanVien_XoayCa.Controls
{
    partial class HomeTab
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
            this.lbHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHello.Location = new System.Drawing.Point(47, 40);
            this.lbHello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(684, 46);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Phần mềm quản lý nhân viên xoay ca";
            // 
            // HomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lbHello);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeTab";
            this.Size = new System.Drawing.Size(1180, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHello;
    }
}
