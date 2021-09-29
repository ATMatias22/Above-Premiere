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

        private void setPathInTextBox(TextBox tb)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb.Text = openFileDialog1.FileName;
            }
        }

        private string path()
        {
            string path;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                path = folder.SelectedPath;
            }
            else
            {
                throw new SystemException("Cancelaste la accion");
            }
            return path;
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



        public void executeCommand(string command)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe")
            {
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = command
            };

            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
                MessageBox.Show("Archivo convertido con exito", "Listo");
            }

            /*this.TextBoxPathVideoChoosenOptionOne.Text = "";
            this.TextBoxNewNameChoosenOptionOne.Text = "";*/
        }


        /*
                private void ButtonExecuteChoosenOptionFour_Click(object sender, EventArgs e)
                {
                    string extension = Path.GetExtension($@"{this.TextBoxPathVideoChoosenOptionFour.Text}");
                    try
                    {
                        string r = path();
                        string command = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionFour.Text} -s {this.TextBoxWidthChoosenOptionFour.Text}x{this.TextBoxHeightChoosenOptionFour.Text} {r}\\{this.TextBoxNewNameChoosenOptionFour.Text}{extension}";
                        executeCommand(command);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                private void ButtonExecuteChoosenOptionFive_Click(object sender, EventArgs e)
                {

                    try
                    {
                        string r = path();
                        string command = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionFive.Text} -y -an -r {this.TextBoxNumberOfPhotosChoosenOptionFive.Text} {r}\\{this.TextBoxNewNameChoosenOptionFive.Text}%d.png";
                        executeCommand(command);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                private void ButtonExecuteChoosenOptionThree_Click(object sender, EventArgs e)
                {

                    string extension = Path.GetExtension($@"{this.TextBoxPathVideoChoosenOptionThree.Text}");
                    try
                    {
                        string r = path();
                        string command = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionThree.Text} -c copy -an {r}\\{this.TextBoxNewNameChoosenOptionThree.Text}{extension}";
                        executeCommand(command);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                private void ButtonExecuteChoosenOptionTwo_Click(object sender, EventArgs e)
                {
                    try
                    {
                        string r = path();
                        string command = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionTwo.Text} -vn -acodec mp3 {r}\\{this.TextBoxNewNameChoosenOptionTwo.Text}.mp3";
                        executeCommand(command);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }*/

        /* private void ButtonExecuteChoosenOptionOne_Click(object sender, EventArgs e)
         {
             string selectedItem = ComboBoxVideoFormatChoosenOptionOne.SelectedItem.ToString();
             try
             {
                 string r = path();
                 string command = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionOne.Text} {r}\\{this.TextBoxNewNameChoosenOptionOne.Text}.{selectedItem}";
                 executeCommand(command);
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }*/






        private void ButtonSearchVideoChoosenOptionTwo_Click(object sender, EventArgs e)
        {
            /*     setPathInTextBox(TextBoxPathVideoChoosenOptionTwo);*/

        }

        private void ButtonSearchVideoChoosenOptionThree_Click(object sender, EventArgs e)
        {
            /*  setPathInTextBox(TextBoxPathVideoChoosenOptionThree);*/

        }

        private void ButtonSearchVideoChoosenOptionFour_Click(object sender, EventArgs e)
        {
            /*   setPathInTextBox(TextBoxPathVideoChoosenOptionFour);*/

        }

        private void ButtonSearchVideoChoosenOptionFive_Click(object sender, EventArgs e)
        {
            /*   setPathInTextBox(TextBoxPathVideoChoosenOptionFive);*/
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
