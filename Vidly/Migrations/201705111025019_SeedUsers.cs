namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'78333b52-1d33-431d-810f-acf0055ecd35', N'admin@vidly.com', 0, N'ABzy88Qm+cAxsclBAiUY/T7uJrGZyFrj8CoJMavOtw9gY6wZXnJOBUujWKODIa/B0A==', N'ba69adeb-9aa9-462d-b65a-58a599caa09b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fea5f347-62a4-4653-9643-67306430dea3', N'guest@vidly.com', 0, N'AFQxdTwokXdDwn3tDj6JHx1EHV904tSMgFvJq7W3hGtPa0B12YY3I8HKBAa6EQcjxA==', N'02e437b5-d4bd-4123-8f0a-c2a1193782a4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7133b221-de26-4c86-9788-5d366512b9ff', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'78333b52-1d33-431d-810f-acf0055ecd35', N'7133b221-de26-4c86-9788-5d366512b9ff')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
