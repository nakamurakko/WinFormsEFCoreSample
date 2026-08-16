using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsEFCoreSample.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<long>(type: "INTEGER", nullable: false, comment: "著者 ID")
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "著者名"),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "作成日時"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "更新日時")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                },
                comment: "著者");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<long>(type: "INTEGER", nullable: false, comment: "書籍 ID")
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false, comment: "書籍名"),
                    AuthorId = table.Column<long>(type: "INTEGER", nullable: true, comment: "著者 ID"),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "作成日時"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "更新日時")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId");
                },
                comment: "書籍");

            migrationBuilder.CreateTable(
                name: "BookReviews",
                columns: table => new
                {
                    BookReviewId = table.Column<long>(type: "INTEGER", nullable: false, comment: "書評 ID")
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<long>(type: "INTEGER", nullable: true, comment: "書籍 ID"),
                    BookReviewContent = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true, comment: "書評"),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "作成日時"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true, comment: "更新日時")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReviews", x => x.BookReviewId);
                    table.ForeignKey(
                        name: "FK_BookReviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId");
                },
                comment: "書評");

            migrationBuilder.CreateIndex(
                name: "IX_BookReviews_BookId",
                table: "BookReviews",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookReviews");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
