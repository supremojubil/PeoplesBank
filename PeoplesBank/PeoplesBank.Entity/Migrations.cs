using FerPROJ.Web.Libraries.BaseDbExtensions;
using FerPROJ.Web.Libraries.BaseDbHelper;
using Microsoft.EntityFrameworkCore;
using PeoplesBank.Entity.Users;
using PeoplesBank.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static PeoplesBank.Data.PeopleBankEnums;

namespace PeoplesBank.Entity {
    public class Migrations : BaseIDbMigration<PeoplesBankDbContext> {
        public async Task RunMigrationAsync(PeoplesBankDbContext dbContext) {
            await dbContext.CreateOrUpdateTableAsync<User>();
            await CreateAdminUserAsync(dbContext);
        }
        public async Task CreateAdminUserAsync(PeoplesBankDbContext dbContext) {
            var adminUsers = await dbContext.GetAllAsync<User>(isCached: false);
            if (adminUsers.Count() <= 0) {
                var adminUserModel = new UserModel {
                    Username = "admin",
                    Password = "admin",
                    Type = UserTypes.Administrator.ToString(),
                    DateCreated = DateTime.Now,
                };
                await dbContext.SaveModelAndCommitAsync<UserModel, User>(adminUserModel);
            }
        }
    }
}
