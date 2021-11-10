
namespace Above_Premiere.View
{
    partial class ViewApplicationMenu
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.PanelHeaderLogo = new System.Windows.Forms.Panel();
            this.LabelHeaderLogo = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.PanelHeaderTitle = new System.Windows.Forms.Panel();
            this.LabelHeaderTitle = new System.Windows.Forms.Label();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.PanelBodyOptionMenu = new System.Windows.Forms.Panel();
            this.ButtonOptionFive = new System.Windows.Forms.Button();
            this.ButtonOptionFour = new System.Windows.Forms.Button();
            this.ButtonOptionThree = new System.Windows.Forms.Button();
            this.ButtonOptionTwo = new System.Windows.Forms.Button();
            this.ButtonOptionOne = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelHeader.SuspendLayout();
            this.PanelHeaderLogo.SuspendLayout();
            this.PanelHeaderTitle.SuspendLayout();
            this.PanelBody.SuspendLayout();
            this.PanelBodyOptionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.PanelHeaderLogo);
            this.PanelHeader.Controls.Add(this.PanelHeaderTitle);
            this.PanelHeader.Location = new System.Drawing.Point(1, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(900, 90);
            this.PanelHeader.TabIndex = 0;
            // 
            // PanelHeaderLogo
            // 
            this.PanelHeaderLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeaderLogo.Controls.Add(this.LabelHeaderLogo);
            this.PanelHeaderLogo.Controls.Add(this.BtnLogout);
            this.PanelHeaderLogo.Location = new System.Drawing.Point(771, 0);
            this.PanelHeaderLogo.Name = "PanelHeaderLogo";
            this.PanelHeaderLogo.Size = new System.Drawing.Size(128, 90);
            this.PanelHeaderLogo.TabIndex = 1;
            // 
            // LabelHeaderLogo
            // 
            this.LabelHeaderLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderLogo.Location = new System.Drawing.Point(3, 58);
            this.LabelHeaderLogo.Name = "LabelHeaderLogo";
            this.LabelHeaderLogo.Size = new System.Drawing.Size(129, 31);
            this.LabelHeaderLogo.TabIndex = 0;
            this.LabelHeaderLogo.Text = "LOGOUT";
            this.LabelHeaderLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Image = global::Above_Premiere.Properties.Resources.logout;
            this.BtnLogout.Location = new System.Drawing.Point(39, 5);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(50, 50);
            this.BtnLogout.TabIndex = 0;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PanelHeaderTitle
            // 
            this.PanelHeaderTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeaderTitle.Controls.Add(this.LabelHeaderTitle);
            this.PanelHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelHeaderTitle.Name = "PanelHeaderTitle";
            this.PanelHeaderTitle.Size = new System.Drawing.Size(771, 90);
            this.PanelHeaderTitle.TabIndex = 0;
            // 
            // LabelHeaderTitle
            // 
            this.LabelHeaderTitle.AutoSize = true;
            this.LabelHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderTitle.Location = new System.Drawing.Point(201, 17);
            this.LabelHeaderTitle.Name = "LabelHeaderTitle";
            this.LabelHeaderTitle.Size = new System.Drawing.Size(398, 50);
            this.LabelHeaderTitle.TabIndex = 0;
            this.LabelHeaderTitle.Text = "Welcome to the desktop application \r\n username";
            this.LabelHeaderTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelBody
            // 
            this.PanelBody.Controls.Add(this.PanelBodyOptionMenu);
            this.PanelBody.Location = new System.Drawing.Point(0, 90);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(900, 360);
            this.PanelBody.TabIndex = 1;
            // 
            // PanelBodyOptionMenu
            // 
            this.PanelBodyOptionMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBodyOptionMenu.Controls.Add(this.ButtonOptionFive);
            this.PanelBodyOptionMenu.Controls.Add(this.ButtonOptionFour);
            this.PanelBodyOptionMenu.Controls.Add(this.ButtonOptionThree);
            this.PanelBodyOptionMenu.Controls.Add(this.ButtonOptionTwo);
            this.PanelBodyOptionMenu.Controls.Add(this.ButtonOptionOne);
            this.PanelBodyOptionMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelBodyOptionMenu.Name = "PanelBodyOptionMenu";
            this.PanelBodyOptionMenu.Size = new System.Drawing.Size(172, 360);
            this.PanelBodyOptionMenu.TabIndex = 0;
            // 
            // ButtonOptionFive
            // 
            this.ButtonOptionFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptionFive.Location = new System.Drawing.Point(0, 289);
            this.ButtonOptionFive.Name = "ButtonOptionFive";
            this.ButtonOptionFive.Size = new System.Drawing.Size(169, 66);
            this.ButtonOptionFive.TabIndex = 4;
            this.ButtonOptionFive.Text = "Extract images from video\nevery X frames";
            this.ButtonOptionFive.UseVisualStyleBackColor = true;
            this.ButtonOptionFive.Click += new System.EventHandler(this.ButtonOptionFive_Click);
            // 
            // ButtonOptionFour
            // 
            this.ButtonOptionFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptionFour.Location = new System.Drawing.Point(0, 218);
            this.ButtonOptionFour.Name = "ButtonOptionFour";
            this.ButtonOptionFour.Size = new System.Drawing.Size(169, 66);
            this.ButtonOptionFour.TabIndex = 3;
            this.ButtonOptionFour.Text = "Change resolution \nfrom a video";
            this.ButtonOptionFour.UseVisualStyleBackColor = true;
            this.ButtonOptionFour.Click += new System.EventHandler(this.ButtonOptionFour_Click);
            // 
            // ButtonOptionThree
            // 
            this.ButtonOptionThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptionThree.Location = new System.Drawing.Point(0, 147);
            this.ButtonOptionThree.Name = "ButtonOptionThree";
            this.ButtonOptionThree.Size = new System.Drawing.Size(169, 66);
            this.ButtonOptionThree.TabIndex = 2;
            this.ButtonOptionThree.Text = "\tRemove audio from a video";
            this.ButtonOptionThree.UseVisualStyleBackColor = true;
            this.ButtonOptionThree.Click += new System.EventHandler(this.ButtonOptionThree_Click);
            // 
            // ButtonOptionTwo
            // 
            this.ButtonOptionTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptionTwo.Location = new System.Drawing.Point(0, 76);
            this.ButtonOptionTwo.Name = "ButtonOptionTwo";
            this.ButtonOptionTwo.Size = new System.Drawing.Size(169, 66);
            this.ButtonOptionTwo.TabIndex = 1;
            this.ButtonOptionTwo.Text = "Extract audio from video  \r\nin .mp3 format";
            this.ButtonOptionTwo.UseVisualStyleBackColor = true;
            this.ButtonOptionTwo.Click += new System.EventHandler(this.ButtonOptionTwo_Click);
            // 
            // ButtonOptionOne
            // 
            this.ButtonOptionOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptionOne.Location = new System.Drawing.Point(0, 5);
            this.ButtonOptionOne.Name = "ButtonOptionOne";
            this.ButtonOptionOne.Size = new System.Drawing.Size(169, 66);
            this.ButtonOptionOne.TabIndex = 0;
            this.ButtonOptionOne.Text = "Change the format to a video";
            this.ButtonOptionOne.UseVisualStyleBackColor = true;
            this.ButtonOptionOne.Click += new System.EventHandler(this.ButtonOptionOne_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ViewApplicationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 451);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelHeader);
            this.MaximizeBox = false;
            this.Name = "ViewApplicationMenu";
            this.Text = "ViewApplicationMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewApplicationMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewApplicationMenu_FormClosed);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeaderLogo.ResumeLayout(false);
            this.PanelHeaderTitle.ResumeLayout(false);
            this.PanelHeaderTitle.PerformLayout();
            this.PanelBody.ResumeLayout(false);
            this.PanelBodyOptionMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel PanelHeaderLogo;
        private System.Windows.Forms.Panel PanelHeaderTitle;
        private System.Windows.Forms.Label LabelHeaderTitle;
        private System.Windows.Forms.Label LabelHeaderLogo;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Panel PanelBodyOptionMenu;
        private System.Windows.Forms.Button ButtonOptionFive;
        private System.Windows.Forms.Button ButtonOptionFour;
        private System.Windows.Forms.Button ButtonOptionThree;
        private System.Windows.Forms.Button ButtonOptionTwo;
        private System.Windows.Forms.Button ButtonOptionOne;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}