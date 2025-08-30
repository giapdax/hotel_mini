﻿using System;

namespace HOTEL_MINI.Model.Entity
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}