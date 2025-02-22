namespace MusiCodeWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MusiCodeWebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MusiCodeWebApp.Models.MusiCodeDBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MusiCodeDBModel context)
        {
            #region Manager Types

            //context.managerRoles.AddOrUpdate(x => x.ID, new ManagerRole() { ID = 1, Name = "Admin", IsDeleted = false });
            //context.managerRoles.AddOrUpdate(x => x.ID, new ManagerRole() { ID = 2, Name = "Moderatör", IsDeleted = false });

            #endregion

            #region Manager

            //context.managers.AddOrUpdate(x => x.ID, new Manager() { ID = 1, Name = "Developer", Surname = "Developer", Mail = "dev@dev.com", ManagerRole_ID = 1, Password = "12345", IsActive = true, IsDeleted = false });

            #endregion
        }
    }
}
