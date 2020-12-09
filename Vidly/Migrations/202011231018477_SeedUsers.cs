namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            {
                Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
VALUES
 (N'8a79e096-052b-4057-9683-7a7443aa305a', N'admin@vidly.com',0,N'AEl8VTUiWx1HJw4s9BFqDWcxOoVbQ0oSpIKWk5omui3dxjI9lbcr1fgAWZ6nfvepmQ==', 
N'467b70f2-2e2d-43b5-aa43-df05fb57d231', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f5f8ead2-533d-42f1-baa1-7cb018b1ebf5', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'f5f8ead2-533d-42f1-baa1-7cb018b1ebf5')

");
            }
        }

        public override void Down()
        {
        }
    }
}
