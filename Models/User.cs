﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UserStatus { get; set; }

        public User() { }

        public User(string firstName, string lastName, string username, string password, bool userStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            UserStatus = userStatus;
        }
    }
}
