using Microsoft.EntityFrameworkCore;
using WinFormsEFCoreSample.DB;

namespace WinFormsEFCoreSample;

internal static class Program
{

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        CreateDatabase();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }

    /// <summary>
    /// データベースを作成する。
    /// </summary>
    private static void CreateDatabase()
    {
        using ApplicationDbContext dbContext = new();

        // DB のマイグレーション
        // https://learn.microsoft.com/ja-jp/dotnet/api/microsoft.entityframeworkcore.migrations.imigrator.migrate
        dbContext.Database.Migrate();
    }

}