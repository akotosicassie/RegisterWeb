﻿namespace RegisterWeb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }
    }
}