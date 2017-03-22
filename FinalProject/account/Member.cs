using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace FinalProject.account
{
    public class Member
    {
        private String username;
        private String password;
        private String repassword;
        private String mail;
        private int capcha;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Repassword
        {
            get { return repassword; }
            set { repassword = value; }
        }

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public int Capcha
        {
            get { return capcha; }
            set { capcha = value; }
        }
    }
}
