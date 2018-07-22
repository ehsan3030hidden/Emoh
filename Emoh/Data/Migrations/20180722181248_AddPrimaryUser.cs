using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Emoh.Data.Migrations
{
    public partial class AddPrimaryUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'b463d541-b17c-4a63-b467-4d45265c7b40', 0, N'926f8816-f4bf-4e61-b999-a369f48fbce8', N'ehsan8020@gmail.com', 1, 1, NULL, N'EHSAN8020@GMAIL.COM', N'EHSAN8020@GMAIL.COM', N'AQAAAAEAACcQAAAAEBFDbZ4n6x9n5wBA4p1i16pYnz3snmzUU7Rhw+Jmiw5IhyezUWtipZkdBJWOEwMyhA==', NULL, 0, N'9915363a-847d-4d15-98c3-4b052d7cd726', 0, N'ehsan8020@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetUsers]");
    }
    }
}
