using System;
using System.Windows.Forms;

namespace Above_Premiere.View.OptionPanels
{
    public class ExtractImagesFromVideoEveryXFrames: OptionPanel
    {
        const string TITLE = "Extraer imagesnes del video cada X frames";
        const string SUCCESSFUL_FUNCTIONALITY_MESSAGE = "Extraccion de imagenes exitosa";

        private Label LabelTextBoxNumberOfPhotos;
        private TextBox TextBoxNumberOfPhotos;

        public ExtractImagesFromVideoEveryXFrames() : base(TITLE)
        {
            this.LabelTextBoxNumberOfPhotos = new Label();
            this.TextBoxNumberOfPhotos = new TextBox();
            setOwnStyles();

        }

        public override void setOwnStyles()
        {
            this.BodyPanel.Controls.Add(LabelTextBoxNumberOfPhotos);
            this.BodyPanel.Controls.Add(TextBoxNumberOfPhotos);

            this.TitlePanelHeader.Location = new System.Drawing.Point(141, 22);
            this.TitlePanelHeader.Size = new System.Drawing.Size(429, 25);

         

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
            this.LabelTextBoxNewName.Location = new System.Drawing.Point(110, 149);
            this.LabelTextBoxNewName.Size = new System.Drawing.Size(239, 36);
            this.LabelTextBoxNewName.TabIndex = 4;
            this.LabelTextBoxNewName.Text = "Coloque el nombre que quiera \nponerle a cada imagen";


            this.LabelTextBoxNumberOfPhotos.AutoSize = true;
            this.LabelTextBoxNumberOfPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBoxNumberOfPhotos.Location = new System.Drawing.Point(110, 102);
            this.LabelTextBoxNumberOfPhotos.Size = new System.Drawing.Size(240, 18);
            this.LabelTextBoxNumberOfPhotos.TabIndex = 2;
            this.LabelTextBoxNumberOfPhotos.Text = "Cantidad de fotos por segundo";


            this.TextBoxNumberOfPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNumberOfPhotos.Location = new System.Drawing.Point(388, 94);
            this.TextBoxNumberOfPhotos.Size = new System.Drawing.Size(58, 26);
            this.TextBoxNumberOfPhotos.TabIndex = 7;


            this.TextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNewName.Location = new System.Drawing.Point(388, 159);
            this.TextBoxNewName.Size = new System.Drawing.Size(251, 26);
            this.TextBoxNewName.TabIndex = 5;

        

            this.ButtonExecute.Location = new System.Drawing.Point(282, 233);
            this.ButtonExecute.Size = new System.Drawing.Size(146, 25);
            this.ButtonExecute.TabIndex = 6;
            this.ButtonExecute.Text = "Extraer";
            this.ButtonExecute.UseVisualStyleBackColor = true;



        }

        protected override void ButtonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = path();
                string command = $"/c ffmpeg -i {this.TextBoxPathVideo.Text} -y -an -r {this.TextBoxNumberOfPhotos.Text} {savePath}\\{this.TextBoxNewName.Text}%d.png";
                executeCommand(command, SUCCESSFUL_FUNCTIONALITY_MESSAGE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
