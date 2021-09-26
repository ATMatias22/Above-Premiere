using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere
{
    public partial class FrameLogin : Form
    {
        public FrameLogin()
        {
            InitializeComponent();
        }

        public void addEventClickBtnLogin(EventHandler e)
        {
            btnLogin.Click += new EventHandler(e);
        }


        public void showMessage(string message, string title)
        {
            MessageBox.Show(message,title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void showMessageError(string message, string title)
        {
            MessageBox.Show(message,title,MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void hideForm()
        {
            this.Hide();
        }


        public string getTextBoxUserName()
        {
            return this.textBoxUser.Text;
        }

        public string getTextBoxPassword()
        {
            return this.textBoxPassword.Text;
        }




        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (this.btnTogglePassword.Tag.Equals("invisibility"))
            {
                this.btnTogglePassword.Tag = "visibility";
                this.btnTogglePassword.Image = global::Above_Premiere.Properties.Resources.eye;
                this.textBoxPassword.PasswordChar = (char)CharacterCasing.Normal;
            }
            else
            {
                this.btnTogglePassword.Tag = "invisibility";
                this.btnTogglePassword.Image = global::Above_Premiere.Properties.Resources.invisible_eye;
                this.textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
