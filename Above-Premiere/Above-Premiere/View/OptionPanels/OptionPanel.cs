using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        //EN CASO DE QUERER AGREGAR MAS ELEMENTOS, SE DEBE COLOCAR EN LA SUB CLASE
        //Y DARLE LOS ESTILOS EN ESA SUB CLASE ATRAVES DEL METODO setOwnStyles();
        //ESTE METODO ES ABSTRACTO EN ESTA CLASE, CUALQUIER OTRA MODIFICACION DE UN COMPONENTE
        //DE ESTA CLASE TAMBIEN DEBE HACERSE EN ESE METODO EN CASO DE ESTAR EN LA SUB CLASE
        //EL METODO setOwnStyles() debe ser llamado en el constructor de la subclase al final de todo
        public OptionPanel(string title)
        {
            ButtonExecute = new Button();
            TextBoxNewName = new TextBox();
            LabelTextBoxNewName = new Label();
            TextBoxPathVideo = new TextBox();
            ButtonSearchVideo = new Button();
            HeaderPanel = new Panel();
            TitlePanelHeader = new Label();
            BodyPanel = new Panel();
            openFileDialog1 = new OpenFileDialog();
            setStyles(title);

            this.Show();

        }

        public void setStyles(string title)
        {
            //AGREGAMOS LOS PANELES AL PANEL PRINCIPAL 
            this.Controls.Add(HeaderPanel);
            this.Controls.Add(BodyPanel);


            //ESTILOS DEL PANEL CONTENDOR, NO SE DEBE TOCAR
            this.Location = new System.Drawing.Point(172, 0);
            this.Size = new System.Drawing.Size(728, 360);

            //NO SE DEBE TOCAR NUNCA EL HEADER PANEL SOLO EL TITLE PANEL
            this.HeaderPanel.Controls.Add(TitlePanelHeader);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Size = new System.Drawing.Size(728, 72);
            this.HeaderPanel.TabIndex = 0;


            //CADA SUB CLASE DEBE COLOCAR SU TAMAÑO Y LOCALIZACION, EL TITULO SERA PASADO POR PARAMETRO ATRAVES DEL LA SUB CLASE
            this.TitlePanelHeader.AutoSize = true;
            this.TitlePanelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePanelHeader.TabIndex = 0;
            this.TitlePanelHeader.Text = title;


            //CADA SUB CLASE TENDRA ESTOS COMPONENTES POR DEFECTO, EN DONDE CADA ESTILO SERA COLOCADO
            //POR LA SUB CLASE, NO SE DEBE TOCAR LOS ESTILOS DEL PROPIO BODYPANEL
            this.BodyPanel.Controls.Add(ButtonExecute);
            this.BodyPanel.Controls.Add(TextBoxNewName);
            this.BodyPanel.Controls.Add(LabelTextBoxNewName);
            this.BodyPanel.Controls.Add(TextBoxPathVideo);
            this.BodyPanel.Controls.Add(ButtonSearchVideo);
            this.BodyPanel.Location = new System.Drawing.Point(0, 72);
            this.BodyPanel.Size = new System.Drawing.Size(728, 288);
            this.BodyPanel.TabIndex = 1;

            this.ButtonSearchVideo.Click += new System.EventHandler(this.ButtonSearchVideo_Click);

            this.ButtonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);


        }


        protected void setPathInTextBox()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxPathVideo.Text = openFileDialog1.FileName;
            }
        }

        protected void ButtonSearchVideo_Click(object sender, EventArgs e)
        {
            setPathInTextBox();
        }

        abstract protected void ButtonExecute_Click(object sender, EventArgs e);




        protected string path()
        {
            string path;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                path = folder.SelectedPath;
            }
            else
            {
                throw new SystemException("You canceled the action");
            }
            return path;
        }


        protected void executeCommand(string command, string successfulMesagge)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe")
            {
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = command
            };

            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
                MessageBox.Show(successfulMesagge, "completed");
            }

            this.TextBoxPathVideo.Text = "";
            this.TextBoxNewName.Text = "";
        }

      


        public abstract void setOwnStyles();
    }
}
