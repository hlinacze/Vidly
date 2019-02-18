namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1da8d39f-ac69-40c7-8d12-ba15ffb18a85', N'guest@vidly.com', 0, N'AO8mpcznRqp/KhpG5fm2Ei8kY0+uu+EpIxtK3JUSspG7mbb0jLjyeiRKC+WsWhwGFg==', N'65357f5c-3abf-48c5-baad-69b8e68ac663', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e13a7b6-906a-4c5a-be27-fb5b065028c7', N'admin@vidly.com', 0, N'AI8RQuSYHU0PbwfWtejcYIeviVIsTJaMqOADIec9AO+xAoa0bXGEroEe1FMZBScc4g==', N'd3634543-bde4-4d10-b73a-5699fa6a17c6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0daf8b17-8ed4-4421-accd-bf56f7185f5d', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5e13a7b6-906a-4c5a-be27-fb5b065028c7', N'0daf8b17-8ed4-4421-accd-bf56f7185f5d')            
                ");
        }
        
        public override void Down()
        {
        }
    }
}
