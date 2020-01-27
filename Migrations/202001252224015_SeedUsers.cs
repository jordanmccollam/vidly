namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6666ec71-5327-42ad-839d-62553bf0395e', N'guest@vidly.com', 0, N'AHAR4U9XuGFKAjS1flgKmvyyX4B83cMNzbfLZyyutG7yYKrG/M1KvSapy/mpYdCX7A==', N'dc4cd7c9-ad6f-443a-acab-77741eb293cb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a6db2252-2691-41f4-957d-3d77a0ac1215', N'admin@vidly.com', 0, N'AHr6BzHqTJo3OtrZj8lPSWTCo4BCpMeFwPhXGVkf4WP0HnE5SgBtTNeYq89VdJ04bw==', N'a14bd697-2cad-4fbd-8c67-3332e1836422', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3ff06a81-4545-4f4a-b158-a7f2e958aa47', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a6db2252-2691-41f4-957d-3d77a0ac1215', N'3ff06a81-4545-4f4a-b158-a7f2e958aa47')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
