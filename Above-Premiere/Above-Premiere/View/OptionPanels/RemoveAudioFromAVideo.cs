using System;
using System.IO;
using System.Windows.Forms;

namespace Above_Premiere.View.OptionPanels
{
    public class RemoveAudioFromAVideo : OptionPanel
    {
        const string TITLE = "Remover el audio de un video";
        const string SUCCESSFUL_FUNCTIONALITY_MESSAGE = "Extraccion exitosa";


        public RemoveAudioFromAVideo() : base(TITLE)
        {
            setOwnStyles();
        }

        public override void setOwnStyles()
        {

            this.TitlePanelHeader.Location = new System.Drawing.Point(213, 22);
            this.TitlePanelHeader.Size = new System.Drawing.Size(297, 25);


            this.TextBoxPathVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPathVideo.Location = new System.Drawing.Point(177, 27);
            this.TextBoxPathVideo.ReadOnly = true;
            this.TextBoxPathVideo.Size = new System.Drawing.Size(251, 26);
            this.TextBoxPathVideo.TabIndex = 0;


            this.ButtonSearchVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearchVideo.Location = new System.Drawing.Point(434, 27);
            this.ButtonSearchVideo.Size = new System.Drawing.Size(75, 26);
            this.ButtonSearchVideo.TabIndex = 1;
            this.ButtonSearchVideo.Text = "Search";
            this.ButtonSearchVideo.UseVisualStyleBackColor = true;


            this.LabelTextBoxNewName.AutoSize = true;
            this.LabelTextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBoxNewName.Location = new System.Drawing.Point(100, 121);
            this.LabelTextBoxNewName.Size = new System.Drawing.Size(239, 36);
            this.LabelTextBoxNewName.TabIndex = 4;
            this.LabelTextBoxNewName.Text = "Coloque el nombre que quiera \r\nque tenga el video sin audio";


            this.TextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNewName.Location = new System.Drawing.Point(378, 131);
            this.TextBoxNewName.Size = new System.Drawing.Size(251, 26);
            this.TextBoxNewName.TabIndex = 5;

            this.ButtonExecute.Location = new System.Drawing.Point(282, 233);
            this.ButtonExecute.Size = new System.Drawing.Size(146, 25);
            this.ButtonExecute.TabIndex = 6;
            this.ButtonExecute.Text = "Remover audio";
            this.ButtonExecute.UseVisualStyleBackColor = true;



        }

        protected override void ButtonExecute_Click(object sender, EventArgs e)
        {
            string extension = Path.GetExtension($@"{this.TextBoxPathVideo.Text}");
            try
            {
                string savePath = path();
                string command = $"/c ffmpeg -i {this.TextBoxPathVideo.Text} -c copy -an {savePath}\\{this.TextBoxNewName.Text}{extension}";
                executeCommand(command, SUCCESSFUL_FUNCTIONALITY_MESSAGE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
