using Above_Premiere.Modelo;
using Above_Premiere.View;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

using System.Windows.Forms;


namespace Above_Premiere.Controller
{
    public class Controller
    {
        FrameLogin mainView;
        public void start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainView = new FrameLogin();
            mainView.addEventClickBtnLogin(handlerBtnLogin);
            Application.Run(mainView);
        }


        private void loginUser()
        {
            var client = new RestClient("http://localhost:40100");
            var request = new RestRequest("/api/check", Method.POST);
            request.AddJsonBody(new { Name = mainView.getTextBoxUserName(), Password = mainView.getTextBoxPassword() });
            var response = client.Execute(request);
            var obj = JObject.Parse(response.Content);
            if ((bool)obj["valid"])
            {
                User user = JsonConvert.DeserializeObject<User>(obj["user"].ToString());
                mainView.showMessage(obj["message"].ToString(), obj["title"].ToString());
                mainView.hideView();
                new ViewApplicationMenu(user, mainView);
                mainView.clearCredentials();
            }
            else
            {
                mainView.showMessageError(obj["message"].ToString(), obj["title"].ToString());
            }
        }

        private void handlerBtnLogin(object sender, EventArgs e)
        {
            loginUser();
        }

    }




}
