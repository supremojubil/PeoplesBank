using FerPROJ.Web.Libraries.BaseDbExtensions;
using FerPROJ.Web.Libraries.BaseDbHelper;
using PeoplesBank.Entity.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesBank.Entity {
    public class Migrations : BaseIDbMigration<PeoplesBankDbContext> {
        public async Task RunMigrationAsync(PeoplesBankDbContext dbContext) {
            await dbContext.CreateOrUpdateTableAsync<User>();
        }
    }
}
