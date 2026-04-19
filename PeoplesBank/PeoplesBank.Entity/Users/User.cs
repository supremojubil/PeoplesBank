using FerPROJ.Web.Libraries.BaseEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Entity.Users {
    public class User : BaseEntity {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
