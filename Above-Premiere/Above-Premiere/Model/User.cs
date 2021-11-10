using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere.Modelo
{
    public class User
    {
         string name;
         string password;

        public User(string nombre, string password)
        {
            this.name = nombre;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

      
    }
}
