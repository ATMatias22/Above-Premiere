using Above_Premiere.Modelo;
using Above_Premiere.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Above_Premiere.Excepciones
{
    public  class Controller
    {
        FrameLogin viewMain;
        UserDAO userDAO;
        ViewApplicationMenu v;
        User userLoggedIn;



        public void start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            viewMain = new FrameLogin();
            userDAO = new UserDAO();
            viewMain.addEventClickBtnLogin(handlerBtnLogin);

            Application.Run(viewMain);
        }


        private void loginUser()
        {
            try
            {
                userLoggedIn = userDAO.loginUser(viewMain.getTextBoxUserName(), viewMain.getTextBoxPassword());
                viewMain.showMessage("Log in", "Log in");
                v = new ViewApplicationMenu(userLoggedIn);
                v.Show();
                viewMain.hideForm();
            }
            catch (IncorrectCredentialsException ice)
            {
                viewMain.showMessageError(ice.Message, "Error Credentials");
            }

        }




        private void handlerBtnLogin(object sender, EventArgs e)
        {
            loginUser();
        }

    }




}
