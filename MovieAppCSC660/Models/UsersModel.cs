using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class UsersModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UsersModel(string usernameTextBox, string emailTextBox, string passwordTextBox)
        {
            Username = usernameTextBox;
            Email = emailTextBox;
            Password = passwordTextBox;
        }
    }
}
