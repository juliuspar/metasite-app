using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MetasiteApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                });

            migrationBuilder.CreateTable(
                name: "Calls",
                columns: table => new
                {
                    CallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duration = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.CallId);
                    table.ForeignKey(
                        name: "FK_Calls_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Smses",
                columns: table => new
                {
                    SmsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    PhoneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smses", x => x.SmsId);
                    table.ForeignKey(
                        name: "FK_Smses_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "Number" },
                values: new object[,]
                {
                    { 1, "37067999993" },
                    { 72, "37067999998" },
                    { 71, "37067999994" },
                    { 70, "37067999991" },
                    { 69, "37067999990" },
                    { 68, "37067999992" },
                    { 67, "37067999993" },
                    { 66, "37067999997" },
                    { 65, "37067999998" },
                    { 64, "37067999995" },
                    { 63, "37067999992" },
                    { 62, "37067999998" },
                    { 61, "37067999993" },
                    { 60, "37067999998" },
                    { 59, "37067999993" },
                    { 58, "37067999990" },
                    { 57, "37067999996" },
                    { 56, "37067999994" },
                    { 55, "37067999995" },
                    { 54, "37067999992" },
                    { 53, "37067999996" },
                    { 52, "37067999991" },
                    { 73, "37067999992" },
                    { 51, "37067999994" },
                    { 74, "37067999990" },
                    { 76, "37067999993" },
                    { 97, "37067999991" },
                    { 96, "37067999994" },
                    { 95, "37067999994" },
                    { 94, "37067999990" },
                    { 93, "37067999992" },
                    { 92, "37067999997" },
                    { 91, "37067999992" },
                    { 90, "37067999990" },
                    { 89, "37067999992" },
                    { 88, "37067999992" },
                    { 87, "37067999997" },
                    { 86, "37067999998" },
                    { 85, "37067999994" },
                    { 84, "37067999994" },
                    { 83, "37067999990" },
                    { 82, "37067999993" },
                    { 81, "37067999994" },
                    { 80, "37067999990" },
                    { 79, "37067999998" },
                    { 78, "37067999993" },
                    { 77, "37067999997" },
                    { 75, "37067999990" },
                    { 98, "37067999991" },
                    { 50, "37067999996" },
                    { 48, "37067999994" },
                    { 22, "37067999998" },
                    { 21, "37067999996" },
                    { 20, "37067999995" },
                    { 19, "37067999993" },
                    { 18, "37067999992" },
                    { 17, "37067999992" },
                    { 16, "37067999996" },
                    { 15, "37067999993" },
                    { 14, "37067999993" },
                    { 13, "37067999990" },
                    { 12, "37067999992" },
                    { 11, "37067999991" },
                    { 10, "37067999998" },
                    { 9, "37067999995" },
                    { 8, "37067999993" },
                    { 7, "37067999993" },
                    { 6, "37067999992" },
                    { 5, "37067999997" },
                    { 4, "37067999993" },
                    { 3, "37067999998" },
                    { 2, "37067999990" },
                    { 23, "37067999995" },
                    { 49, "37067999993" },
                    { 24, "37067999990" },
                    { 26, "37067999997" },
                    { 47, "37067999994" },
                    { 46, "37067999990" },
                    { 45, "37067999996" },
                    { 44, "37067999993" },
                    { 43, "37067999995" },
                    { 42, "37067999997" },
                    { 41, "37067999992" },
                    { 40, "37067999995" },
                    { 39, "37067999993" },
                    { 38, "37067999994" },
                    { 37, "37067999998" },
                    { 36, "37067999994" },
                    { 35, "37067999992" },
                    { 34, "37067999997" },
                    { 33, "37067999993" },
                    { 32, "37067999992" },
                    { 31, "37067999996" },
                    { 30, "37067999998" },
                    { 29, "37067999993" },
                    { 28, "37067999997" },
                    { 27, "37067999994" },
                    { 25, "37067999992" },
                    { 99, "37067999993" }
                });

            migrationBuilder.InsertData(
                table: "Calls",
                columns: new[] { "CallId", "Date", "Duration", "PhoneId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(1930), 4, 1 },
                    { 64, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7050), 5, 64 },
                    { 63, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7000), 16, 63 },
                    { 62, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6950), 7, 62 },
                    { 61, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6900), 4, 61 },
                    { 60, new DateTime(2018, 12, 16, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6850), 11, 60 },
                    { 59, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6800), 1, 59 },
                    { 58, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6750), 18, 58 },
                    { 57, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6700), 7, 57 },
                    { 56, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6650), 6, 56 },
                    { 55, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6599), 16, 55 },
                    { 54, new DateTime(2018, 12, 17, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6495), 6, 54 },
                    { 53, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6444), 11, 53 },
                    { 52, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6391), 11, 52 },
                    { 51, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6289), 3, 51 },
                    { 99, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(9107), 12, 99 },
                    { 49, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6189), 10, 49 },
                    { 48, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6139), 6, 48 },
                    { 47, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6089), 13, 47 },
                    { 46, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6038), 9, 46 },
                    { 45, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5988), 6, 45 },
                    { 44, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5934), 5, 44 },
                    { 43, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5844), 9, 43 },
                    { 42, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5794), 4, 42 },
                    { 41, new DateTime(2018, 12, 16, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5743), 8, 41 },
                    { 40, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5693), 17, 40 },
                    { 39, new DateTime(2018, 12, 16, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5642), 1, 39 },
                    { 38, new DateTime(2018, 11, 29, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5591), 18, 38 },
                    { 37, new DateTime(2018, 12, 6, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5541), 19, 37 },
                    { 36, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5489), 15, 36 },
                    { 65, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7161), 17, 65 },
                    { 66, new DateTime(2018, 11, 29, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7214), 16, 66 },
                    { 67, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7265), 15, 67 },
                    { 68, new DateTime(2018, 12, 4, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7315), 7, 68 },
                    { 98, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(9057), 18, 98 },
                    { 97, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(9007), 12, 97 },
                    { 96, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8957), 12, 96 },
                    { 95, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8907), 13, 95 },
                    { 94, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8857), 13, 94 },
                    { 93, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8807), 3, 93 },
                    { 92, new DateTime(2018, 12, 12, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8754), 6, 92 },
                    { 91, new DateTime(2018, 12, 9, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8649), 2, 91 },
                    { 90, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8599), 9, 90 },
                    { 89, new DateTime(2018, 12, 24, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8549), 5, 89 },
                    { 88, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8500), 14, 88 },
                    { 87, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8450), 19, 87 },
                    { 86, new DateTime(2018, 12, 4, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8400), 18, 86 },
                    { 85, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8350), 18, 85 },
                    { 35, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5397), 18, 35 },
                    { 84, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8301), 3, 84 },
                    { 82, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8200), 14, 82 },
                    { 81, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8095), 10, 81 },
                    { 80, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8045), 19, 80 },
                    { 79, new DateTime(2018, 12, 9, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7995), 17, 79 },
                    { 78, new DateTime(2018, 12, 4, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7946), 2, 78 },
                    { 77, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7896), 19, 77 },
                    { 76, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7846), 16, 76 },
                    { 75, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7795), 14, 75 },
                    { 74, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7745), 9, 74 },
                    { 73, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7694), 19, 73 },
                    { 72, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7643), 15, 72 },
                    { 71, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7465), 13, 71 },
                    { 70, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7415), 3, 70 },
                    { 69, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7365), 12, 69 },
                    { 83, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8251), 14, 83 },
                    { 34, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5347), 16, 34 },
                    { 50, new DateTime(2018, 12, 4, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6239), 1, 50 },
                    { 17, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4388), 1, 17 },
                    { 6, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3638), 8, 6 },
                    { 26, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4886), 16, 26 },
                    { 7, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3812), 4, 7 },
                    { 25, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4793), 13, 25 },
                    { 24, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4743), 6, 24 },
                    { 8, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3867), 19, 8 },
                    { 23, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4693), 14, 23 },
                    { 9, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3922), 17, 9 },
                    { 22, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4643), 16, 22 },
                    { 10, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3976), 19, 10 },
                    { 21, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4592), 7, 21 },
                    { 20, new DateTime(2018, 12, 8, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4542), 6, 20 },
                    { 11, new DateTime(2018, 11, 29, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4027), 18, 11 },
                    { 19, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4492), 7, 19 },
                    { 12, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4077), 14, 12 },
                    { 18, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4441), 9, 18 },
                    { 13, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4127), 17, 13 },
                    { 14, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4177), 18, 14 },
                    { 16, new DateTime(2018, 12, 18, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4278), 16, 16 },
                    { 27, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4936), 2, 27 },
                    { 5, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3582), 14, 5 },
                    { 15, new DateTime(2018, 12, 9, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4228), 19, 15 },
                    { 28, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4986), 3, 28 },
                    { 33, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5241), 17, 33 },
                    { 3, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3457), 14, 3 },
                    { 29, new DateTime(2018, 12, 6, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5037), 17, 29 },
                    { 4, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3514), 2, 4 },
                    { 30, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5087), 7, 30 },
                    { 2, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3378), 14, 2 },
                    { 31, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5137), 6, 31 },
                    { 32, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5187), 15, 32 }
                });

            migrationBuilder.InsertData(
                table: "Smses",
                columns: new[] { "SmsId", "Date", "PhoneId" },
                values: new object[,]
                {
                    { 90, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8581), 90 },
                    { 79, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7978), 79 },
                    { 2, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3310), 2 },
                    { 96, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8940), 96 },
                    { 78, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7928), 78 },
                    { 11, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4009), 11 },
                    { 77, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7878), 77 },
                    { 97, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8989), 97 },
                    { 12, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4060), 12 },
                    { 75, new DateTime(2018, 12, 18, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7777), 75 },
                    { 1, new DateTime(2018, 12, 3, 19, 15, 12, 535, DateTimeKind.Local).AddTicks(2125), 1 },
                    { 74, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7727), 74 },
                    { 13, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4110), 13 },
                    { 73, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7676), 73 },
                    { 98, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(9040), 98 },
                    { 72, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7624), 72 },
                    { 14, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4160), 14 },
                    { 76, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7828), 76 },
                    { 10, new DateTime(2018, 12, 24, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3958), 10 },
                    { 95, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8890), 95 },
                    { 81, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8078), 81 },
                    { 5, new DateTime(2018, 12, 16, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3560), 5 },
                    { 91, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8631), 91 },
                    { 89, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8531), 89 },
                    { 4, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3494), 4 },
                    { 88, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8482), 88 },
                    { 92, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8682), 92 },
                    { 6, new DateTime(2018, 12, 9, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3619), 6 },
                    { 87, new DateTime(2018, 12, 18, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8432), 87 },
                    { 86, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8382), 86 },
                    { 7, new DateTime(2018, 12, 12, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3790), 7 },
                    { 71, new DateTime(2018, 12, 17, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7448), 71 },
                    { 93, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8789), 93 },
                    { 3, new DateTime(2018, 12, 17, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3430), 3 },
                    { 84, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8283), 84 },
                    { 8, new DateTime(2018, 12, 4, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3847), 8 },
                    { 83, new DateTime(2018, 12, 1, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8233), 83 },
                    { 94, new DateTime(2018, 12, 24, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8840), 94 },
                    { 82, new DateTime(2018, 12, 12, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8181), 82 },
                    { 9, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(3902), 9 },
                    { 80, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8028), 80 },
                    { 85, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(8333), 85 },
                    { 34, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5326), 34 },
                    { 15, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4210), 15 },
                    { 50, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6222), 50 },
                    { 25, new DateTime(2018, 12, 6, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4775), 25 },
                    { 49, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6171), 49 },
                    { 48, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6122), 48 },
                    { 26, new DateTime(2018, 12, 2, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4867), 26 },
                    { 47, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6071), 47 },
                    { 46, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6021), 46 },
                    { 27, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4919), 27 },
                    { 45, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5970), 45 },
                    { 44, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5876), 44 },
                    { 28, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4969), 28 },
                    { 51, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6272), 51 },
                    { 43, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5826), 43 },
                    { 29, new DateTime(2018, 12, 15, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5020), 29 },
                    { 41, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5725), 41 },
                    { 40, new DateTime(2018, 12, 8, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5675), 40 },
                    { 30, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5069), 30 },
                    { 39, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5624), 39 },
                    { 38, new DateTime(2018, 12, 8, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5574), 38 },
                    { 31, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5120), 31 },
                    { 37, new DateTime(2018, 12, 5, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5523), 37 },
                    { 36, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5453), 36 },
                    { 32, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5170), 32 },
                    { 35, new DateTime(2018, 12, 18, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5380), 35 },
                    { 42, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5776), 42 },
                    { 24, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4725), 24 },
                    { 52, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6359), 52 },
                    { 53, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6426), 53 },
                    { 69, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7348), 69 },
                    { 68, new DateTime(2018, 12, 14, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7297), 68 },
                    { 16, new DateTime(2018, 12, 17, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4260), 16 },
                    { 67, new DateTime(2018, 12, 19, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7247), 67 },
                    { 33, new DateTime(2018, 12, 12, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(5222), 33 },
                    { 66, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7197), 66 },
                    { 17, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4368), 17 },
                    { 65, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7141), 65 },
                    { 64, new DateTime(2018, 12, 24, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7032), 64 },
                    { 18, new DateTime(2018, 11, 28, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4422), 18 },
                    { 63, new DateTime(2018, 12, 18, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6982), 63 },
                    { 62, new DateTime(2018, 12, 21, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6932), 62 },
                    { 19, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4474), 19 },
                    { 61, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6882), 61 },
                    { 60, new DateTime(2018, 11, 30, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6833), 60 },
                    { 20, new DateTime(2018, 12, 13, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4525), 20 },
                    { 59, new DateTime(2018, 12, 10, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6782), 59 },
                    { 58, new DateTime(2018, 12, 4, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6732), 58 },
                    { 21, new DateTime(2018, 12, 23, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4575), 21 },
                    { 57, new DateTime(2018, 12, 3, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6682), 57 },
                    { 56, new DateTime(2018, 12, 16, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6632), 56 },
                    { 22, new DateTime(2018, 12, 9, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4625), 22 },
                    { 55, new DateTime(2018, 12, 7, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6581), 55 },
                    { 54, new DateTime(2018, 12, 16, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(6477), 54 },
                    { 23, new DateTime(2018, 12, 22, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(4675), 23 },
                    { 70, new DateTime(2018, 12, 20, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(7398), 70 },
                    { 99, new DateTime(2018, 12, 11, 19, 15, 12, 538, DateTimeKind.Local).AddTicks(9090), 99 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calls_PhoneId",
                table: "Calls",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Smses_PhoneId",
                table: "Smses",
                column: "PhoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");

            migrationBuilder.DropTable(
                name: "Smses");

            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
