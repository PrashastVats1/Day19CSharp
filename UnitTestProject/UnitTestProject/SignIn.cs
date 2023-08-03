using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class SignInManager
    {
        public static string SignIn(string username, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "Provide User Name and Password";
            }
            else
            {
                if ((username == "sam1256") && (password == "sam@1256@1256"))
                {
                    msg = "Sign In Success!!";
                }
                else
                {
                    msg = "Sign In Failed!!";
                }
            }
            return msg;
        }
    }
}
