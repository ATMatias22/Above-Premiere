using Above_Premiere.Modelo;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Above_Premiere.View
{
    public partial class ViewApplicationMenu : Form
    {

        Panel choosenPanel;
        User userLogin;
        public ViewApplicationMenu(User userLogin)
        {
            this.userLogin = userLogin;
            InitializeComponent();
            setTitleHeader();
        }

        private void setTitleHeader()
        {
            this.LabelHeaderTitle.Text = $"Bienvenidos a la aplicacion desktop \n {userLogin.Name}";
        }

        private void setPanel(Panel p)
        {
            if (this.choosenPanel != null)
            {
                this.choosenPanel.Visible = false;
            }
            this.choosenPanel = p;
            this.choosenPanel.Visible = true;
        }


        private void setPathInTextBox(TextBox tb)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb.Text = openFileDialog1.FileName;
            }
        }



        private void ButtonOptionOne_Click(object sender, EventArgs e)
        {
            setPanel(this.PanelBodyChoosenOptionOne);
        }

        private void ButtonOptionTwo_Click(object sender, EventArgs e)
        {
            setPanel(this.PanelBodyChoosenOptionTwo);
        }

        private void ButtonOptionThree_Click(object sender, EventArgs e)
        {
            setPanel(this.PanelBodyChoosenOptionThree);
        }

        private void ButtonOptionFour_Click(object sender, EventArgs e)
        {
            setPanel(this.PanelBodyChoosenOptionFour);
        }

        private void ButtonOptionFive_Click(object sender, EventArgs e)
        {
            setPanel(this.PanelBodyChoosenOptionFive);
        }

        private string ruta()
        {
            string rutas = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                rutas = folder.SelectedPath;
            }
            else
            {
                throw new SystemException("Se cancelo");
            }
            return rutas;
        }


        public void convertir(string comando)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            startInfo.Arguments = comando;

            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
                MessageBox.Show("Archivo convertido con exito", "Listo");
            }

            this.TextBoxPathVideoChoosenOptionOne.Text = "";
            this.TextBoxNewNameChoosenOptionOne.Text = "";
        }




        private void ButtonExecuteChoosenOptionFour_Click(object sender, EventArgs e)
        {
            string extension = Path.GetExtension($@"{this.TextBoxPathVideoChoosenOptionFour.Text}");
            try
            {
                string r = ruta();
                string comando = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionFour.Text} -s {this.TextBoxWidthChoosenOptionFour.Text}x{this.TextBoxHeightChoosenOptionFour.Text} {r}\\{this.TextBoxNewNameChoosenOptionFour.Text}{extension}";
                convertir(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonExecuteChoosenOptionFive_Click(object sender, EventArgs e)
        {
            
            string extension = Path.GetExtension($@"{this.TextBoxPathVideoChoosenOptionThree.Text}");
            try
            {
                string r = ruta();
                string comando = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionFive.Text} -y -an -r {this.TextBoxNumberOfPhotosChoosenOptionFive.Text} {r}\\{this.TextBoxNewNameChoosenOptionFive.Text}%d.png";
                convertir(comando);
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
                string r = ruta();
                string comando = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionThree.Text} -c copy -an {r}\\{this.TextBoxNewNameChoosenOptionThree.Text}{extension}";
                convertir(comando);
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
                string r = ruta();
                string comando = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionTwo.Text} -vn -acodec mp3 {r}\\{this.TextBoxNewNameChoosenOptionTwo.Text}.mp3";
                convertir(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonExecuteChoosenOptionOne_Click(object sender, EventArgs e)
        {

            string selectedItem = ComboBoxVideoFormatChoosenOptionOne.SelectedItem.ToString() ;

            try
            {
                string r = ruta();
                string comando = $"/c ffmpeg -i {this.TextBoxPathVideoChoosenOptionOne.Text} {r}\\{this.TextBoxNewNameChoosenOptionOne.Text}.{selectedItem}";
                convertir(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }




        private void ButtonSearchVideoChoosenOptionOne_Click(object sender, EventArgs e)
        {
            setPathInTextBox(TextBoxPathVideoChoosenOptionOne);
        }

        private void ButtonSearchVideoChoosenOptionTwo_Click(object sender, EventArgs e)
        {
            setPathInTextBox(TextBoxPathVideoChoosenOptionTwo);

        }

        private void ButtonSearchVideoChoosenOptionThree_Click(object sender, EventArgs e)
        {
            setPathInTextBox(TextBoxPathVideoChoosenOptionThree);

        }

        private void ButtonSearchVideoChoosenOptionFour_Click(object sender, EventArgs e)
        {
            setPathInTextBox(TextBoxPathVideoChoosenOptionFour);

        }

        private void ButtonSearchVideoChoosenOptionFive_Click(object sender, EventArgs e)
        {
            setPathInTextBox(TextBoxPathVideoChoosenOptionFive);
        }
    }
}
