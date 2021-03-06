namespace Vedly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'68b1d48a-e4f4-41fb-95f8-599e6f392064', N'admin@gmail.com', 0, N'AGhINPaDr8DgmDBRF/2ndoKgRPUokK1Ke23is8E6aX7GcgxvD6W6GK/mfGvRvlRgvQ==', N'1e943cd9-7a1a-4f4c-98bf-a7cc6c203340', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f671915d-7341-46bc-8573-50507368e786', N'guest@gmail.com', 0, N'AFEFCyAUUtcPMpjMTPjubWwJPIrlEErBiezgvcp7dP5CdwbQICwNepf6N1VREmM3CA==', N'e65975e6-cca1-458a-892e-e3e6e04626e3', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'10de2ca5-26da-4166-ab36-a3f047766a80', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'68b1d48a-e4f4-41fb-95f8-599e6f392064', N'10de2ca5-26da-4166-ab36-a3f047766a80')
            
");
        }
        
        public override void Down()
        {
        }
    }
}
