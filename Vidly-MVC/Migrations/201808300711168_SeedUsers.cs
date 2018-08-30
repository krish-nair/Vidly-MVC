namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e237a9de-020d-480a-b13b-822016d19adb', N'admin@vidly.com', 0, N'AL5+slYAtktNGpPhbPb5IfgWhnlZclK/vQjidn7TxhlpC0jjuAkj0cj8CZndKV8bzA==', N'21a9e282-e045-4d3b-a3f8-3a4cb8721c06', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e65c97e0-e3d8-4055-9294-aff2530c2ed0', N'guest@vidly.com', 0, N'ANBZoQ+fgedi/K/RxhD9CxOKtdDCarmXvEcMwWTRqiL4mEeoax3rTIwjdoZ/DbMZXQ==', N'8d9af9cd-88c7-4cdf-9e31-d8abaecf6646', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ae647823-1ecf-457f-97e3-bcb7d2d56fe5', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e237a9de-020d-480a-b13b-822016d19adb', N'ae647823-1ecf-457f-97e3-bcb7d2d56fe5')

");
        }
        
        public override void Down()
        {
        }
    }
}
