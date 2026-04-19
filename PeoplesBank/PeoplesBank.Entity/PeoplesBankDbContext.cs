using FerPROJ.Web.Libraries.BaseDbHelper;
using Microsoft.EntityFrameworkCore;
using PeoplesBank.Entity.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Entity {
    public class PeoplesBankDbContext : BaseDbContext {
        public PeoplesBankDbContext(DbContextOptions<BaseDbContext> options) : base(options) {
        }
    }
}
