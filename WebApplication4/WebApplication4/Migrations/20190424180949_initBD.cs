using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class initBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    CreditID = table.Column<int>(nullable: false),
                    CreditAbbrev = table.Column<string>(nullable: true),
                    CreditName = table.Column<string>(nullable: true),
                    IsSummer = table.Column<int>(nullable: false),
                    IsSpring = table.Column<int>(nullable: false),
                    IsFall = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.CreditID);
                });

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    DegreeID = table.Column<int>(nullable: false),
                    DegreeAbbrev = table.Column<string>(nullable: true),
                    DegreeName = table.Column<string>(nullable: true),
                    NumberOfTerms = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.DegreeID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false),
                    Family = table.Column<string>(nullable: true),
                    Given = table.Column<string>(nullable: true),
                    Snumber = table.Column<int>(nullable: false),
                    number_919 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "StudentTerms",
                columns: table => new
                {
                    StudentTermID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    Term = table.Column<int>(nullable: false),
                    TermAbbrev = table.Column<string>(nullable: true),
                    TermName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTerms", x => x.StudentTermID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeCredits",
                columns: table => new
                {
                    DegreeCreditID = table.Column<int>(nullable: false),
                    DegreeID = table.Column<int>(nullable: false),
                    CreditID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeCredits", x => x.DegreeCreditID);
                    table.ForeignKey(
                        name: "FK_DegreeCredits_Credits_CreditID",
                        column: x => x.CreditID,
                        principalTable: "Credits",
                        principalColumn: "CreditID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DegreeCredits_Degrees_DegreeID",
                        column: x => x.DegreeID,
                        principalTable: "Degrees",
                        principalColumn: "DegreeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeRequirement",
                columns: table => new
                {
                    DegreeRequirementId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false),
                    RequirementNumber = table.Column<int>(nullable: false),
                    RequirementAbbrev = table.Column<string>(maxLength: 10, nullable: false),
                    RequirementName = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeRequirement", x => x.DegreeRequirementId);
                    table.ForeignKey(
                        name: "FK_DegreeRequirement_Degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degrees",
                        principalColumn: "DegreeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreePlans",
                columns: table => new
                {
                    DegreePlanID = table.Column<int>(nullable: false),
                    StudentID = table.Column<int>(nullable: false),
                    DegreePlanAbbrev = table.Column<string>(nullable: true),
                    DegreePlanName = table.Column<string>(nullable: true),
                    DegreeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreePlans", x => x.DegreePlanID);
                    table.ForeignKey(
                        name: "FK_DegreePlans_Degrees_DegreeID",
                        column: x => x.DegreeID,
                        principalTable: "Degrees",
                        principalColumn: "DegreeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DegreePlans_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    SlotID = table.Column<int>(nullable: false),
                    DegreePlanID = table.Column<int>(nullable: false),
                    Term = table.Column<int>(nullable: false),
                    CreditID = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.SlotID);
                    table.ForeignKey(
                        name: "FK_Slots_Credits_CreditID",
                        column: x => x.CreditID,
                        principalTable: "Credits",
                        principalColumn: "CreditID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Slots_DegreePlans_DegreePlanID",
                        column: x => x.DegreePlanID,
                        principalTable: "DegreePlans",
                        principalColumn: "DegreePlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeCredits_CreditID",
                table: "DegreeCredits",
                column: "CreditID");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeCredits_DegreeID",
                table: "DegreeCredits",
                column: "DegreeID");

            migrationBuilder.CreateIndex(
                name: "IX_DegreePlans_DegreeID",
                table: "DegreePlans",
                column: "DegreeID");

            migrationBuilder.CreateIndex(
                name: "IX_DegreePlans_StudentID",
                table: "DegreePlans",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeRequirement_DegreeId",
                table: "DegreeRequirement",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_CreditID",
                table: "Slots",
                column: "CreditID");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_DegreePlanID",
                table: "Slots",
                column: "DegreePlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DegreeCredits");

            migrationBuilder.DropTable(
                name: "DegreeRequirement");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "StudentTerms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Credits");

            migrationBuilder.DropTable(
                name: "DegreePlans");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
