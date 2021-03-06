﻿using System.ComponentModel.DataAnnotations.Schema;
using DAL.Models.Auth;
using AutoMapper;
using DAL.Models.Client;
using DAL.Models.Employee;

namespace DAL.Models.User
{
    [Table("Users")]
    public class UserModel : Model
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Key { get; set; }

        #region Virtual Properties

        public virtual AuthModel Auth { get; set; }

        [IgnoreMap]
        public virtual ClientModel Client { get; set; }

        [IgnoreMap]
        public virtual EmployeeModel Employee { get; set; }
        
        #endregion
    }
}