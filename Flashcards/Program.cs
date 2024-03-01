using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace Flashcards;

public class Flashcards
{
    static void Main(string[] args)
    {
        var DataAccess = new DataAcess();

        DataAccess.CreateTables();
        //SeedData.SeedRecords();

        UserInterface.MainMenu();
    }
}

