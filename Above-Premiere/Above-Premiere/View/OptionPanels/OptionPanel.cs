using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere.View.OptionPanels
{
     abstract public class OptionPanel : Panel
    {

        protected Button ButtonExecute;
        protected TextBox TextBoxNewName;
        protected Label LabelTextBoxNewName;
        protected TextBox TextBoxPathVideo;
        protected Button ButtonSearchVideo;
        protected Panel HeaderPanel;
        protected Label TitlePanelHeader;
        protected Panel BodyPanel;
        protected OpenFileDialog openFileDialog1;


        public OptionPanel(string title)
        {
            ButtonExecute = new Button();
            TextBoxNewName = new TextBox();
            LabelTextBoxNewName = new Label();
            TextBoxPathVideo = new TextBox();
            ButtonSearchVideo = new Button();
            HeaderPanel = new Panel();
            TitlePanelHeader = new Label();
            TitlePanelHeader.Text = title;
            BodyPanel = new Panel();
            openFileDialog1 = new OpenFileDialog();

            setStyles();
        }

        public void setStyles()
        {
            this.Controls.Add(HeaderPanel);
            this.Controls.Add(BodyPanel);

           


            this.Location = new System.Drawing.Point(0, 90);
            this.Size = new System.Drawing.Size(900, 360);
            this.TabIndex = 1;


            this.HeaderPanel.Controls.Add(TitlePanelHeader);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Size = new System.Drawing.Size(728, 72);
            this.HeaderPanel.TabIndex = 0;

            this.TitlePanelHeader.AutoSize = true;
            this.TitlePanelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePanelHeader.TabIndex = 0;


            this.BodyPanel.Controls.Add(ButtonExecute);
            this.BodyPanel.Controls.Add(TextBoxNewName);
            this.BodyPanel.Controls.Add(LabelTextBoxNewName);
            this.BodyPanel.Controls.Add(TextBoxPathVideo);
            this.BodyPanel.Controls.Add(ButtonSearchVideo);
            this.BodyPanel.Controls.Add(HeaderPanel);
            this.BodyPanel.Controls.Add(TitlePanelHeader);
            this.BodyPanel.Location = new System.Drawing.Point(0, 69);
            this.BodyPanel.Size = new System.Drawing.Size(728, 291);
            this.BodyPanel.TabIndex = 1;

            this.ButtonSearchVideo.Click += new System.EventHandler(this.ButtonSearchVideo_Click);


        }

        private void setPathInTextBox()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxPathVideo.Text = openFileDialog1.FileName;
            }
        }

        private void ButtonSearchVideo_Click(object sender, EventArgs e)
        {
            setPathInTextBox();
        }

        public abstract void setOwnStyles();
    }
}
