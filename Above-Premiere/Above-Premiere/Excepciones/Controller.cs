using Above_Premiere.Modelo;
using Above_Premiere.View;
using System;

using System.Windows.Forms;


namespace Above_Premiere.Excepciones
{
    public  class Controller
    {
        FrameLogin mainView;
        UserDAO userDAO;



        public void start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainView = new FrameLogin();
            userDAO = new UserDAO();
            mainView.addEventClickBtnLogin(handlerBtnLogin);
            Application.Run(mainView);
        }


        private void loginUser()
        {
            try
            {
                User userLoggedIn = userDAO.loginUser(mainView.getTextBoxUserName(), mainView.getTextBoxPassword());
                mainView.showMessage("Log in", "Log in");
                mainView.hideView();
                new ViewApplicationMenu(userLoggedIn,mainView);
                mainView.clearCredentials();
            }
            catch (IncorrectCredentialsException ice)
            {
                mainView.showMessageError(ice.Message, "Error en las credenciales");
            }
        }


        private void handlerBtnLogin(object sender, EventArgs e)
        {
            loginUser();
        }

    }




}
