﻿using System.ComponentModel.DataAnnotations;


namespace OnlineShopDemo.Areas.Admin.Models
{
    public class LoginModel
    {

        [Required]
        private string username;
        private string password;
        private bool rememberMe;

        public string UserName
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool RememberMe
        {
            get
            {
                return rememberMe;
            }

            set
            {
                rememberMe = value;
            }
        }
    }
}