using Microsoft.EntityFrameworkCore.Migrations;

namespace Code.Together.Migrations
{
    public partial class AddedCodingTaskCompanyConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCodingTask_CodingTasks_CodingTaskId",
                table: "CompanyCodingTask");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCodingTask_Companies_CompanyId",
                table: "CompanyCodingTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyCodingTask",
                table: "CompanyCodingTask");

            migrationBuilder.RenameTable(
                name: "CompanyCodingTask",
                newName: "CompanyCodingTasks");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCodingTask_TenantId",
                table: "CompanyCodingTasks",
                newName: "IX_CompanyCodingTasks_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCodingTask_CompanyId",
                table: "CompanyCodingTasks",
                newName: "IX_CompanyCodingTasks_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCodingTask_CodingTaskId",
                table: "CompanyCodingTasks",
                newName: "IX_CompanyCodingTasks_CodingTaskId");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "CodingTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyCodingTasks",
                table: "CompanyCodingTasks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_JobOfferingInterviews_TenantId",
                table: "JobOfferingInterviews",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCodingTasks_CodingTasks_CodingTaskId",
                table: "CompanyCodingTasks",
                column: "CodingTaskId",
                principalTable: "CodingTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCodingTasks_Companies_CompanyId",
                table: "CompanyCodingTasks",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCodingTasks_CodingTasks_CodingTaskId",
                table: "CompanyCodingTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCodingTasks_Companies_CompanyId",
                table: "CompanyCodingTasks");

            migrationBuilder.DropIndex(
                name: "IX_JobOfferingInterviews_TenantId",
                table: "JobOfferingInterviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyCodingTasks",
                table: "CompanyCodingTasks");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "CodingTasks");

            migrationBuilder.RenameTable(
                name: "CompanyCodingTasks",
                newName: "CompanyCodingTask");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCodingTasks_TenantId",
                table: "CompanyCodingTask",
                newName: "IX_CompanyCodingTask_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCodingTasks_CompanyId",
                table: "CompanyCodingTask",
                newName: "IX_CompanyCodingTask_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCodingTasks_CodingTaskId",
                table: "CompanyCodingTask",
                newName: "IX_CompanyCodingTask_CodingTaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyCodingTask",
                table: "CompanyCodingTask",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCodingTask_CodingTasks_CodingTaskId",
                table: "CompanyCodingTask",
                column: "CodingTaskId",
                principalTable: "CodingTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCodingTask_Companies_CompanyId",
                table: "CompanyCodingTask",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
