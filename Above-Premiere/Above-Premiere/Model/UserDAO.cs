using Above_Premiere.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Above_Premiere.Modelo
{
    public class UserDAO

    {
        List<User> users;

        public UserDAO()
        {
            this.users = new List<User>();
            createUser();
        }



        private void createUser()
        {
            this.users.Add(new User("Matias", "Matias123"));
            this.users.Add(new User("Alejandro", "Alejandro123"));
            this.users.Add(new User("Juan", "Juan123"));
            this.users.Add(new User("Jose", "Jose123"));
            this.users.Add(new User("Maria", "Maria123"));
            this.users.Add(new User("Lucia", "Lucia123"));
        }



        public User loginUser(String name, String password)
        {
            bool userNameWasFound = false;
            User userFound = null;
            int counter = 0;
            while (counter < this.users.Count && !userNameWasFound)
            {
                User auxUser = this.users[counter];
                if (auxUser.Name.Equals(name))
                {
                    if (auxUser.Password.Equals(password))
                    {
                        userFound = auxUser;
                    }
                    userNameWasFound = true;
                }
                counter++;
            }

            if(userFound == null)
            {
                throw new IncorrectCredentialsException("Some of your credentials are wrong");
            }

            return userFound;
        }

   
    }
}
