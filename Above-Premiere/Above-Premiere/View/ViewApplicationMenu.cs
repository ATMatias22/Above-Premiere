using Above_Premiere.Modelo;
using Above_Premiere.View.OptionPanels;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Above_Premiere.View
{
    public partial class ViewApplicationMenu : Form
    {

        User userLogin;
        FrameLogin mainView;
        bool isBtnLogout;
        OptionPanel op;


        public ViewApplicationMenu(User userLogin, FrameLogin mainView)
        {
            this.userLogin = userLogin;
            this.mainView = mainView;
            this.isBtnLogout = false;
            InitializeComponent();
            setTitleHeader();
            this.Show();
        }

        private void setTitleHeader()
        {
            this.LabelHeaderTitle.Text = $"Bienvenidos a la aplicacion desktop \n {userLogin.Name}";
        }

        private void setPanel(OptionPanel optionPanel)
        {
            this.PanelBody.Controls.Remove(op);
            this.op = optionPanel;
            this.PanelBody.Controls.Add(op);

        }

        private void ButtonOptionOne_Click(object sender, EventArgs e)
        {
            setPanel(new ChangeFormatToVideoOptionPanel());
        }

        private void ButtonOptionTwo_Click(object sender, EventArgs e)
        {
            setPanel(new ExtractAudioFromVideoToMp3OptionPanel());
        }

        private void ButtonOptionThree_Click(object sender, EventArgs e)
        {
            setPanel(new RemoveAudioFromAVideo());
        }

        private void ButtonOptionFour_Click(object sender, EventArgs e)
        {
            setPanel(new ChangeTheResolutionOfAVideo());

        }

        private void ButtonOptionFive_Click(object sender, EventArgs e)
        {
            setPanel(new ExtractImagesFromVideoEveryXFrames());

        }
 


        private void ViewApplicationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isBtnLogout)
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro de cerrar la aplicacion?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void ViewApplicationMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.isBtnLogout)
            {
                Application.Exit();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.isBtnLogout = true;
            mainView.Show();
            this.Close();

        }
    }
}
