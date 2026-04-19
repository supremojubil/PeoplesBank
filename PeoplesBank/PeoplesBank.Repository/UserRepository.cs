using FerPROJ.Web.Libraries.BaseDbHelper;
using PeoplesBank.Entity;
using PeoplesBank.Entity.Users;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Repository {
    public class UserRepository : BaseRepository<PeoplesBankDbContext, UserModel, User> {
        public UserRepository() {
        }

        public UserRepository(PeoplesBankDbContext ts) : base(ts) {
        }
    }
}
