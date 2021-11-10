
using System;
using System.IO;
using System.Windows.Forms;

namespace Above_Premiere.View.OptionPanels
{
    public class ChangeTheResolutionOfAVideo : OptionPanel
    {

        const string TITLE = "Change the resolution of a video";
        const string SUCCESSFUL_FUNCTIONALITY_MESSAGE = "Successful resolution change";

        private Label LabelTextBoxHeight;
        private TextBox TextBoxHeight;
        private Label LabelTextBoxWidth;
        private TextBox TextBoxWidth;

        public ChangeTheResolutionOfAVideo() : base(TITLE)
        {
            this.LabelTextBoxHeight = new Label();
            this.TextBoxHeight = new TextBox();
            this.LabelTextBoxWidth = new Label();
            this.TextBoxWidth = new TextBox();
            setOwnStyles();
        }

        public override void setOwnStyles()
        {
            this.BodyPanel.Controls.Add(LabelTextBoxHeight);
            this.BodyPanel.Controls.Add(TextBoxHeight);
            this.BodyPanel.Controls.Add(LabelTextBoxWidth);
            this.BodyPanel.Controls.Add(TextBoxWidth);

            this.TitlePanelHeader.Location = new System.Drawing.Point(190, 22);
            this.TitlePanelHeader.Size = new System.Drawing.Size(339, 25);


            this.TextBoxPathVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPathVideo.Location = new System.Drawing.Point(31, 59);
            this.TextBoxPathVideo.ReadOnly = true;
            this.TextBoxPathVideo.Size = new System.Drawing.Size(251, 26);
            this.TextBoxPathVideo.TabIndex = 0;


            this.ButtonSearchVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchVideo.Location = new System.Drawing.Point(288, 59);
            this.ButtonSearchVideo.Size = new System.Drawing.Size(75, 26);
            this.ButtonSearchVideo.TabIndex = 1;
            this.ButtonSearchVideo.Text = "Search";
            this.ButtonSearchVideo.UseVisualStyleBackColor = true;


            this.LabelTextBoxNewName.AutoSize = true;
            this.LabelTextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBoxNewName.Location = new System.Drawing.Point(94, 159);
            this.LabelTextBoxNewName.Size = new System.Drawing.Size(269, 36);
            this.LabelTextBoxNewName.TabIndex = 4;
            this.LabelTextBoxNewName.Text = "Place the name you want\nthe resized video to have";


            this.TextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNewName.Location = new System.Drawing.Point(378, 169);
            this.TextBoxNewName.Size = new System.Drawing.Size(251, 26);
            this.TextBoxNewName.TabIndex = 5;


            this.ButtonExecute.Location = new System.Drawing.Point(282, 233);
            this.ButtonExecute.Size = new System.Drawing.Size(146, 25);
            this.ButtonExecute.TabIndex = 6;
            this.ButtonExecute.Text = "Convert";
            this.ButtonExecute.UseVisualStyleBackColor = true;

            this.LabelTextBoxHeight.AutoSize = true;
            this.LabelTextBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBoxHeight.Location = new System.Drawing.Point(480, 28);
            this.LabelTextBoxHeight.Size = new System.Drawing.Size(78, 25);
            this.LabelTextBoxHeight.TabIndex = 7;
            this.LabelTextBoxHeight.Text = "Height";

            this.TextBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHeight.Location = new System.Drawing.Point(572, 27);
            this.TextBoxHeight.Size = new System.Drawing.Size(109, 26);
            this.TextBoxHeight.TabIndex = 8;


            this.LabelTextBoxWidth.AutoSize = true;
            this.LabelTextBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBoxWidth.Location = new System.Drawing.Point(488, 78);
            this.LabelTextBoxWidth.Size = new System.Drawing.Size(78, 25);
            this.LabelTextBoxWidth.TabIndex = 9;
            this.LabelTextBoxWidth.Text = "Width";

            this.TextBoxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWidth.Location = new System.Drawing.Point(572, 78);
            this.TextBoxWidth.Size = new System.Drawing.Size(109, 26);
            this.TextBoxWidth.TabIndex = 10;



        }

        protected override void ButtonExecute_Click(object sender, EventArgs e)
        {
            string extension = Path.GetExtension($@"{this.TextBoxPathVideo.Text}");
            try
            {
                string savePath = path();
                string command = $"/c ffmpeg -i {this.TextBoxPathVideo.Text} -s {this.TextBoxWidth.Text}x{this.TextBoxHeight.Text} {savePath}\\{this.TextBoxNewName.Text}{extension}";
                executeCommand(command, SUCCESSFUL_FUNCTIONALITY_MESSAGE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
