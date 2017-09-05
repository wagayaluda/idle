namespace IdleMaster
{
    partial class frmWagaSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWagaSettings));
            this.changetimegroupBox = new System.Windows.Forms.GroupBox();
            this.mslabel = new System.Windows.Forms.Label();
            this.timebox = new System.Windows.Forms.TextBox();
            this.changeautonextime = new System.Windows.Forms.Button();
            this.aboutlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changetimegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // changetimegroupBox
            // 
            this.changetimegroupBox.Controls.Add(this.mslabel);
            this.changetimegroupBox.Controls.Add(this.timebox);
            this.changetimegroupBox.Controls.Add(this.changeautonextime);
            this.changetimegroupBox.Location = new System.Drawing.Point(12, 12);
            this.changetimegroupBox.Name = "changetimegroupBox";
            this.changetimegroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.changetimegroupBox.Size = new System.Drawing.Size(523, 68);
            this.changetimegroupBox.TabIndex = 8;
            this.changetimegroupBox.TabStop = false;
            this.changetimegroupBox.Text = "修改自动切换游戏时间间隔";
            // 
            // mslabel
            // 
            this.mslabel.AutoSize = true;
            this.mslabel.Location = new System.Drawing.Point(91, 30);
            this.mslabel.Name = "mslabel";
            this.mslabel.Size = new System.Drawing.Size(23, 15);
            this.mslabel.TabIndex = 2;
            this.mslabel.Text = "ms";
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(11, 24);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(73, 25);
            this.timebox.TabIndex = 1;
            // 
            // changeautonextime
            // 
            this.changeautonextime.Location = new System.Drawing.Point(119, 24);
            this.changeautonextime.Name = "changeautonextime";
            this.changeautonextime.Size = new System.Drawing.Size(100, 27);
            this.changeautonextime.TabIndex = 0;
            this.changeautonextime.Text = "确定";
            this.changeautonextime.UseVisualStyleBackColor = true;
            this.changeautonextime.Click += new System.EventHandler(this.changeautonextime_Click);
            // 
            // aboutlabel
            // 
            this.aboutlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutlabel.AutoSize = true;
            this.aboutlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboutlabel.Location = new System.Drawing.Point(12, 98);
            this.aboutlabel.Name = "aboutlabel";
            this.aboutlabel.Size = new System.Drawing.Size(199, 20);
            this.aboutlabel.TabIndex = 9;
            this.aboutlabel.Text = "哇嘎吖噜哒 魔改制作";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(445, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "V1.2(9.5)";
            // 
            // frmWagaSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutlabel);
            this.Controls.Add(this.changetimegroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWagaSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "魔改设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWagaSettings_FormClosed);
            this.changetimegroupBox.ResumeLayout(false);
            this.changetimegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox changetimegroupBox;
        private System.Windows.Forms.Label mslabel;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Button changeautonextime;
        private System.Windows.Forms.Label aboutlabel;
        private System.Windows.Forms.Label label1;
    }
}