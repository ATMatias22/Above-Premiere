
using System.Windows.Forms;

namespace Above_Premiere.View.OptionPanels
{
    public class ChangeFormatToVideoOptionPanel : OptionPanel
    {
        const string TITLE = "Cambiar formato a un video";
        private Label LabelComboBox;
        private ComboBox ComboBoxVideoFormat;

        public ChangeFormatToVideoOptionPanel() : base(TITLE)
        {
            this.LabelComboBox = new Label();
            this.ComboBoxVideoFormat = new ComboBox();
            setOwnStyles();
            this.Show();

        }

        public override void setOwnStyles()
        {
            this.Controls.Add(LabelComboBox);
            this.Controls.Add(ComboBoxVideoFormat);

            this.TitlePanelHeader.Location = new System.Drawing.Point(220, 22);
            this.TitlePanelHeader.Size = new System.Drawing.Size(277, 25);

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
            this.LabelTextBoxNewName.Size = new System.Drawing.Size(251, 36);
            this.LabelTextBoxNewName.TabIndex = 4;
            this.LabelTextBoxNewName.Text = "Coloque el nombre que quiera \r\nque tenga el video a transformar";

            this.LabelComboBox.AutoSize = true;
            this.LabelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComboBox.Location = new System.Drawing.Point(110, 102);
            this.LabelComboBox.Size = new System.Drawing.Size(238, 18);
            this.LabelComboBox.TabIndex = 2;
            this.LabelComboBox.Text = "Seleccione formato que quiera";


            this.ComboBoxVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVideoFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxVideoFormat.FormattingEnabled = true;
            this.ComboBoxVideoFormat.Items.AddRange(new object[] {
            "mp4",
            "avi",
            "mpeg",
            "flv"});
            this.ComboBoxVideoFormat.Location = new System.Drawing.Point(388, 99);
            this.ComboBoxVideoFormat.Size = new System.Drawing.Size(165, 26);
            this.ComboBoxVideoFormat.TabIndex = 3;


            this.TextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNewName.Location = new System.Drawing.Point(388, 159);
            this.TextBoxNewName.Size = new System.Drawing.Size(251, 26);
            this.TextBoxNewName.TabIndex = 5;


            this.ButtonExecute.Location = new System.Drawing.Point(282, 233);
            this.ButtonExecute.Size = new System.Drawing.Size(146, 25);
            this.ButtonExecute.TabIndex = 6;
            this.ButtonExecute.Text = "Convetir";
            this.ButtonExecute.UseVisualStyleBackColor = true;



        }


     
    }
}
